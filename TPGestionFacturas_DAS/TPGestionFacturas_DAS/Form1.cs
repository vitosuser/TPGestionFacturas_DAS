using Microsoft.Data.SqlClient;
using TPGestionFacturas_DAS.Datos;
using TPGestionFacturas_DAS.Entidades;

namespace TPGestionFacturas_DAS
{
    public partial class Form1 : Form
    {
        private readonly ProductoDao _productoDao = new();
        private readonly FacturaDao _facturaDao = new();

        private int? _productoEditandoId;
        private bool _suprimirSeleccionProducto;
        private bool _suprimirSeleccionFactura;

        public Form1()
        {
            InitializeComponent();
            ConectarEventos();
        }

        private void ConectarEventos()
        {
            Load += Form1_Load;

            // Productos (ABM)
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            btnLimpiarBusquedaProducto.Click += btnLimpiarBusquedaProducto_Click;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;

            // Nueva factura (maestro-detalle)
            cmbLineaProducto.SelectedIndexChanged += (_, _) => RecalcularSubtotalLinea();
            nudLineaCantidad.ValueChanged += (_, _) => RecalcularSubtotalLinea();
            btnAgregarLinea.Click += btnAgregarLinea_Click;
            dgvDetalleFactura.CellContentClick += dgvDetalleFactura_CellContentClick;
            btnGrabarFactura.Click += btnGrabarFactura_Click;
            btnCancelarFactura.Click += btnCancelarFactura_Click;

            // Consulta de facturas
            chkFiltroDesde.CheckedChanged += (_, _) => dtpFiltroDesde.Enabled = chkFiltroDesde.Checked;
            chkFiltroHasta.CheckedChanged += (_, _) => dtpFiltroHasta.Enabled = chkFiltroHasta.Checked;
            btnBuscarFacturas.Click += btnBuscarFacturas_Click;
            btnLimpiarFiltrosFacturas.Click += btnLimpiarFiltrosFacturas_Click;
            dgvFacturas.SelectionChanged += dgvFacturas_SelectionChanged;
            btnAnularFactura.Click += btnAnularFactura_Click;

            // Informe
            chkInformeDesde.CheckedChanged += (_, _) => dtpInformeDesde.Enabled = chkInformeDesde.Checked;
            chkInformeHasta.CheckedChanged += (_, _) => dtpInformeHasta.Enabled = chkInformeHasta.Checked;
            btnGenerarInforme.Click += btnGenerarInforme_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            dtpFacturaFecha.Value = DateTime.Today;
            CargarProductos();
            CargarProductosCombo();
            LimpiarFormularioProducto();
        }

        // ------------------------------------------------------------------
        // Productos
        // ------------------------------------------------------------------

        private void CargarProductos(string? filtro = null)
        {
            try
            {
                List<Producto> lista = string.IsNullOrWhiteSpace(filtro)
                    ? _productoDao.Listar()
                    : _productoDao.Buscar(filtro);

                _suprimirSeleccionProducto = true;
                dgvProductos.Rows.Clear();
                foreach (Producto p in lista)
                {
                    dgvProductos.Rows.Add(p.Id, p.Codigo, p.Nombre, p.Precio, p.Activo);
                }
                dgvProductos.ClearSelection();
                _suprimirSeleccionProducto = false;
            }
            catch (Exception ex)
            {
                _suprimirSeleccionProducto = false;
                MostrarError(ex);
            }
        }

        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suprimirSeleccionProducto) return;
            if (dgvProductos.CurrentRow is null) return;

            DataGridViewRow fila = dgvProductos.CurrentRow;
            object? id = fila.Cells[colProdId.Index].Value;
            if (id is null) return;

