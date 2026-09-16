using Microsoft.Data.SqlClient;
using TPGestionFacturas_DAS.Entidades;

namespace TPGestionFacturas_DAS.Datos
{
    internal class FacturaDao
    {
        public List<Factura> Listar(DateTime? desde = null, DateTime? hasta = null, string? filtroCliente = null)
        {
            List<Factura> facturas = new();

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            string sql = "SELECT Id, NumeroFactura AS Numero, Fecha, ClienteNombre, ClienteDocumento, Estado, Total FROM Facturas WHERE 1=1";
            if (desde.HasValue) sql += " AND Fecha >= @Desde";
            if (hasta.HasValue) sql += " AND Fecha <= @Hasta";
            if (!string.IsNullOrWhiteSpace(filtroCliente)) sql += " AND (ClienteNombre LIKE @Cliente OR ClienteDocumento LIKE @Cliente)";
            sql += " ORDER BY Numero DESC";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            if (desde.HasValue) comando.Parameters.AddWithValue("@Desde", desde.Value.Date);
            if (hasta.HasValue) comando.Parameters.AddWithValue("@Hasta", hasta.Value.Date);
            if (!string.IsNullOrWhiteSpace(filtroCliente)) comando.Parameters.AddWithValue("@Cliente", $"%{filtroCliente}%");

            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                facturas.Add(MapearFactura(lector));
            }

            return facturas;
        }

        public Factura? ObtenerPorId(int id)
        {
            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                "SELECT Id, NumeroFactura AS Numero, Fecha, ClienteNombre, ClienteDocumento, Estado, Total FROM Facturas WHERE Id = @Id",
                conexion);
            comando.Parameters.AddWithValue("@Id", id);

