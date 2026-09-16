using Microsoft.Data.SqlClient;
using TPGestionFacturas_DAS.Entidades;

namespace TPGestionFacturas_DAS.Datos
{
    internal class ProductoDao
    {
        public List<Producto> Listar()
        {
            List<Producto> productos = new();

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                "SELECT Id, NumeroProducto AS Codigo, Nombre, Precio, Activo FROM Productos ORDER BY Id",
                conexion);

            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                productos.Add(Mapear(lector));
            }

            return productos;
        }

        public List<Producto> ListarActivos()
        {
            List<Producto> productos = new();

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                "SELECT Id, NumeroProducto AS Codigo, Nombre, Precio, Activo FROM Productos WHERE Activo = 1 ORDER BY Nombre",
                conexion);

            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                productos.Add(Mapear(lector));
            }

            return productos;
        }

        public List<Producto> Buscar(string filtro)
        {
            List<Producto> productos = new();

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                """
                SELECT Id, NumeroProducto AS Codigo, Nombre, Precio, Activo
                FROM Productos
                WHERE NumeroProducto LIKE @Filtro OR Nombre LIKE @Filtro
                ORDER BY Nombre
                """,
                conexion);
            comando.Parameters.AddWithValue("@Filtro", $"%{filtro}%");

            using SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                productos.Add(Mapear(lector));
            }

            return productos;
        }

        public Producto? ObtenerPorId(int id)
        {
            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                "SELECT Id, NumeroProducto AS Codigo, Nombre, Precio, Activo FROM Productos WHERE Id = @Id",
                conexion);
            comando.Parameters.AddWithValue("@Id", id);

            using SqlDataReader lector = comando.ExecuteReader();
            if (lector.Read())
            {
                return Mapear(lector);
            }

            return null;
        }

        public bool ExisteCodigo(string codigo, int? excluirId = null)
        {
            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            string sql = "SELECT COUNT(*) FROM Productos WHERE NumeroProducto = @Codigo";
            if (excluirId.HasValue)
            {
                sql += " AND Id <> @ExcluirId";
            }

            using SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Codigo", codigo);
            if (excluirId.HasValue)
            {
                comando.Parameters.AddWithValue("@ExcluirId", excluirId.Value);
            }

            int cantidad = (int)comando.ExecuteScalar();
            return cantidad > 0;
        }

        public int Insertar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Codigo))
                throw new InvalidOperationException("El código no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new InvalidOperationException("El nombre no puede estar vacío.");
            if (producto.Precio < 0)
                throw new InvalidOperationException("El precio no puede ser negativo.");
            if (ExisteCodigo(producto.Codigo))
                throw new InvalidOperationException($"Ya existe un producto con código '{producto.Codigo}'.");

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                """
                INSERT INTO Productos (NumeroProducto, Nombre, Precio, Activo)
                VALUES (@Codigo, @Nombre, @Precio, @Activo);
                SELECT CAST(SCOPE_IDENTITY() AS INT);
                """, conexion);

            comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Activo", producto.Activo);
            return (int)comando.ExecuteScalar()!;
        }

        public int Actualizar(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Codigo))
                throw new InvalidOperationException("El código no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new InvalidOperationException("El nombre no puede estar vacío.");
            if (producto.Precio < 0)
                throw new InvalidOperationException("El precio no puede ser negativo.");
            if (ExisteCodigo(producto.Codigo, producto.Id))
                throw new InvalidOperationException($"Ya existe otro producto con código '{producto.Codigo}'.");

            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                """
                UPDATE Productos
                SET NumeroProducto = @Codigo, Nombre = @Nombre, Precio = @Precio, Activo = @Activo
                WHERE Id = @Id
                """, conexion);

            comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Activo", producto.Activo);
            comando.Parameters.AddWithValue("@Id", producto.Id);
            return comando.ExecuteNonQuery();
        }

        public int Desactivar(int id)
        {
            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand comando = new SqlCommand(
                "UPDATE Productos SET Activo = 0 WHERE Id = @Id",
                conexion);
            comando.Parameters.AddWithValue("@Id", id);
            return comando.ExecuteNonQuery();
        }

        public int EliminarSiNoReferenciado(int id)
        {
            using SqlConnection conexion = Conexion.Crear();
            conexion.Open();

            using SqlCommand hayDetalles = new SqlCommand(
                "SELECT COUNT(*) FROM FacturasDetalles WHERE ProductoId = @Id",
                conexion);
            hayDetalles.Parameters.AddWithValue("@Id", id);

            int cantidad = (int)hayDetalles.ExecuteScalar()!;
            if (cantidad > 0)
            {
                throw new InvalidOperationException("No se puede eliminar: el producto está referenciado en facturas. Se aplicará baja lógica (Activo = 0).");
            }

            using SqlCommand comando = new SqlCommand("DELETE FROM Productos WHERE Id = @Id", conexion);
            comando.Parameters.AddWithValue("@Id", id);
            return comando.ExecuteNonQuery();
        }

        private static Producto Mapear(SqlDataReader lector)
        {
            return new Producto
            {
                Id = (int)lector["Id"],
                Codigo = lector["Codigo"].ToString() ?? string.Empty,
                Nombre = lector["Nombre"].ToString() ?? string.Empty,
                Precio = Convert.ToDecimal(lector["Precio"]),
                Activo = (bool)lector["Activo"]
            };
        }
    }
}
