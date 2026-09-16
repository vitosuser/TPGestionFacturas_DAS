namespace TPGestionFacturas_DAS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabProductos = new TabPage();
            lblBuscarProducto = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            btnLimpiarBusquedaProducto = new Button();
            dgvProductos = new DataGridView();
            colProdId = new DataGridViewTextBoxColumn();
            colProdCodigo = new DataGridViewTextBoxColumn();
            colProdNombre = new DataGridViewTextBoxColumn();
            colProdPrecio = new DataGridViewTextBoxColumn();
            colProdActivo = new DataGridViewCheckBoxColumn();
            grpProductoDatos = new GroupBox();
            lblProdCodigo = new Label();
            txtProdCodigo = new TextBox();
            lblProdNombre = new Label();
            txtProdNombre = new TextBox();
            lblProdPrecio = new Label();
            nudProdPrecio = new NumericUpDown();
            chkProdActivo = new CheckBox();
            lblProdIdHidden = new Label();
            btnNuevoProducto = new Button();
            btnGuardarProducto = new Button();
            btnEliminarProducto = new Button();
            btnCancelarProducto = new Button();
            tabNuevaFactura = new TabPage();
            grpFacturaCabecera = new GroupBox();
            lblFacturaFecha = new Label();
            dtpFacturaFecha = new DateTimePicker();
            lblFacturaClienteNombre = new Label();
            txtFacturaClienteNombre = new TextBox();
            lblFacturaClienteDoc = new Label();
            txtFacturaClienteDoc = new TextBox();
            grpFacturaAgregarLinea = new GroupBox();
            lblLineaProducto = new Label();
            cmbLineaProducto = new ComboBox();
            lblLineaCantidad = new Label();
            nudLineaCantidad = new NumericUpDown();
            lblLineaPrecioUnitario = new Label();
            lblLineaPrecioValor = new Label();
            lblLineaSubtotal = new Label();
            lblLineaSubtotalValor = new Label();
            btnAgregarLinea = new Button();
            dgvDetalleFactura = new DataGridView();
            colDetProdId = new DataGridViewTextBoxColumn();
            colDetProducto = new DataGridViewTextBoxColumn();
            colDetCantidad = new DataGridViewTextBoxColumn();
            colDetPrecioUnitario = new DataGridViewTextBoxColumn();
            colDetSubtotal = new DataGridViewTextBoxColumn();
            colDetQuitar = new DataGridViewButtonColumn();
            lblFacturaTotal = new Label();
            lblFacturaTotalValor = new Label();
            btnGrabarFactura = new Button();
            btnCancelarFactura = new Button();
            lblFacturaNuevaAviso = new Label();
            tabConsultaFacturas = new TabPage();
            grpConsultaFiltros = new GroupBox();
            chkFiltroDesde = new CheckBox();
            dtpFiltroDesde = new DateTimePicker();
            chkFiltroHasta = new CheckBox();
            dtpFiltroHasta = new DateTimePicker();
            lblFiltroCliente = new Label();
            txtFiltroCliente = new TextBox();
            btnBuscarFacturas = new Button();
            btnLimpiarFiltrosFacturas = new Button();
            btnAnularFactura = new Button();
            dgvFacturas = new DataGridView();
            colFacId = new DataGridViewTextBoxColumn();
            colFacNumero = new DataGridViewTextBoxColumn();
            colFacFecha = new DataGridViewTextBoxColumn();
            colFacCliente = new DataGridViewTextBoxColumn();
            colFacDocumento = new DataGridViewTextBoxColumn();
            colFacEstado = new DataGridViewTextBoxColumn();
            colFacTotal = new DataGridViewTextBoxColumn();
            splitConsultaDetalle = new SplitContainer();
            grpConsultaCabecera = new GroupBox();
            lblConsultaDetNumero = new Label();
            lblConsultaDetNumeroValor = new Label();
            lblConsultaDetFecha = new Label();
            lblConsultaDetFechaValor = new Label();
            lblConsultaDetCliente = new Label();
            lblConsultaDetClienteValor = new Label();
            lblConsultaDetDocumento = new Label();
            lblConsultaDetDocumentoValor = new Label();
            lblConsultaDetTotal = new Label();
            lblConsultaDetTotalValor = new Label();
            lblConsultaDetEstado = new Label();
            lblConsultaDetEstadoValor = new Label();
            lblConsultaSoloLectura = new Label();
            dgvConsultaDetalle = new DataGridView();
            colConsDetProducto = new DataGridViewTextBoxColumn();
            colConsDetCantidad = new DataGridViewTextBoxColumn();
            colConsDetPrecio = new DataGridViewTextBoxColumn();
            colConsDetSubtotal = new DataGridViewTextBoxColumn();
            tabInforme = new TabPage();
            grpInformePeriodo = new GroupBox();
            chkInformeDesde = new CheckBox();
            dtpInformeDesde = new DateTimePicker();
            chkInformeHasta = new CheckBox();
            dtpInformeHasta = new DateTimePicker();
            btnGenerarInforme = new Button();
            dgvInforme = new DataGridView();
            colInfProducto = new DataGridViewTextBoxColumn();
            colInfCantidad = new DataGridViewTextBoxColumn();
            colInfMonto = new DataGridViewTextBoxColumn();
            lblInformeResumen = new Label();
            lblInformeVacio = new Label();
            lblTituloApp = new Label();
            tabControlMain.SuspendLayout();
            tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grpProductoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProdPrecio).BeginInit();
            tabNuevaFactura.SuspendLayout();
            grpFacturaCabecera.SuspendLayout();
            grpFacturaAgregarLinea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLineaCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            tabConsultaFacturas.SuspendLayout();
            grpConsultaFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitConsultaDetalle).BeginInit();
            splitConsultaDetalle.Panel1.SuspendLayout();
            splitConsultaDetalle.Panel2.SuspendLayout();
            splitConsultaDetalle.SuspendLayout();
            grpConsultaCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaDetalle).BeginInit();
            tabInforme.SuspendLayout();
            grpInformePeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).BeginInit();
            SuspendLayout();
            // 
            // lblTituloApp
            // 
            lblTituloApp.Dock = DockStyle.Top;
            lblTituloApp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloApp.Location = new Point(0, 0);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Padding = new Padding(12, 8, 0, 0);
            lblTituloApp.Size = new Size(1100, 38);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Text = "Gestión de Facturas — Comercio";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabProductos);
            tabControlMain.Controls.Add(tabNuevaFactura);
            tabControlMain.Controls.Add(tabConsultaFacturas);
            tabControlMain.Controls.Add(tabInforme);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 38);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1100, 662);
            tabControlMain.TabIndex = 1;
            // 
            // tabProductos
            // 
            tabProductos.Controls.Add(lblBuscarProducto);
            tabProductos.Controls.Add(txtBuscarProducto);
            tabProductos.Controls.Add(btnBuscarProducto);
            tabProductos.Controls.Add(btnLimpiarBusquedaProducto);
            tabProductos.Controls.Add(dgvProductos);
            tabProductos.Controls.Add(grpProductoDatos);
            tabProductos.Location = new Point(4, 29);
            tabProductos.Name = "tabProductos";
            tabProductos.Padding = new Padding(10);
            tabProductos.Size = new Size(1092, 629);
            tabProductos.TabIndex = 0;
            tabProductos.Text = "Productos";
            tabProductos.UseVisualStyleBackColor = true;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(13, 14);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(138, 20);
            lblBuscarProducto.TabIndex = 0;
            lblBuscarProducto.Text = "Código o Nombre:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(157, 11);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar por código o nombre...";
            txtBuscarProducto.Size = new Size(320, 27);
            txtBuscarProducto.TabIndex = 1;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(483, 10);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(90, 29);
            btnBuscarProducto.TabIndex = 2;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarBusquedaProducto
            // 
            btnLimpiarBusquedaProducto.Location = new Point(579, 10);
            btnLimpiarBusquedaProducto.Name = "btnLimpiarBusquedaProducto";
            btnLimpiarBusquedaProducto.Size = new Size(90, 29);
            btnLimpiarBusquedaProducto.TabIndex = 3;
            btnLimpiarBusquedaProducto.Text = "Limpiar";
            btnLimpiarBusquedaProducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colProdId, colProdCodigo, colProdNombre, colProdPrecio, colProdActivo });
            dgvProductos.Location = new Point(13, 48);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1066, 360);
            dgvProductos.TabIndex = 4;
            // 
            // colProdId
            // 
            colProdId.HeaderText = "Id";
            colProdId.MinimumWidth = 6;
            colProdId.Name = "colProdId";
            colProdId.ReadOnly = true;
            colProdId.Visible = false;
            // 
            // colProdCodigo
            // 
            colProdCodigo.FillWeight = 25F;
            colProdCodigo.HeaderText = "Código";
            colProdCodigo.MinimumWidth = 6;
            colProdCodigo.Name = "colProdCodigo";
            colProdCodigo.ReadOnly = true;
            // 
            // colProdNombre
            // 
            colProdNombre.FillWeight = 45F;
            colProdNombre.HeaderText = "Nombre";
            colProdNombre.MinimumWidth = 6;
            colProdNombre.Name = "colProdNombre";
            colProdNombre.ReadOnly = true;
            // 
            // colProdPrecio
            // 
            colProdPrecio.FillWeight = 18F;
            colProdPrecio.HeaderText = "Precio";
            colProdPrecio.MinimumWidth = 6;
            colProdPrecio.Name = "colProdPrecio";
            colProdPrecio.ReadOnly = true;
            // 
            // colProdActivo
            // 
            colProdActivo.FillWeight = 12F;
            colProdActivo.HeaderText = "Activo";
            colProdActivo.MinimumWidth = 6;
            colProdActivo.Name = "colProdActivo";
            colProdActivo.ReadOnly = true;
            // 
            // grpProductoDatos
            // 
            grpProductoDatos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpProductoDatos.Controls.Add(lblProdCodigo);
            grpProductoDatos.Controls.Add(txtProdCodigo);
            grpProductoDatos.Controls.Add(lblProdNombre);
            grpProductoDatos.Controls.Add(txtProdNombre);
            grpProductoDatos.Controls.Add(lblProdPrecio);
            grpProductoDatos.Controls.Add(nudProdPrecio);
            grpProductoDatos.Controls.Add(chkProdActivo);
            grpProductoDatos.Controls.Add(lblProdIdHidden);
            grpProductoDatos.Controls.Add(btnNuevoProducto);
            grpProductoDatos.Controls.Add(btnGuardarProducto);
            grpProductoDatos.Controls.Add(btnEliminarProducto);
            grpProductoDatos.Controls.Add(btnCancelarProducto);
            grpProductoDatos.Location = new Point(13, 418);
            grpProductoDatos.Name = "grpProductoDatos";
            grpProductoDatos.Size = new Size(1066, 198);
            grpProductoDatos.TabIndex = 5;
            grpProductoDatos.TabStop = false;
            grpProductoDatos.Text = "Datos del Producto  (Alta / Modificación)";
            // 
            // lblProdCodigo
            // 
            lblProdCodigo.AutoSize = true;
            lblProdCodigo.Location = new Point(12, 32);
            lblProdCodigo.Name = "lblProdCodigo";
            lblProdCodigo.Size = new Size(61, 20);
            lblProdCodigo.TabIndex = 0;
            lblProdCodigo.Text = "Código*";
            // 
            // txtProdCodigo
            // 
            txtProdCodigo.Location = new Point(12, 55);
            txtProdCodigo.MaxLength = 50;
            txtProdCodigo.Name = "txtProdCodigo";
            txtProdCodigo.PlaceholderText = "Ej: P001";
            txtProdCodigo.Size = new Size(160, 27);
            txtProdCodigo.TabIndex = 1;
            // 
            // lblProdNombre
            // 
            lblProdNombre.AutoSize = true;
            lblProdNombre.Location = new Point(190, 32);
            lblProdNombre.Name = "lblProdNombre";
            lblProdNombre.Size = new Size(71, 20);
            lblProdNombre.TabIndex = 2;
            lblProdNombre.Text = "Nombre*";
            // 
            // txtProdNombre
            // 
            txtProdNombre.Location = new Point(190, 55);
            txtProdNombre.MaxLength = 150;
            txtProdNombre.Name = "txtProdNombre";
            txtProdNombre.PlaceholderText = "Nombre del producto";
            txtProdNombre.Size = new Size(420, 27);
            txtProdNombre.TabIndex = 3;
            // 
            // lblProdPrecio
            // 
            lblProdPrecio.AutoSize = true;
            lblProdPrecio.Location = new Point(630, 32);
            lblProdPrecio.Name = "lblProdPrecio";
            lblProdPrecio.Size = new Size(58, 20);
            lblProdPrecio.TabIndex = 4;
            lblProdPrecio.Text = "Precio*";
            // 
            // nudProdPrecio
            // 
            nudProdPrecio.DecimalPlaces = 2;
            nudProdPrecio.Location = new Point(630, 55);
            nudProdPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudProdPrecio.Name = "nudProdPrecio";
            nudProdPrecio.Size = new Size(140, 27);
            nudProdPrecio.TabIndex = 5;
            nudProdPrecio.TextAlign = HorizontalAlignment.Right;
            nudProdPrecio.ThousandsSeparator = true;
            // 
            // chkProdActivo
            // 
            chkProdActivo.AutoSize = true;
            chkProdActivo.Checked = true;
            chkProdActivo.CheckState = CheckState.Checked;
            chkProdActivo.Location = new Point(790, 57);
            chkProdActivo.Name = "chkProdActivo";
            chkProdActivo.Size = new Size(73, 24);
            chkProdActivo.TabIndex = 6;
            chkProdActivo.Text = "Activo";
            chkProdActivo.UseVisualStyleBackColor = true;
            // 
            // lblProdIdHidden
            // 
            lblProdIdHidden.AutoSize = true;
            lblProdIdHidden.Location = new Point(890, 57);
            lblProdIdHidden.Name = "lblProdIdHidden";
            lblProdIdHidden.Size = new Size(42, 20);
            lblProdIdHidden.TabIndex = 7;
            lblProdIdHidden.Text = "Id: —";
            lblProdIdHidden.Visible = false;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(12, 110);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(110, 32);
            btnNuevoProducto.TabIndex = 8;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Location = new Point(132, 110);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(110, 32);
            btnGuardarProducto.TabIndex = 9;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(252, 110);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(160, 32);
            btnEliminarProducto.TabIndex = 10;
            btnEliminarProducto.Text = "Eliminar / Desactivar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Location = new Point(422, 110);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(110, 32);
            btnCancelarProducto.TabIndex = 11;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            // 
            // tabNuevaFactura
            // 
            tabNuevaFactura.Controls.Add(grpFacturaCabecera);
            tabNuevaFactura.Controls.Add(grpFacturaAgregarLinea);
            tabNuevaFactura.Controls.Add(dgvDetalleFactura);
            tabNuevaFactura.Controls.Add(lblFacturaTotal);
            tabNuevaFactura.Controls.Add(lblFacturaTotalValor);
            tabNuevaFactura.Controls.Add(btnGrabarFactura);
            tabNuevaFactura.Controls.Add(btnCancelarFactura);
            tabNuevaFactura.Controls.Add(lblFacturaNuevaAviso);
            tabNuevaFactura.Location = new Point(4, 29);
            tabNuevaFactura.Name = "tabNuevaFactura";
            tabNuevaFactura.Padding = new Padding(10);
            tabNuevaFactura.Size = new Size(1092, 629);
            tabNuevaFactura.TabIndex = 1;
            tabNuevaFactura.Text = "Nueva Factura";
            tabNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // grpFacturaCabecera
            // 
            grpFacturaCabecera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFacturaCabecera.Controls.Add(lblFacturaFecha);
            grpFacturaCabecera.Controls.Add(dtpFacturaFecha);
            grpFacturaCabecera.Controls.Add(lblFacturaClienteNombre);
            grpFacturaCabecera.Controls.Add(txtFacturaClienteNombre);
            grpFacturaCabecera.Controls.Add(lblFacturaClienteDoc);
            grpFacturaCabecera.Controls.Add(txtFacturaClienteDoc);
            grpFacturaCabecera.Location = new Point(13, 10);
            grpFacturaCabecera.Name = "grpFacturaCabecera";
            grpFacturaCabecera.Size = new Size(1066, 85);
            grpFacturaCabecera.TabIndex = 0;
            grpFacturaCabecera.TabStop = false;
            grpFacturaCabecera.Text = "Cabecera — Datos del cliente";
            // 
            // lblFacturaFecha
            // 
            lblFacturaFecha.AutoSize = true;
            lblFacturaFecha.Location = new Point(12, 28);
            lblFacturaFecha.Name = "lblFacturaFecha";
            lblFacturaFecha.Size = new Size(47, 20);
            lblFacturaFecha.TabIndex = 0;
            lblFacturaFecha.Text = "Fecha";
            // 
            // dtpFacturaFecha
            // 
            dtpFacturaFecha.Format = DateTimePickerFormat.Short;
            dtpFacturaFecha.Location = new Point(12, 51);
            dtpFacturaFecha.Name = "dtpFacturaFecha";
            dtpFacturaFecha.Size = new Size(150, 27);
            dtpFacturaFecha.TabIndex = 1;
            // 
            // lblFacturaClienteNombre
            // 
            lblFacturaClienteNombre.AutoSize = true;
            lblFacturaClienteNombre.Location = new Point(185, 28);
            lblFacturaClienteNombre.Name = "lblFacturaClienteNombre";
            lblFacturaClienteNombre.Size = new Size(122, 20);
            lblFacturaClienteNombre.TabIndex = 2;
            lblFacturaClienteNombre.Text = "Cliente Nombre*";
            // 
            // txtFacturaClienteNombre
            // 
            txtFacturaClienteNombre.Location = new Point(185, 51);
            txtFacturaClienteNombre.MaxLength = 150;
            txtFacturaClienteNombre.Name = "txtFacturaClienteNombre";
            txtFacturaClienteNombre.PlaceholderText = "Nombre y apellido / razón social";
            txtFacturaClienteNombre.Size = new Size(420, 27);
            txtFacturaClienteNombre.TabIndex = 3;
            // 
            // lblFacturaClienteDoc
            // 
            lblFacturaClienteDoc.AutoSize = true;
            lblFacturaClienteDoc.Location = new Point(625, 28);
            lblFacturaClienteDoc.Name = "lblFacturaClienteDoc";
            lblFacturaClienteDoc.Size = new Size(141, 20);
            lblFacturaClienteDoc.TabIndex = 4;
            lblFacturaClienteDoc.Text = "Cliente Documento";
            // 
            // txtFacturaClienteDoc
            // 
            txtFacturaClienteDoc.Location = new Point(625, 51);
            txtFacturaClienteDoc.MaxLength = 30;
            txtFacturaClienteDoc.Name = "txtFacturaClienteDoc";
            txtFacturaClienteDoc.PlaceholderText = "DNI / CUIT";
            txtFacturaClienteDoc.Size = new Size(220, 27);
            txtFacturaClienteDoc.TabIndex = 5;
            // 
            // grpFacturaAgregarLinea
            // 
            grpFacturaAgregarLinea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFacturaAgregarLinea.Controls.Add(lblLineaProducto);
            grpFacturaAgregarLinea.Controls.Add(cmbLineaProducto);
            grpFacturaAgregarLinea.Controls.Add(lblLineaCantidad);
            grpFacturaAgregarLinea.Controls.Add(nudLineaCantidad);
            grpFacturaAgregarLinea.Controls.Add(lblLineaPrecioUnitario);
            grpFacturaAgregarLinea.Controls.Add(lblLineaPrecioValor);
            grpFacturaAgregarLinea.Controls.Add(lblLineaSubtotal);
            grpFacturaAgregarLinea.Controls.Add(lblLineaSubtotalValor);
            grpFacturaAgregarLinea.Controls.Add(btnAgregarLinea);
            grpFacturaAgregarLinea.Location = new Point(13, 105);
            grpFacturaAgregarLinea.Name = "grpFacturaAgregarLinea";
            grpFacturaAgregarLinea.Size = new Size(1066, 85);
            grpFacturaAgregarLinea.TabIndex = 1;
            grpFacturaAgregarLinea.TabStop = false;
            grpFacturaAgregarLinea.Text = "Agregar línea — solo productos activos";
            // 
            // lblLineaProducto
            // 
            lblLineaProducto.AutoSize = true;
            lblLineaProducto.Location = new Point(12, 28);
            lblLineaProducto.Name = "lblLineaProducto";
            lblLineaProducto.Size = new Size(69, 20);
            lblLineaProducto.TabIndex = 0;
            lblLineaProducto.Text = "Producto";
            // 
            // cmbLineaProducto
            // 
            cmbLineaProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLineaProducto.FormattingEnabled = true;
            cmbLineaProducto.Location = new Point(12, 51);
            cmbLineaProducto.Name = "cmbLineaProducto";
            cmbLineaProducto.Size = new Size(380, 28);
            cmbLineaProducto.TabIndex = 1;
            // 
            // lblLineaCantidad
            // 
            lblLineaCantidad.AutoSize = true;
            lblLineaCantidad.Location = new Point(410, 28);
            lblLineaCantidad.Name = "lblLineaCantidad";
            lblLineaCantidad.Size = new Size(69, 20);
            lblLineaCantidad.TabIndex = 2;
            lblLineaCantidad.Text = "Cantidad";
            // 
            // nudLineaCantidad
            // 
            nudLineaCantidad.Location = new Point(410, 51);
            nudLineaCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLineaCantidad.Name = "nudLineaCantidad";
            nudLineaCantidad.Size = new Size(90, 27);
            nudLineaCantidad.TabIndex = 3;
            nudLineaCantidad.TextAlign = HorizontalAlignment.Right;
            nudLineaCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblLineaPrecioUnitario
            // 
            lblLineaPrecioUnitario.AutoSize = true;
            lblLineaPrecioUnitario.Location = new Point(520, 28);
            lblLineaPrecioUnitario.Name = "lblLineaPrecioUnitario";
            lblLineaPrecioUnitario.Size = new Size(112, 20);
            lblLineaPrecioUnitario.TabIndex = 4;
            lblLineaPrecioUnitario.Text = "Precio unitario:";
            // 
            // lblLineaPrecioValor
            // 
            lblLineaPrecioValor.AutoSize = true;
            lblLineaPrecioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLineaPrecioValor.Location = new Point(520, 55);
            lblLineaPrecioValor.Name = "lblLineaPrecioValor";
            lblLineaPrecioValor.Size = new Size(58, 20);
            lblLineaPrecioValor.TabIndex = 5;
            lblLineaPrecioValor.Text = "$ 0,00";
            // 
            // lblLineaSubtotal
            // 
            lblLineaSubtotal.AutoSize = true;
            lblLineaSubtotal.Location = new Point(650, 28);
            lblLineaSubtotal.Name = "lblLineaSubtotal";
            lblLineaSubtotal.Size = new Size(72, 20);
            lblLineaSubtotal.TabIndex = 6;
            lblLineaSubtotal.Text = "Subtotal:";
            // 
            // lblLineaSubtotalValor
            // 
            lblLineaSubtotalValor.AutoSize = true;
            lblLineaSubtotalValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLineaSubtotalValor.Location = new Point(650, 55);
            lblLineaSubtotalValor.Name = "lblLineaSubtotalValor";
            lblLineaSubtotalValor.Size = new Size(58, 20);
            lblLineaSubtotalValor.TabIndex = 7;
            lblLineaSubtotalValor.Text = "$ 0,00";
            // 
            // btnAgregarLinea
            // 
            btnAgregarLinea.Location = new Point(780, 50);
            btnAgregarLinea.Name = "btnAgregarLinea";
            btnAgregarLinea.Size = new Size(130, 29);
            btnAgregarLinea.TabIndex = 8;
            btnAgregarLinea.Text = "Agregar línea";
            btnAgregarLinea.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvDetalleFactura.AllowUserToDeleteRows = false;
            dgvDetalleFactura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFactura.Columns.AddRange(new DataGridViewColumn[] { colDetProdId, colDetProducto, colDetCantidad, colDetPrecioUnitario, colDetSubtotal, colDetQuitar });
            dgvDetalleFactura.Location = new Point(13, 200);
            dgvDetalleFactura.MultiSelect = false;
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.ReadOnly = true;
            dgvDetalleFactura.RowHeadersWidth = 51;
            dgvDetalleFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleFactura.Size = new Size(1066, 330);
            dgvDetalleFactura.TabIndex = 2;
            // 
            // colDetProdId
            // 
            colDetProdId.HeaderText = "ProductoId";
            colDetProdId.MinimumWidth = 6;
            colDetProdId.Name = "colDetProdId";
            colDetProdId.ReadOnly = true;
            colDetProdId.Visible = false;
            // 
            // colDetProducto
            // 
            colDetProducto.FillWeight = 45F;
            colDetProducto.HeaderText = "Producto";
            colDetProducto.MinimumWidth = 6;
            colDetProducto.Name = "colDetProducto";
            colDetProducto.ReadOnly = true;
            // 
            // colDetCantidad
            // 
            colDetCantidad.FillWeight = 15F;
            colDetCantidad.HeaderText = "Cantidad";
            colDetCantidad.MinimumWidth = 6;
            colDetCantidad.Name = "colDetCantidad";
            colDetCantidad.ReadOnly = true;
            // 
            // colDetPrecioUnitario
            // 
            colDetPrecioUnitario.FillWeight = 18F;
            colDetPrecioUnitario.HeaderText = "Precio Unit.";
            colDetPrecioUnitario.MinimumWidth = 6;
            colDetPrecioUnitario.Name = "colDetPrecioUnitario";
            colDetPrecioUnitario.ReadOnly = true;
            // 
            // colDetSubtotal
            // 
            colDetSubtotal.FillWeight = 18F;
            colDetSubtotal.HeaderText = "Subtotal";
            colDetSubtotal.MinimumWidth = 6;
            colDetSubtotal.Name = "colDetSubtotal";
            colDetSubtotal.ReadOnly = true;
            // 
            // colDetQuitar
            // 
            colDetQuitar.FillWeight = 12F;
            colDetQuitar.HeaderText = "";
            colDetQuitar.MinimumWidth = 6;
            colDetQuitar.Name = "colDetQuitar";
            colDetQuitar.ReadOnly = true;
            colDetQuitar.Text = "Quitar";
            colDetQuitar.UseColumnTextForButtonValue = true;
            // 
            // lblFacturaTotal
            // 
            lblFacturaTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFacturaTotal.AutoSize = true;
            lblFacturaTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFacturaTotal.Location = new Point(820, 540);
            lblFacturaTotal.Name = "lblFacturaTotal";
            lblFacturaTotal.Size = new Size(55, 23);
            lblFacturaTotal.TabIndex = 3;
            lblFacturaTotal.Text = "Total:";
            // 
            // lblFacturaTotalValor
            // 
            lblFacturaTotalValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblFacturaTotalValor.AutoSize = true;
            lblFacturaTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFacturaTotalValor.Location = new Point(880, 538);
            lblFacturaTotalValor.Name = "lblFacturaTotalValor";
            lblFacturaTotalValor.Size = new Size(73, 28);
            lblFacturaTotalValor.TabIndex = 4;
            lblFacturaTotalValor.Text = "$ 0,00";
            // 
            // btnGrabarFactura
            // 
            btnGrabarFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGrabarFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGrabarFactura.Location = new Point(13, 580);
            btnGrabarFactura.Name = "btnGrabarFactura";
            btnGrabarFactura.Size = new Size(160, 36);
            btnGrabarFactura.TabIndex = 5;
            btnGrabarFactura.Text = "Grabar factura";
            btnGrabarFactura.UseVisualStyleBackColor = true;
            // 
            // btnCancelarFactura
            // 
            btnCancelarFactura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarFactura.Location = new Point(183, 580);
            btnCancelarFactura.Name = "btnCancelarFactura";
            btnCancelarFactura.Size = new Size(130, 36);
            btnCancelarFactura.TabIndex = 6;
            btnCancelarFactura.Text = "Limpiar / Cancelar";
            btnCancelarFactura.UseVisualStyleBackColor = true;
            // 
            // lblFacturaNuevaAviso
            // 
            lblFacturaNuevaAviso.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFacturaNuevaAviso.AutoSize = true;
            lblFacturaNuevaAviso.ForeColor = Color.DimGray;
            lblFacturaNuevaAviso.Location = new Point(330, 589);
            lblFacturaNuevaAviso.Name = "lblFacturaNuevaAviso";
            lblFacturaNuevaAviso.Size = new Size(520, 20);
            lblFacturaNuevaAviso.TabIndex = 7;
            lblFacturaNuevaAviso.Text = "No se permite duplicar producto. La factura requiere ≥1 línea y cliente.";
            // 
            // tabConsultaFacturas
            // 
            tabConsultaFacturas.Controls.Add(grpConsultaFiltros);
            tabConsultaFacturas.Controls.Add(dgvFacturas);
            tabConsultaFacturas.Controls.Add(splitConsultaDetalle);
            tabConsultaFacturas.Location = new Point(4, 29);
            tabConsultaFacturas.Name = "tabConsultaFacturas";
            tabConsultaFacturas.Padding = new Padding(10);
            tabConsultaFacturas.Size = new Size(1092, 629);
            tabConsultaFacturas.TabIndex = 2;
            tabConsultaFacturas.Text = "Consultar Facturas";
            tabConsultaFacturas.UseVisualStyleBackColor = true;
            // 
            // grpConsultaFiltros
            // 
            grpConsultaFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConsultaFiltros.Controls.Add(chkFiltroDesde);
            grpConsultaFiltros.Controls.Add(dtpFiltroDesde);
            grpConsultaFiltros.Controls.Add(chkFiltroHasta);
            grpConsultaFiltros.Controls.Add(dtpFiltroHasta);
            grpConsultaFiltros.Controls.Add(lblFiltroCliente);
            grpConsultaFiltros.Controls.Add(txtFiltroCliente);
            grpConsultaFiltros.Controls.Add(btnBuscarFacturas);
            grpConsultaFiltros.Controls.Add(btnLimpiarFiltrosFacturas);
            grpConsultaFiltros.Location = new Point(13, 10);
            grpConsultaFiltros.Name = "grpConsultaFiltros";
            grpConsultaFiltros.Size = new Size(1066, 75);
            grpConsultaFiltros.TabIndex = 0;
            grpConsultaFiltros.TabStop = false;
            grpConsultaFiltros.Text = "Filtros";
            // 
            // chkFiltroDesde
            // 
            chkFiltroDesde.AutoSize = true;
            chkFiltroDesde.Location = new Point(12, 34);
            chkFiltroDesde.Name = "chkFiltroDesde";
            chkFiltroDesde.Size = new Size(76, 24);
            chkFiltroDesde.TabIndex = 0;
            chkFiltroDesde.Text = "Desde";
            chkFiltroDesde.UseVisualStyleBackColor = true;
            // 
            // dtpFiltroDesde
            // 
            dtpFiltroDesde.Enabled = false;
            dtpFiltroDesde.Format = DateTimePickerFormat.Short;
            dtpFiltroDesde.Location = new Point(90, 32);
            dtpFiltroDesde.Name = "dtpFiltroDesde";
            dtpFiltroDesde.Size = new Size(140, 27);
            dtpFiltroDesde.TabIndex = 1;
            // 
            // chkFiltroHasta
            // 
            chkFiltroHasta.AutoSize = true;
            chkFiltroHasta.Location = new Point(245, 34);
            chkFiltroHasta.Name = "chkFiltroHasta";
            chkFiltroHasta.Size = new Size(72, 24);
            chkFiltroHasta.TabIndex = 2;
            chkFiltroHasta.Text = "Hasta";
            chkFiltroHasta.UseVisualStyleBackColor = true;
            // 
            // dtpFiltroHasta
            // 
            dtpFiltroHasta.Enabled = false;
            dtpFiltroHasta.Format = DateTimePickerFormat.Short;
            dtpFiltroHasta.Location = new Point(320, 32);
            dtpFiltroHasta.Name = "dtpFiltroHasta";
            dtpFiltroHasta.Size = new Size(140, 27);
            dtpFiltroHasta.TabIndex = 3;
            // 
            // lblFiltroCliente
            // 
            lblFiltroCliente.AutoSize = true;
            lblFiltroCliente.Location = new Point(480, 35);
            lblFiltroCliente.Name = "lblFiltroCliente";
            lblFiltroCliente.Size = new Size(59, 20);
            lblFiltroCliente.TabIndex = 4;
            lblFiltroCliente.Text = "Cliente";
            // 
            // txtFiltroCliente
            // 
            txtFiltroCliente.Location = new Point(545, 32);
            txtFiltroCliente.Name = "txtFiltroCliente";
            txtFiltroCliente.PlaceholderText = "Nombre o documento...";
            txtFiltroCliente.Size = new Size(240, 27);
            txtFiltroCliente.TabIndex = 5;
            // 
            // btnBuscarFacturas
            // 
            btnBuscarFacturas.Location = new Point(800, 31);
            btnBuscarFacturas.Name = "btnBuscarFacturas";
            btnBuscarFacturas.Size = new Size(90, 29);
            btnBuscarFacturas.TabIndex = 6;
            btnBuscarFacturas.Text = "Buscar";
            btnBuscarFacturas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltrosFacturas
            // 
            btnLimpiarFiltrosFacturas.Location = new Point(896, 31);
            btnLimpiarFiltrosFacturas.Name = "btnLimpiarFiltrosFacturas";
            btnLimpiarFiltrosFacturas.Size = new Size(90, 29);
            btnLimpiarFiltrosFacturas.TabIndex = 7;
            btnLimpiarFiltrosFacturas.Text = "Limpiar";
            btnLimpiarFiltrosFacturas.UseVisualStyleBackColor = true;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Columns.AddRange(new DataGridViewColumn[] { colFacId, colFacNumero, colFacFecha, colFacCliente, colFacDocumento, colFacEstado, colFacTotal });
            dgvFacturas.Location = new Point(13, 95);
            dgvFacturas.MultiSelect = false;
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.RowHeadersWidth = 51;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(1066, 230);
            dgvFacturas.TabIndex = 1;
            // 
            // colFacId
            // 
            colFacId.HeaderText = "Id";
            colFacId.MinimumWidth = 6;
            colFacId.Name = "colFacId";
            colFacId.ReadOnly = true;
            colFacId.Visible = false;
            // 
            // colFacNumero
            // 
            colFacNumero.FillWeight = 12F;
            colFacNumero.HeaderText = "Número";
            colFacNumero.MinimumWidth = 6;
            colFacNumero.Name = "colFacNumero";
            colFacNumero.ReadOnly = true;
            // 
            // colFacFecha
            // 
            colFacFecha.FillWeight = 15F;
            colFacFecha.HeaderText = "Fecha";
            colFacFecha.MinimumWidth = 6;
            colFacFecha.Name = "colFacFecha";
            colFacFecha.ReadOnly = true;
            // 
            // colFacCliente
            // 
            colFacCliente.FillWeight = 25F;
            colFacCliente.HeaderText = "Cliente";
            colFacCliente.MinimumWidth = 6;
            colFacCliente.Name = "colFacCliente";
            colFacCliente.ReadOnly = true;
            // 
            // colFacDocumento
            // 
            colFacDocumento.FillWeight = 18F;
            colFacDocumento.HeaderText = "Documento";
            colFacDocumento.MinimumWidth = 6;
            colFacDocumento.Name = "colFacDocumento";
            colFacDocumento.ReadOnly = true;
            // 
            // colFacEstado
            // 
            colFacEstado.FillWeight = 12F;
            colFacEstado.HeaderText = "Estado";
            colFacEstado.MinimumWidth = 6;
            colFacEstado.Name = "colFacEstado";
            colFacEstado.ReadOnly = true;
            // 
            // colFacTotal
            // 
            colFacTotal.FillWeight = 18F;
            colFacTotal.HeaderText = "Total";
            colFacTotal.MinimumWidth = 6;
            colFacTotal.Name = "colFacTotal";
            colFacTotal.ReadOnly = true;
            // 
            // splitConsultaDetalle
            // 
            splitConsultaDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitConsultaDetalle.Location = new Point(13, 335);
            splitConsultaDetalle.Name = "splitConsultaDetalle";
            splitConsultaDetalle.Orientation = Orientation.Horizontal;
            // 
            // splitConsultaDetalle.Panel1
            // 
            splitConsultaDetalle.Panel1.Controls.Add(grpConsultaCabecera);
            // 
            // splitConsultaDetalle.Panel2
            // 
            splitConsultaDetalle.Panel2.Controls.Add(dgvConsultaDetalle);
            splitConsultaDetalle.Size = new Size(1066, 284);
            splitConsultaDetalle.SplitterDistance = 110;
            splitConsultaDetalle.TabIndex = 2;
            // 
            // grpConsultaCabecera
            // 
            grpConsultaCabecera.Controls.Add(lblConsultaDetNumero);
            grpConsultaCabecera.Controls.Add(lblConsultaDetNumeroValor);
            grpConsultaCabecera.Controls.Add(lblConsultaDetFecha);
            grpConsultaCabecera.Controls.Add(lblConsultaDetFechaValor);
            grpConsultaCabecera.Controls.Add(lblConsultaDetCliente);
            grpConsultaCabecera.Controls.Add(lblConsultaDetClienteValor);
            grpConsultaCabecera.Controls.Add(lblConsultaDetDocumento);
            grpConsultaCabecera.Controls.Add(lblConsultaDetDocumentoValor);
            grpConsultaCabecera.Controls.Add(lblConsultaDetTotal);
            grpConsultaCabecera.Controls.Add(lblConsultaDetTotalValor);
            grpConsultaCabecera.Controls.Add(lblConsultaDetEstado);
            grpConsultaCabecera.Controls.Add(lblConsultaDetEstadoValor);
            grpConsultaCabecera.Controls.Add(lblConsultaSoloLectura);
            grpConsultaCabecera.Controls.Add(btnAnularFactura);
            grpConsultaCabecera.Dock = DockStyle.Fill;
            grpConsultaCabecera.Location = new Point(0, 0);
            grpConsultaCabecera.Name = "grpConsultaCabecera";
            grpConsultaCabecera.Size = new Size(1066, 110);
            grpConsultaCabecera.TabIndex = 0;
            grpConsultaCabecera.TabStop = false;
            grpConsultaCabecera.Text = "Detalle de la factura seleccionada — solo lectura";
            // 
            // lblConsultaDetNumero
            // 
            lblConsultaDetNumero.AutoSize = true;
            lblConsultaDetNumero.Location = new Point(12, 30);
            lblConsultaDetNumero.Name = "lblConsultaDetNumero";
            lblConsultaDetNumero.Size = new Size(66, 20);
            lblConsultaDetNumero.TabIndex = 0;
            lblConsultaDetNumero.Text = "Número:";
            // 
            // lblConsultaDetNumeroValor
            // 
            lblConsultaDetNumeroValor.AutoSize = true;
            lblConsultaDetNumeroValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsultaDetNumeroValor.Location = new Point(84, 30);
            lblConsultaDetNumeroValor.Name = "lblConsultaDetNumeroValor";
            lblConsultaDetNumeroValor.Size = new Size(17, 20);
            lblConsultaDetNumeroValor.TabIndex = 1;
            lblConsultaDetNumeroValor.Text = "—";
            // 
            // lblConsultaDetFecha
            // 
            lblConsultaDetFecha.AutoSize = true;
            lblConsultaDetFecha.Location = new Point(180, 30);
            lblConsultaDetFecha.Name = "lblConsultaDetFecha";
            lblConsultaDetFecha.Size = new Size(50, 20);
            lblConsultaDetFecha.TabIndex = 2;
            lblConsultaDetFecha.Text = "Fecha:";
            // 
            // lblConsultaDetFechaValor
            // 
            lblConsultaDetFechaValor.AutoSize = true;
            lblConsultaDetFechaValor.Location = new Point(236, 30);
            lblConsultaDetFechaValor.Name = "lblConsultaDetFechaValor";
            lblConsultaDetFechaValor.Size = new Size(16, 20);
            lblConsultaDetFechaValor.TabIndex = 3;
            lblConsultaDetFechaValor.Text = "—";
            // 
            // lblConsultaDetCliente
            // 
            lblConsultaDetCliente.AutoSize = true;
            lblConsultaDetCliente.Location = new Point(12, 60);
            lblConsultaDetCliente.Name = "lblConsultaDetCliente";
            lblConsultaDetCliente.Size = new Size(61, 20);
            lblConsultaDetCliente.TabIndex = 4;
            lblConsultaDetCliente.Text = "Cliente:";
            // 
            // lblConsultaDetClienteValor
            // 
            lblConsultaDetClienteValor.AutoSize = true;
            lblConsultaDetClienteValor.Location = new Point(84, 60);
            lblConsultaDetClienteValor.Name = "lblConsultaDetClienteValor";
            lblConsultaDetClienteValor.Size = new Size(16, 20);
            lblConsultaDetClienteValor.TabIndex = 5;
            lblConsultaDetClienteValor.Text = "—";
            // 
            // lblConsultaDetDocumento
            // 
            lblConsultaDetDocumento.AutoSize = true;
            lblConsultaDetDocumento.Location = new Point(360, 60);
            lblConsultaDetDocumento.Name = "lblConsultaDetDocumento";
            lblConsultaDetDocumento.Size = new Size(92, 20);
            lblConsultaDetDocumento.TabIndex = 6;
            lblConsultaDetDocumento.Text = "Documento:";
            // 
            // lblConsultaDetDocumentoValor
            // 
            lblConsultaDetDocumentoValor.AutoSize = true;
            lblConsultaDetDocumentoValor.Location = new Point(458, 60);
            lblConsultaDetDocumentoValor.Name = "lblConsultaDetDocumentoValor";
            lblConsultaDetDocumentoValor.Size = new Size(16, 20);
            lblConsultaDetDocumentoValor.TabIndex = 7;
            lblConsultaDetDocumentoValor.Text = "—";
            // 
            // lblConsultaDetTotal
            // 
            lblConsultaDetTotal.AutoSize = true;
            lblConsultaDetTotal.Location = new Point(600, 30);
            lblConsultaDetTotal.Name = "lblConsultaDetTotal";
            lblConsultaDetTotal.Size = new Size(46, 20);
            lblConsultaDetTotal.TabIndex = 8;
            lblConsultaDetTotal.Text = "Total:";
            // 
            // lblConsultaDetTotalValor
            // 
            lblConsultaDetTotalValor.AutoSize = true;
            lblConsultaDetTotalValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConsultaDetTotalValor.Location = new Point(652, 28);
            lblConsultaDetTotalValor.Name = "lblConsultaDetTotalValor";
            lblConsultaDetTotalValor.Size = new Size(63, 23);
            lblConsultaDetTotalValor.TabIndex = 9;
            lblConsultaDetTotalValor.Text = "$ 0,00";
            // 
            // lblConsultaDetEstado
            // 
            lblConsultaDetEstado.AutoSize = true;
            lblConsultaDetEstado.Location = new Point(360, 30);
            lblConsultaDetEstado.Name = "lblConsultaDetEstado";
            lblConsultaDetEstado.Size = new Size(58, 20);
            lblConsultaDetEstado.TabIndex = 11;
            lblConsultaDetEstado.Text = "Estado:";
            // 
            // lblConsultaDetEstadoValor
            // 
            lblConsultaDetEstadoValor.AutoSize = true;
            lblConsultaDetEstadoValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsultaDetEstadoValor.Location = new Point(420, 30);
            lblConsultaDetEstadoValor.Name = "lblConsultaDetEstadoValor";
            lblConsultaDetEstadoValor.Size = new Size(16, 20);
            lblConsultaDetEstadoValor.TabIndex = 12;
            lblConsultaDetEstadoValor.Text = "—";
            // 
            // lblConsultaSoloLectura
            // 
            lblConsultaSoloLectura.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblConsultaSoloLectura.AutoSize = true;
            lblConsultaSoloLectura.ForeColor = Color.DimGray;
            lblConsultaSoloLectura.Location = new Point(840, 82);
            lblConsultaSoloLectura.Name = "lblConsultaSoloLectura";
            lblConsultaSoloLectura.Size = new Size(214, 20);
            lblConsultaSoloLectura.TabIndex = 10;
            lblConsultaSoloLectura.Text = "Las facturas no se editan (solo lectura).";
            // 
            // btnAnularFactura
            // 
            btnAnularFactura.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnularFactura.Location = new Point(860, 24);
            btnAnularFactura.Name = "btnAnularFactura";
            btnAnularFactura.Size = new Size(180, 32);
            btnAnularFactura.TabIndex = 13;
            btnAnularFactura.Text = "Anular factura";
            btnAnularFactura.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaDetalle
            // 
            dgvConsultaDetalle.AllowUserToAddRows = false;
            dgvConsultaDetalle.AllowUserToDeleteRows = false;
            dgvConsultaDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultaDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaDetalle.Columns.AddRange(new DataGridViewColumn[] { colConsDetProducto, colConsDetCantidad, colConsDetPrecio, colConsDetSubtotal });
            dgvConsultaDetalle.Dock = DockStyle.Fill;
            dgvConsultaDetalle.Location = new Point(0, 0);
            dgvConsultaDetalle.Name = "dgvConsultaDetalle";
            dgvConsultaDetalle.ReadOnly = true;
            dgvConsultaDetalle.RowHeadersWidth = 51;
            dgvConsultaDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultaDetalle.Size = new Size(1066, 170);
            dgvConsultaDetalle.TabIndex = 0;
            // 
            // colConsDetProducto
            // 
            colConsDetProducto.FillWeight = 45F;
            colConsDetProducto.HeaderText = "Producto";
            colConsDetProducto.MinimumWidth = 6;
            colConsDetProducto.Name = "colConsDetProducto";
            colConsDetProducto.ReadOnly = true;
            // 
            // colConsDetCantidad
            // 
            colConsDetCantidad.FillWeight = 15F;
            colConsDetCantidad.HeaderText = "Cantidad";
            colConsDetCantidad.MinimumWidth = 6;
            colConsDetCantidad.Name = "colConsDetCantidad";
            colConsDetCantidad.ReadOnly = true;
            // 
            // colConsDetPrecio
            // 
            colConsDetPrecio.FillWeight = 20F;
            colConsDetPrecio.HeaderText = "Precio Unit.";
            colConsDetPrecio.MinimumWidth = 6;
            colConsDetPrecio.Name = "colConsDetPrecio";
            colConsDetPrecio.ReadOnly = true;
            // 
            // colConsDetSubtotal
            // 
            colConsDetSubtotal.FillWeight = 20F;
            colConsDetSubtotal.HeaderText = "Subtotal";
            colConsDetSubtotal.MinimumWidth = 6;
            colConsDetSubtotal.Name = "colConsDetSubtotal";
            colConsDetSubtotal.ReadOnly = true;
            // 
            // tabInforme
            // 
            tabInforme.Controls.Add(grpInformePeriodo);
            tabInforme.Controls.Add(dgvInforme);
            tabInforme.Controls.Add(lblInformeResumen);
            tabInforme.Controls.Add(lblInformeVacio);
            tabInforme.Location = new Point(4, 29);
            tabInforme.Name = "tabInforme";
            tabInforme.Padding = new Padding(10);
            tabInforme.Size = new Size(1092, 629);
            tabInforme.TabIndex = 3;
            tabInforme.Text = "Informe por Producto";
            tabInforme.UseVisualStyleBackColor = true;
            // 
            // grpInformePeriodo
            // 
            grpInformePeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpInformePeriodo.Controls.Add(chkInformeDesde);
            grpInformePeriodo.Controls.Add(dtpInformeDesde);
            grpInformePeriodo.Controls.Add(chkInformeHasta);
            grpInformePeriodo.Controls.Add(dtpInformeHasta);
            grpInformePeriodo.Controls.Add(btnGenerarInforme);
            grpInformePeriodo.Location = new Point(13, 10);
            grpInformePeriodo.Name = "grpInformePeriodo";
            grpInformePeriodo.Size = new Size(1066, 70);
            grpInformePeriodo.TabIndex = 0;
            grpInformePeriodo.TabStop = false;
            grpInformePeriodo.Text = "Período";
            // 
            // chkInformeDesde
            // 
            chkInformeDesde.AutoSize = true;
            chkInformeDesde.Location = new Point(12, 30);
            chkInformeDesde.Name = "chkInformeDesde";
            chkInformeDesde.Size = new Size(76, 24);
            chkInformeDesde.TabIndex = 0;
            chkInformeDesde.Text = "Desde";
            chkInformeDesde.UseVisualStyleBackColor = true;
            // 
            // dtpInformeDesde
            // 
            dtpInformeDesde.Enabled = false;
            dtpInformeDesde.Format = DateTimePickerFormat.Short;
            dtpInformeDesde.Location = new Point(90, 28);
            dtpInformeDesde.Name = "dtpInformeDesde";
            dtpInformeDesde.Size = new Size(140, 27);
            dtpInformeDesde.TabIndex = 1;
            // 
            // chkInformeHasta
            // 
            chkInformeHasta.AutoSize = true;
            chkInformeHasta.Location = new Point(250, 30);
            chkInformeHasta.Name = "chkInformeHasta";
            chkInformeHasta.Size = new Size(72, 24);
            chkInformeHasta.TabIndex = 2;
            chkInformeHasta.Text = "Hasta";
            chkInformeHasta.UseVisualStyleBackColor = true;
            // 
            // dtpInformeHasta
            // 
            dtpInformeHasta.Enabled = false;
            dtpInformeHasta.Format = DateTimePickerFormat.Short;
            dtpInformeHasta.Location = new Point(328, 28);
            dtpInformeHasta.Name = "dtpInformeHasta";
            dtpInformeHasta.Size = new Size(140, 27);
            dtpInformeHasta.TabIndex = 3;
            // 
            // btnGenerarInforme
            // 
            btnGenerarInforme.Location = new Point(490, 27);
            btnGenerarInforme.Name = "btnGenerarInforme";
            btnGenerarInforme.Size = new Size(150, 29);
            btnGenerarInforme.TabIndex = 4;
            btnGenerarInforme.Text = "Generar informe";
            btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // dgvInforme
            // 
            dgvInforme.AllowUserToAddRows = false;
            dgvInforme.AllowUserToDeleteRows = false;
            dgvInforme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInforme.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInforme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInforme.Columns.AddRange(new DataGridViewColumn[] { colInfProducto, colInfCantidad, colInfMonto });
            dgvInforme.Location = new Point(13, 90);
            dgvInforme.Name = "dgvInforme";
            dgvInforme.ReadOnly = true;
            dgvInforme.RowHeadersWidth = 51;
            dgvInforme.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInforme.Size = new Size(1066, 480);
            dgvInforme.TabIndex = 1;
            // 
            // colInfProducto
            // 
            colInfProducto.FillWeight = 50F;
            colInfProducto.HeaderText = "Producto";
            colInfProducto.MinimumWidth = 6;
            colInfProducto.Name = "colInfProducto";
            colInfProducto.ReadOnly = true;
            // 
            // colInfCantidad
            // 
            colInfCantidad.FillWeight = 25F;
            colInfCantidad.HeaderText = "Cantidad facturada";
            colInfCantidad.MinimumWidth = 6;
            colInfCantidad.Name = "colInfCantidad";
            colInfCantidad.ReadOnly = true;
            // 
            // colInfMonto
            // 
            colInfMonto.FillWeight = 25F;
            colInfMonto.HeaderText = "Monto total";
            colInfMonto.MinimumWidth = 6;
            colInfMonto.Name = "colInfMonto";
            colInfMonto.ReadOnly = true;
            // 
            // lblInformeResumen
            // 
            lblInformeResumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblInformeResumen.AutoSize = true;
            lblInformeResumen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInformeResumen.Location = new Point(13, 580);
            lblInformeResumen.Name = "lblInformeResumen";
            lblInformeResumen.Size = new Size(16, 20);
            lblInformeResumen.TabIndex = 2;
            lblInformeResumen.Text = "—";
            // 
            // lblInformeVacio
            // 
            lblInformeVacio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblInformeVacio.AutoSize = true;
            lblInformeVacio.ForeColor = Color.DimGray;
            lblInformeVacio.Location = new Point(780, 580);
            lblInformeVacio.Name = "lblInformeVacio";
            lblInformeVacio.Size = new Size(299, 20);
            lblInformeVacio.TabIndex = 3;
            lblInformeVacio.Text = "Sin datos: \"No hay facturas en el período\".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 700);
            Controls.Add(tabControlMain);
            Controls.Add(lblTituloApp);
            MinimumSize = new Size(900, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TP Gestión Facturas - DAS";
            tabControlMain.ResumeLayout(false);
            tabProductos.ResumeLayout(false);
            tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grpProductoDatos.ResumeLayout(false);
            grpProductoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProdPrecio).EndInit();
            tabNuevaFactura.ResumeLayout(false);
            tabNuevaFactura.PerformLayout();
            grpFacturaCabecera.ResumeLayout(false);
            grpFacturaCabecera.PerformLayout();
            grpFacturaAgregarLinea.ResumeLayout(false);
            grpFacturaAgregarLinea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLineaCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            tabConsultaFacturas.ResumeLayout(false);
            grpConsultaFiltros.ResumeLayout(false);
            grpConsultaFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            splitConsultaDetalle.Panel1.ResumeLayout(false);
            splitConsultaDetalle.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitConsultaDetalle).EndInit();
            splitConsultaDetalle.ResumeLayout(false);
            grpConsultaCabecera.ResumeLayout(false);
            grpConsultaCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaDetalle).EndInit();
            tabInforme.ResumeLayout(false);
            tabInforme.PerformLayout();
            grpInformePeriodo.ResumeLayout(false);
            grpInformePeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInforme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloApp;
        private TabControl tabControlMain;
        private TabPage tabProductos;
        private Label lblBuscarProducto;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
        private Button btnLimpiarBusquedaProducto;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colProdId;
        private DataGridViewTextBoxColumn colProdCodigo;
        private DataGridViewTextBoxColumn colProdNombre;
        private DataGridViewTextBoxColumn colProdPrecio;
        private DataGridViewCheckBoxColumn colProdActivo;
        private GroupBox grpProductoDatos;
        private Label lblProdCodigo;
        private TextBox txtProdCodigo;
        private Label lblProdNombre;
        private TextBox txtProdNombre;
        private Label lblProdPrecio;
        private NumericUpDown nudProdPrecio;
        private CheckBox chkProdActivo;
        private Label lblProdIdHidden;
        private Button btnNuevoProducto;
        private Button btnGuardarProducto;
        private Button btnEliminarProducto;
        private Button btnCancelarProducto;
        private TabPage tabNuevaFactura;
        private GroupBox grpFacturaCabecera;
        private Label lblFacturaFecha;
        private DateTimePicker dtpFacturaFecha;
        private Label lblFacturaClienteNombre;
        private TextBox txtFacturaClienteNombre;
        private Label lblFacturaClienteDoc;
        private TextBox txtFacturaClienteDoc;
        private GroupBox grpFacturaAgregarLinea;
        private Label lblLineaProducto;
        private ComboBox cmbLineaProducto;
        private Label lblLineaCantidad;
        private NumericUpDown nudLineaCantidad;
        private Label lblLineaPrecioUnitario;
        private Label lblLineaPrecioValor;
        private Label lblLineaSubtotal;
        private Label lblLineaSubtotalValor;
        private Button btnAgregarLinea;
        private DataGridView dgvDetalleFactura;
        private DataGridViewTextBoxColumn colDetProdId;
        private DataGridViewTextBoxColumn colDetProducto;
        private DataGridViewTextBoxColumn colDetCantidad;
        private DataGridViewTextBoxColumn colDetPrecioUnitario;
        private DataGridViewTextBoxColumn colDetSubtotal;
        private DataGridViewButtonColumn colDetQuitar;
        private Label lblFacturaTotal;
        private Label lblFacturaTotalValor;
        private Button btnGrabarFactura;
        private Button btnCancelarFactura;
        private Label lblFacturaNuevaAviso;
        private TabPage tabConsultaFacturas;
        private GroupBox grpConsultaFiltros;
        private CheckBox chkFiltroDesde;
        private DateTimePicker dtpFiltroDesde;
        private CheckBox chkFiltroHasta;
        private DateTimePicker dtpFiltroHasta;
        private Label lblFiltroCliente;
        private TextBox txtFiltroCliente;
        private Button btnBuscarFacturas;
        private Button btnLimpiarFiltrosFacturas;
        private Button btnAnularFactura;
        private DataGridView dgvFacturas;
        private DataGridViewTextBoxColumn colFacId;
        private DataGridViewTextBoxColumn colFacNumero;
        private DataGridViewTextBoxColumn colFacFecha;
        private DataGridViewTextBoxColumn colFacCliente;
        private DataGridViewTextBoxColumn colFacDocumento;
        private DataGridViewTextBoxColumn colFacEstado;
        private DataGridViewTextBoxColumn colFacTotal;
        private SplitContainer splitConsultaDetalle;
        private GroupBox grpConsultaCabecera;
        private Label lblConsultaDetNumero;
        private Label lblConsultaDetNumeroValor;
        private Label lblConsultaDetFecha;
        private Label lblConsultaDetFechaValor;
        private Label lblConsultaDetCliente;
        private Label lblConsultaDetClienteValor;
        private Label lblConsultaDetDocumento;
        private Label lblConsultaDetDocumentoValor;
        private Label lblConsultaDetTotal;
        private Label lblConsultaDetTotalValor;
        private Label lblConsultaDetEstado;
        private Label lblConsultaDetEstadoValor;
        private Label lblConsultaSoloLectura;
        private DataGridView dgvConsultaDetalle;
        private DataGridViewTextBoxColumn colConsDetProducto;
        private DataGridViewTextBoxColumn colConsDetCantidad;
        private DataGridViewTextBoxColumn colConsDetPrecio;
        private DataGridViewTextBoxColumn colConsDetSubtotal;
        private TabPage tabInforme;
        private GroupBox grpInformePeriodo;
        private CheckBox chkInformeDesde;
        private DateTimePicker dtpInformeDesde;
        private CheckBox chkInformeHasta;
        private DateTimePicker dtpInformeHasta;
        private Button btnGenerarInforme;
        private DataGridView dgvInforme;
        private DataGridViewTextBoxColumn colInfProducto;
        private DataGridViewTextBoxColumn colInfCantidad;
        private DataGridViewTextBoxColumn colInfMonto;
        private Label lblInformeResumen;
        private Label lblInformeVacio;
    }
}