            using SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                return MapearFactura(lector);
            }

            return null;
        }

        public List<FacturaDetalle> ListarDetalle(int facturaId)
        {
            List<FacturaDetalle> detalles = new();

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                """
                SELECT fd.Id, fd.FacturaId, fd.ProductoId, p.Nombre AS ProductoNombre,
                       fd.Cantidad, fd.PrecioUnitario, fd.Subtotal
                FROM FacturasDetalles fd
                INNER JOIN Productos p ON p.Id = fd.ProductoId
                WHERE fd.FacturaId = @FacturaId
                ORDER BY fd.Id
                """,
                conexion);
            comando.Parameters.AddWithValue("@FacturaId", facturaId);

            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                detalles.Add(MapearDetalle(lector));
            }

            return detalles;
        }

        public int Insertar(Factura factura, IReadOnlyList<FacturaDetalle> detalles)
        {
            if (string.IsNullOrWhiteSpace(factura.ClienteNombre))
                throw new InvalidOperationException("El cliente no puede estar vacío.");
            if (detalles.Count == 0)
                throw new InvalidOperationException("La factura debe tener al menos una línea.");

           
            var duplicados = detalles.GroupBy(d => d.ProductoId).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            if (duplicados.Count > 0)
                throw new InvalidOperationException("No se permite duplicar producto en la misma factura.");

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlTransaction transaccion = conexion.BeginTransaction();
            try
            {
                decimal total = factura.CalcularTotal(detalles);

                int facturaId;
                using (SqlCommand comando = new SqlCommand(
                    """
                    INSERT INTO Facturas (NumeroFactura, Fecha, ClienteNombre, ClienteDocumento, Estado, Total)
                    VALUES ((SELECT ISNULL(MAX(NumeroFactura), 0) + 1 FROM Facturas WITH (UPDLOCK, HOLDLOCK)), @Fecha, @ClienteNombre, @ClienteDocumento, 'Emitida', @Total);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);
                    """,
                    conexion,
                    transaccion))
                {
                    comando.Parameters.AddWithValue("@Fecha", factura.Fecha.Date);
                    comando.Parameters.AddWithValue("@ClienteNombre", factura.ClienteNombre);
                    comando.Parameters.AddWithValue("@ClienteDocumento", factura.ClienteDocumento);
                    comando.Parameters.AddWithValue("@Total", total);
                    facturaId = (int)comando.ExecuteScalar()!;
                }

                foreach (FacturaDetalle detalle in detalles)
                {
                    if (detalle.Cantidad <= 0)
                        throw new InvalidOperationException("La cantidad debe ser mayor a 0.");
                    if (detalle.PrecioUnitario < 0)
                        throw new InvalidOperationException("El precio unitario no puede ser negativo.");

                    decimal subtotal = detalle.CalcularSubtotal();

                    using SqlCommand comando = new SqlCommand(
                        """
                        INSERT INTO FacturasDetalles (FacturaId, ProductoId, Cantidad, PrecioUnitario, Subtotal)
                        VALUES (@FacturaId, @ProductoId, @Cantidad, @PrecioUnitario, @Subtotal)
                        """,
                        conexion,
                        transaccion);

                    comando.Parameters.AddWithValue("@FacturaId", facturaId);
                    comando.Parameters.AddWithValue("@ProductoId", detalle.ProductoId);
                    comando.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    comando.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
                    comando.Parameters.AddWithValue("@Subtotal", subtotal);
                    comando.ExecuteNonQuery();
                }

                transaccion.Commit();
                return facturaId;
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }

        public int Anular(int id)
        {
            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand consultarEstado = new SqlCommand(
                "SELECT Estado FROM Facturas WHERE Id = @Id",
                conexion);
            consultarEstado.Parameters.AddWithValue("@Id", id);

            object? resultado = consultarEstado.ExecuteScalar();
            if (resultado is null || resultado is DBNull)
            {
                throw new InvalidOperationException($"No existe la factura {id}.");
            }

            if (string.Equals((string)resultado, "Anulada", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("La factura ya está anulada. No se puede anular dos veces.");
            }

            using SqlCommand comando = new SqlCommand(
                "UPDATE Facturas SET Estado = @Estado WHERE Id = @Id",
                conexion);
            comando.Parameters.AddWithValue("@Estado", "Anulada");
            comando.Parameters.AddWithValue("@Id", id);
            return comando.ExecuteNonQuery();
        }

        public List<FacturaDetalle> InformePorProducto(DateTime? desde = null, DateTime? hasta = null)
        {
            List<FacturaDetalle> informe = new();

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            string sql = """
                SELECT p.Id AS ProductoId, p.Nombre AS ProductoNombre,
                       SUM(fd.Cantidad) AS CantidadFacturada,
                       SUM(fd.Subtotal) AS MontoTotal
                FROM FacturasDetalles fd
                INNER JOIN Productos p ON p.Id = fd.ProductoId
                INNER JOIN Facturas f ON f.Id = fd.FacturaId
                WHERE 1=1
                """;
            if (desde.HasValue) sql += " AND f.Fecha >= @Desde";
            if (hasta.HasValue) sql += " AND f.Fecha <= @Hasta";
            sql += " GROUP BY p.Id, p.Nombre ORDER BY p.Nombre";

            using SqlCommand comando = new SqlCommand(sql, conexion);
            if (desde.HasValue) comando.Parameters.AddWithValue("@Desde", desde.Value.Date);
            if (hasta.HasValue) comando.Parameters.AddWithValue("@Hasta", hasta.Value.Date);

            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                informe.Add(new FacturaDetalle
                {
                    ProductoId = (int)lector["ProductoId"],
                    ProductoNombre = lector["ProductoNombre"].ToString() ?? string.Empty,
                    Cantidad = Convert.ToInt32(lector["CantidadFacturada"]),
                    Subtotal = Convert.ToDecimal(lector["MontoTotal"]),
                    // PrecioUnitario no aplica en informe, queda 0
                });
            }

            return informe;
        }

        private static Factura MapearFactura(SqlDataReader lector)
        {
            return new Factura
            {
                Id = (int)lector["Id"],
                Numero = (int)lector["Numero"],
                Fecha = (DateTime)lector["Fecha"],
                ClienteNombre = lector["ClienteNombre"].ToString() ?? string.Empty,
                ClienteDocumento = lector["ClienteDocumento"].ToString() ?? string.Empty,
                Estado = lector["Estado"].ToString() ?? "Emitida",
                Total = Convert.ToDecimal(lector["Total"])
            };
        }

        private static FacturaDetalle MapearDetalle(SqlDataReader lector)
        {
            return new FacturaDetalle
            {
                Id = (int)lector["Id"],
                FacturaId = (int)lector["FacturaId"],
                ProductoId = (int)lector["ProductoId"],
                ProductoNombre = lector["ProductoNombre"].ToString() ?? string.Empty,
                Cantidad = (int)lector["Cantidad"],
                PrecioUnitario = Convert.ToDecimal(lector["PrecioUnitario"]),
                Subtotal = Convert.ToDecimal(lector["Subtotal"])
            };
        }
    }
}