            _productoEditandoId = Convert.ToInt32(id);
            txtProdCodigo.Text = fila.Cells[colProdCodigo.Index].Value?.ToString() ?? string.Empty;
            txtProdNombre.Text = fila.Cells[colProdNombre.Index].Value?.ToString() ?? string.Empty;
            nudProdPrecio.Value = Convert.ToDecimal(fila.Cells[colProdPrecio.Index].Value ?? 0m);
            chkProdActivo.Checked = Convert.ToBoolean(fila.Cells[colProdActivo.Index].Value ?? true);
            lblProdIdHidden.Text = $"Id: {_productoEditandoId}";
        }

        private void LimpiarFormularioProducto()
        {
            _productoEditandoId = null;
            txtProdCodigo.Clear();
            txtProdNombre.Clear();
            nudProdPrecio.Value = 0;
            chkProdActivo.Checked = true;
            lblProdIdHidden.Text = "Id: —";
            if (txtProdCodigo.CanFocus) txtProdCodigo.Focus();
        }

        private void btnNuevoProducto_Click(object? sender, EventArgs e)
        {
            dgvProductos.ClearSelection();
            LimpiarFormularioProducto();
        }

        private void btnGuardarProducto_Click(object? sender, EventArgs e)
        {
            string codigo = txtProdCodigo.Text.Trim();
            string nombre = txtProdNombre.Text.Trim();
            decimal precio = nudProdPrecio.Value;
            bool activo = chkProdActivo.Checked;

            if (codigo.Length == 0)
            {
                Aviso("Ingrese el código del producto.", "Validación", MessageBoxIcon.Warning);
                txtProdCodigo.Focus();
                return;
            }
            if (nombre.Length == 0)
            {
                Aviso("Ingrese el nombre del producto.", "Validación", MessageBoxIcon.Warning);
                txtProdNombre.Focus();
                return;
            }
            if (precio < 0)
            {
                Aviso("El precio no puede ser negativo.", "Validación", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_productoEditandoId is null)
                {
                    int id = _productoDao.Insertar(new Producto
                    {
                        Codigo = codigo,
                        Nombre = nombre,
                        Precio = precio,
                        Activo = activo
                    });
                    Aviso($"Producto guardado (Id {id}).", "Productos");
                }
                else
                {
                    _productoDao.Actualizar(new Producto
                    {
                        Id = _productoEditandoId.Value,
                        Codigo = codigo,
                        Nombre = nombre,
                        Precio = precio,
                        Activo = activo
                    });
                    Aviso("Producto actualizado.", "Productos");
                }

                CargarProductos(txtBuscarProducto.Text);
                LimpiarFormularioProducto();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnEliminarProducto_Click(object? sender, EventArgs e)
        {
            if (_productoEditandoId is null)
            {
                Aviso("Seleccione un producto de la lista.", "Productos", MessageBoxIcon.Information);
                return;
            }

            int id = _productoEditandoId.Value;
            string nombre = txtProdNombre.Text.Trim();

            DialogResult confirmacion = MessageBox.Show(
                $"¿Eliminar el producto '{nombre}'?" + Environment.NewLine +
                "Si está referenciado en facturas se aplicará baja lógica (Activo = 0).",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirmacion != DialogResult.Yes) return;

            try
            {
                _productoDao.EliminarSiNoReferenciado(id);
                Aviso("Producto eliminado.", "Productos");
            }
            catch (InvalidOperationException)
            {
                DialogResult bajaLogica = MessageBox.Show(
                    "El producto está referenciado en facturas y no puede eliminarse." + Environment.NewLine +
                    "¿Desea aplicar baja lógica (desactivarlo)?",
                    "Baja lógica",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (bajaLogica != DialogResult.Yes) return;

                try
                {
                    _productoDao.Desactivar(id);
                    Aviso("Producto desactivado (Activo = 0).", "Productos");
                }
                catch (Exception ex)
                {
                    MostrarError(ex);
                    return;
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
                return;
            }

            CargarProductos(txtBuscarProducto.Text);
            LimpiarFormularioProducto();
        }

        private void btnBuscarProducto_Click(object? sender, EventArgs e)
        {
            CargarProductos(txtBuscarProducto.Text);
        }

        private void btnLimpiarBusquedaProducto_Click(object? sender, EventArgs e)
        {
            txtBuscarProducto.Clear();
            CargarProductos();
        }

        private void btnCancelarProducto_Click(object? sender, EventArgs e)
        {
            dgvProductos.ClearSelection();
            LimpiarFormularioProducto();
        }

        // ------------------------------------------------------------------
        // Nueva factura
        // ------------------------------------------------------------------

        private void CargarProductosCombo()
        {
            try
            {
                List<Producto> activos = _productoDao.ListarActivos();
                cmbLineaProducto.DataSource = null;
                cmbLineaProducto.DisplayMember = nameof(Producto.Nombre);
                cmbLineaProducto.ValueMember = nameof(Producto.Id);
                cmbLineaProducto.DataSource = activos;
                cmbLineaProducto.SelectedIndex = activos.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void RecalcularSubtotalLinea()
        {
            if (cmbLineaProducto.SelectedItem is Producto producto)
            {
                lblLineaPrecioValor.Text = producto.Precio.ToString("C");
                lblLineaSubtotalValor.Text = (producto.Precio * nudLineaCantidad.Value).ToString("C");
            }
            else
            {
                lblLineaPrecioValor.Text = 0m.ToString("C");
                lblLineaSubtotalValor.Text = 0m.ToString("C");
            }
        }

        private void btnAgregarLinea_Click(object? sender, EventArgs e)
        {
            if (cmbLineaProducto.SelectedItem is not Producto producto)
            {
                Aviso("Seleccione un producto activo.", "Nueva factura", MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                if (fila.Cells[colDetProdId.Index].Value is not null &&
                    Convert.ToInt32(fila.Cells[colDetProdId.Index].Value) == producto.Id)
                {
                    Aviso($"El producto '{producto.Nombre}' ya está en la factura. No se permite duplicarlo.",
                        "Nueva factura", MessageBoxIcon.Warning);
                    return;
                }
            }

            int cantidad = (int)nudLineaCantidad.Value;
            if (cantidad <= 0)
            {
                Aviso("La cantidad debe ser mayor a 0.", "Validación", MessageBoxIcon.Warning);
                return;
            }

            dgvDetalleFactura.Rows.Add(producto.Id, producto.Nombre, cantidad, producto.Precio, producto.Precio * cantidad);
            RefrescarTotalFactura();
            nudLineaCantidad.Value = 1;
        }

        private void dgvDetalleFactura_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDetalleFactura.Columns[e.ColumnIndex] == colDetQuitar)
            {
                dgvDetalleFactura.Rows.RemoveAt(e.RowIndex);
                RefrescarTotalFactura();
            }
        }

        private void RefrescarTotalFactura()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                if (fila.Cells[colDetSubtotal.Index].Value is not null)
                {
                    total += Convert.ToDecimal(fila.Cells[colDetSubtotal.Index].Value);
                }
            }
            lblFacturaTotalValor.Text = total.ToString("C");
        }

        private void btnGrabarFactura_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFacturaClienteNombre.Text))
            {
                Aviso("Complete el nombre del cliente.", "Validación", MessageBoxIcon.Warning);
                txtFacturaClienteNombre.Focus();
                return;
            }
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                Aviso("La factura debe tener al menos una línea.", "Validación", MessageBoxIcon.Warning);
                return;
            }

            Factura factura = new()
            {
                Fecha = dtpFacturaFecha.Value.Date,
                ClienteNombre = txtFacturaClienteNombre.Text.Trim(),
                ClienteDocumento = txtFacturaClienteDoc.Text.Trim()
            };

            List<FacturaDetalle> detalles = new();
            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                detalles.Add(new FacturaDetalle
                {
                    ProductoId = Convert.ToInt32(fila.Cells[colDetProdId.Index].Value),
                    Cantidad = Convert.ToInt32(fila.Cells[colDetCantidad.Index].Value),
                    PrecioUnitario = Convert.ToDecimal(fila.Cells[colDetPrecioUnitario.Index].Value)
                });
            }

            try
            {
                int id = _facturaDao.Insertar(factura, detalles);
                Factura? guardada = _facturaDao.ObtenerPorId(id);
                Aviso($"Factura N° {guardada?.Numero} grabada correctamente." + Environment.NewLine +
                      $"Total: {guardada?.Total:C}",
                    "Factura emitida");
                LimpiarNuevaFactura();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void LimpiarNuevaFactura()
        {
            dgvDetalleFactura.Rows.Clear();
            txtFacturaClienteNombre.Clear();
            txtFacturaClienteDoc.Clear();
            dtpFacturaFecha.Value = DateTime.Today;
            nudLineaCantidad.Value = 1;
            RefrescarTotalFactura();
            CargarProductosCombo();
        }

        private void btnCancelarFactura_Click(object? sender, EventArgs e)
        {
            LimpiarNuevaFactura();
        }

        // ------------------------------------------------------------------
        // Consulta de facturas
        // ------------------------------------------------------------------

        private void btnBuscarFacturas_Click(object? sender, EventArgs e)
        {
            DateTime? desde = chkFiltroDesde.Checked ? dtpFiltroDesde.Value.Date : null;
            DateTime? hasta = chkFiltroHasta.Checked ? dtpFiltroHasta.Value.Date : null;
            string? cliente = string.IsNullOrWhiteSpace(txtFiltroCliente.Text) ? null : txtFiltroCliente.Text.Trim();

            if (desde.HasValue && hasta.HasValue && desde > hasta)
            {
                Aviso("La fecha 'Desde' no puede ser mayor que 'Hasta'.", "Validación", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Factura> facturas = _facturaDao.Listar(desde, hasta, cliente);

                _suprimirSeleccionFactura = true;
                dgvFacturas.Rows.Clear();
                foreach (Factura f in facturas)
                {
                    dgvFacturas.Rows.Add(f.Id, f.Numero, f.Fecha.ToString("d"), f.ClienteNombre, f.ClienteDocumento, f.Estado, f.Total);
                }
                dgvFacturas.ClearSelection();
                _suprimirSeleccionFactura = false;

                LimpiarDetalleConsulta();

                if (facturas.Count == 0)
                {
                    Aviso("No hay facturas en el período.", "Consulta", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                _suprimirSeleccionFactura = false;
                MostrarError(ex);
            }
        }

        private void LimpiarDetalleConsulta()
        {
            lblConsultaDetNumeroValor.Text = "—";
            lblConsultaDetFechaValor.Text = "—";
            lblConsultaDetClienteValor.Text = "—";
            lblConsultaDetDocumentoValor.Text = "—";
            lblConsultaDetEstadoValor.Text = "—";
            lblConsultaDetTotalValor.Text = 0m.ToString("C");
            dgvConsultaDetalle.Rows.Clear();
        }

        private void dgvFacturas_SelectionChanged(object? sender, EventArgs e)
        {
            if (_suprimirSeleccionFactura) return;
            if (dgvFacturas.CurrentRow is null) return;

            object? id = dgvFacturas.CurrentRow.Cells[colFacId.Index].Value;
            if (id is null) return;

            int facturaId = Convert.ToInt32(id);
            try
            {
                Factura? f = _facturaDao.ObtenerPorId(facturaId);
                if (f is null)
                {
                    LimpiarDetalleConsulta();
                    return;
                }

                lblConsultaDetNumeroValor.Text = f.Numero.ToString();
                lblConsultaDetFechaValor.Text = f.Fecha.ToString("d");
                lblConsultaDetClienteValor.Text = f.ClienteNombre;
                lblConsultaDetDocumentoValor.Text = f.ClienteDocumento;
                lblConsultaDetEstadoValor.Text = f.Estado;
                lblConsultaDetTotalValor.Text = f.Total.ToString("C");

                dgvConsultaDetalle.Rows.Clear();
                foreach (FacturaDetalle d in _facturaDao.ListarDetalle(facturaId))
                {
                    dgvConsultaDetalle.Rows.Add(d.ProductoNombre, d.Cantidad, d.PrecioUnitario.ToString("C"), d.Subtotal.ToString("C"));
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void btnLimpiarFiltrosFacturas_Click(object? sender, EventArgs e)
        {
            chkFiltroDesde.Checked = false;
            chkFiltroHasta.Checked = false;
            txtFiltroCliente.Clear();

            _suprimirSeleccionFactura = true;
            dgvFacturas.Rows.Clear();
            _suprimirSeleccionFactura = false;

            LimpiarDetalleConsulta();
        }

        private void btnAnularFactura_Click(object? sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow is null || dgvFacturas.CurrentRow.Cells[colFacId.Index].Value is null)
            {
                Aviso("Seleccione una factura para anular.", "Anulación", MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[colFacId.Index].Value);
            string numero = dgvFacturas.CurrentRow.Cells[colFacNumero.Index].Value?.ToString() ?? "?";

            DialogResult confirmacion = MessageBox.Show(
                $"¿Anular la factura N° {numero}?" + Environment.NewLine +
                "La anulación no elimina el registro y no puede revertirse.",
                "Confirmar anulación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirmacion != DialogResult.Yes) return;

            try
            {
                _facturaDao.Anular(id);
                Aviso($"Factura N° {numero} anulada.", "Anulación");
                btnBuscarFacturas_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // ------------------------------------------------------------------
        // Informe
        // ------------------------------------------------------------------

        private void btnGenerarInforme_Click(object? sender, EventArgs e)
        {
            DateTime? desde = chkInformeDesde.Checked ? dtpInformeDesde.Value.Date : null;
            DateTime? hasta = chkInformeHasta.Checked ? dtpInformeHasta.Value.Date : null;

            if (desde.HasValue && hasta.HasValue && desde > hasta)
            {
                Aviso("La fecha 'Desde' no puede ser mayor que 'Hasta'.", "Validación", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<FacturaDetalle> informe = _facturaDao.InformePorProducto(desde, hasta);

                dgvInforme.Rows.Clear();
                int totalUnidades = 0;
                decimal totalMonto = 0;

                foreach (FacturaDetalle fila in informe)
                {
                    dgvInforme.Rows.Add(fila.ProductoNombre, fila.Cantidad, fila.Subtotal.ToString("C"));
                    totalUnidades += fila.Cantidad;
                    totalMonto += fila.Subtotal;
                }

                if (informe.Count == 0)
                {
                    lblInformeResumen.Text = "No hay facturas en el período.";
                }
                else
                {
                    lblInformeResumen.Text = $"{informe.Count} producto(s) — {totalUnidades} unidad(es) — {totalMonto:C}";
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        // ------------------------------------------------------------------
        // Errores / avisos
        // ------------------------------------------------------------------

        private static void Aviso(string mensaje, string titulo, MessageBoxIcon icono = MessageBoxIcon.Information)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        private void MostrarError(Exception ex)
        {
            switch (ex)
            {
                case InvalidOperationException io:
                    MessageBox.Show(io.Message, "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case SqlException sql when sql.Number == 2627 || sql.Number == 2601:
                    MessageBox.Show("Ya existe un registro con ese mismo valor (código o número duplicado).",
                        "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case SqlException sql when sql.Number == 547:
                    MessageBox.Show("La operación no es posible porque el registro está relacionado con facturas.",
                        "Relación existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case SqlException sql when EsErrorDeConexion(sql):
                    MessageBox.Show("No se pudo conectar con SQL Server (LocalDB). Verifique el servicio." +
                        Environment.NewLine + Environment.NewLine + sql.Message,
                        "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case SqlException sql:
                    MessageBox.Show("Error de base de datos: " + sql.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                default:
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        private static bool EsErrorDeConexion(SqlException ex)
        {
            int[] numeros = { -2, 0, 2, 53, 233, 4060, 10053, 10054, 10060, 11001, 18456, 49918, 49919, 49920 };
            return numeros.Contains(ex.Number) || ex.InnerException is SqlException;
        }
    }
}
