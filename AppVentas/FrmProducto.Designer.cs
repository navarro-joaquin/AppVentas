namespace AppVentas
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCodigo;
            System.Windows.Forms.Label lblNombreProducto;
            System.Windows.Forms.Label lblMarca;
            System.Windows.Forms.Label lblValorCompra;
            System.Windows.Forms.Label lblValorVenta;
            System.Windows.Forms.Label lblFechaCompra;
            System.Windows.Forms.Label lblFechaVencimiento;
            System.Windows.Forms.Label lblStock;
            System.Windows.Forms.Label lblDescripcion;
            System.Windows.Forms.Label lblProveedor;
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label lblMinimo;
            System.Windows.Forms.Label lblValorMayorista;
            this.vista_productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsisventasDataSet = new AppVentas.dbsisventasDataSet();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtValorMayorista = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtValorVenta = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.productoTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.productoTableAdapter();
            this.tableAdapterManager = new AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager();
            this.categoriaTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.categoriaTableAdapter();
            this.proveedorTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.proveedorTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.vista_productoTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.vista_productoTableAdapter();
            this.btnBajas = new System.Windows.Forms.Button();
            lblCodigo = new System.Windows.Forms.Label();
            lblNombreProducto = new System.Windows.Forms.Label();
            lblMarca = new System.Windows.Forms.Label();
            lblValorCompra = new System.Windows.Forms.Label();
            lblValorVenta = new System.Windows.Forms.Label();
            lblFechaCompra = new System.Windows.Forms.Label();
            lblFechaVencimiento = new System.Windows.Forms.Label();
            lblStock = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            lblProveedor = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            lblMinimo = new System.Windows.Forms.Label();
            lblValorMayorista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vista_productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).BeginInit();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new System.Drawing.Point(30, 28);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(49, 18);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new System.Drawing.Point(29, 64);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new System.Drawing.Size(110, 18);
            lblNombreProducto.TabIndex = 2;
            lblNombreProducto.Text = "Nombre Producto:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new System.Drawing.Point(339, 64);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new System.Drawing.Size(46, 18);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca:";
            // 
            // lblValorCompra
            // 
            lblValorCompra.AutoSize = true;
            lblValorCompra.Location = new System.Drawing.Point(29, 171);
            lblValorCompra.Name = "lblValorCompra";
            lblValorCompra.Size = new System.Drawing.Size(92, 18);
            lblValorCompra.TabIndex = 6;
            lblValorCompra.Text = "Precio Compra:";
            // 
            // lblValorVenta
            // 
            lblValorVenta.AutoSize = true;
            lblValorVenta.Location = new System.Drawing.Point(242, 171);
            lblValorVenta.Name = "lblValorVenta";
            lblValorVenta.Size = new System.Drawing.Size(82, 18);
            lblValorVenta.TabIndex = 8;
            lblValorVenta.Text = "Precio Venta:";
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Location = new System.Drawing.Point(29, 139);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new System.Drawing.Size(90, 18);
            lblFechaCompra.TabIndex = 10;
            lblFechaCompra.Text = "Fecha Compra:";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.Location = new System.Drawing.Point(339, 138);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new System.Drawing.Size(117, 18);
            lblFechaVencimiento.TabIndex = 12;
            lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new System.Drawing.Point(29, 199);
            lblStock.Name = "lblStock";
            lblStock.Size = new System.Drawing.Size(43, 18);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(29, 237);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(77, 18);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new System.Drawing.Point(339, 97);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(68, 18);
            lblProveedor.TabIndex = 18;
            lblProveedor.Text = "Proveedor:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(29, 97);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(64, 18);
            id_categoriaLabel.TabIndex = 20;
            id_categoriaLabel.Text = "Categoría:";
            // 
            // lblMinimo
            // 
            lblMinimo.AutoSize = true;
            lblMinimo.Location = new System.Drawing.Point(339, 204);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new System.Drawing.Size(85, 18);
            lblMinimo.TabIndex = 22;
            lblMinimo.Text = "Stock mínimo:";
            // 
            // lblValorMayorista
            // 
            lblValorMayorista.AutoSize = true;
            lblValorMayorista.Location = new System.Drawing.Point(436, 171);
            lblValorMayorista.Name = "lblValorMayorista";
            lblValorMayorista.Size = new System.Drawing.Size(104, 18);
            lblValorMayorista.TabIndex = 27;
            lblValorMayorista.Text = "Precio Mayorista:";
            // 
            // vista_productoBindingSource
            // 
            this.vista_productoBindingSource.DataMember = "vista_producto";
            this.vista_productoBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // dbsisventasDataSet
            // 
            this.dbsisventasDataSet.DataSetName = "dbsisventasDataSet";
            this.dbsisventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(lblValorMayorista);
            this.gbxDatos.Controls.Add(this.txtValorMayorista);
            this.gbxDatos.Controls.Add(this.btnLimpiar);
            this.gbxDatos.Controls.Add(this.btnCargar);
            this.gbxDatos.Controls.Add(this.txtMarca);
            this.gbxDatos.Controls.Add(lblValorVenta);
            this.gbxDatos.Controls.Add(this.txtNombreProducto);
            this.gbxDatos.Controls.Add(this.txtValorVenta);
            this.gbxDatos.Controls.Add(this.txtValorCompra);
            this.gbxDatos.Controls.Add(lblNombreProducto);
            this.gbxDatos.Controls.Add(lblValorCompra);
            this.gbxDatos.Controls.Add(this.txtCodigo);
            this.gbxDatos.Controls.Add(lblCodigo);
            this.gbxDatos.Controls.Add(lblMarca);
            this.gbxDatos.Controls.Add(this.cmbCategoria);
            this.gbxDatos.Controls.Add(id_categoriaLabel);
            this.gbxDatos.Controls.Add(this.pbxImagen);
            this.gbxDatos.Controls.Add(lblMinimo);
            this.gbxDatos.Controls.Add(this.txtStockMinimo);
            this.gbxDatos.Controls.Add(lblFechaCompra);
            this.gbxDatos.Controls.Add(this.dtpFechaCompra);
            this.gbxDatos.Controls.Add(lblFechaVencimiento);
            this.gbxDatos.Controls.Add(this.dtpFechaVencimiento);
            this.gbxDatos.Controls.Add(lblStock);
            this.gbxDatos.Controls.Add(this.txtStock);
            this.gbxDatos.Controls.Add(lblDescripcion);
            this.gbxDatos.Controls.Add(this.txtDescripcion);
            this.gbxDatos.Controls.Add(lblProveedor);
            this.gbxDatos.Controls.Add(this.cmbProveedor);
            this.gbxDatos.Location = new System.Drawing.Point(7, 48);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(778, 279);
            this.gbxDatos.TabIndex = 1;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Introducción de Datos";
            // 
            // txtValorMayorista
            // 
            this.txtValorMayorista.Location = new System.Drawing.Point(547, 168);
            this.txtValorMayorista.Name = "txtValorMayorista";
            this.txtValorMayorista.Size = new System.Drawing.Size(80, 21);
            this.txtValorMayorista.TabIndex = 28;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(722, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(42, 26);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "-";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(647, 148);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(42, 26);
            this.btnCargar.TabIndex = 25;
            this.btnCargar.Text = "+";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(468, 60);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 21);
            this.txtMarca.TabIndex = 5;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(157, 61);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(159, 21);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Location = new System.Drawing.Point(341, 168);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(80, 21);
            this.txtValorVenta.TabIndex = 9;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(135, 168);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(80, 21);
            this.txtValorCompra.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(158, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(469, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataSource = this.categoriaBindingSource;
            this.cmbCategoria.DisplayMember = "nombre";
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(157, 93);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(159, 26);
            this.cmbCategoria.TabIndex = 21;
            this.cmbCategoria.ValueMember = "id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = global::AppVentas.Properties.Resources.file;
            this.pbxImagen.Location = new System.Drawing.Point(647, 28);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(117, 112);
            this.pbxImagen.TabIndex = 24;
            this.pbxImagen.TabStop = false;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "stock_minimo", true));
            this.txtStockMinimo.Location = new System.Drawing.Point(468, 199);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(159, 21);
            this.txtStockMinimo.TabIndex = 23;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(157, 134);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(159, 21);
            this.dtpFechaCompra.TabIndex = 11;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(468, 133);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(159, 21);
            this.dtpFechaVencimiento.TabIndex = 13;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(157, 200);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(159, 21);
            this.txtStock.TabIndex = 15;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 234);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(469, 21);
            this.txtDescripcion.TabIndex = 17;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DataSource = this.proveedorBindingSource;
            this.cmbProveedor.DisplayMember = "nombre_empresa";
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.IntegralHeight = false;
            this.cmbProveedor.Location = new System.Drawing.Point(468, 93);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(159, 26);
            this.cmbProveedor.TabIndex = 19;
            this.cmbProveedor.ValueMember = "id";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(344, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(693, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bajasTableAdapter = null;
            this.tableAdapterManager.balanceTableAdapter = null;
            this.tableAdapterManager.categoriaTableAdapter = this.categoriaTableAdapter;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.detalle_proformaTableAdapter = null;
            this.tableAdapterManager.detalle_ventaTableAdapter = null;
            this.tableAdapterManager.deuda_proveedorTableAdapter = null;
            this.tableAdapterManager.entregaTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.proformaTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.tipo_clienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 435);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btnBajas);
            this.tabPage1.Controls.Add(this.dgvProducto);
            this.tabPage1.Controls.Add(this.lblTotalRegistros);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.cmbBuscar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AutoGenerateColumns = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvProducto.DataSource = this.vista_productoBindingSource;
            this.dgvProducto.Location = new System.Drawing.Point(7, 79);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(778, 319);
            this.dgvProducto.TabIndex = 6;
            this.dgvProducto.DoubleClick += new System.EventHandler(this.dgvProducto_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn4.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor_compra";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor Compra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "valor_venta";
            this.dataGridViewTextBoxColumn6.HeaderText = "Valor Venta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor_mayorista";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor Mayorista";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fecha_compra";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha Compra";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "fecha_vencimiento";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha Vencimiento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn10.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "stock_minimo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Stock Mínimo";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn12.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "imagen";
            this.dataGridViewImageColumn1.HeaderText = "Imagen";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "proveedor";
            this.dataGridViewTextBoxColumn13.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "categoria";
            this.dataGridViewTextBoxColumn14.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(546, 45);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(127, 18);
            this.lblTotalRegistros.TabIndex = 6;
            this.lblTotalRegistros.Text = "Número de Registros:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(155, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(366, 21);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Código",
            "Nombre Producto",
            "Marca",
            "Proveedor",
            "Categoría"});
            this.cmbBuscar.Location = new System.Drawing.Point(7, 11);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(140, 26);
            this.cmbBuscar.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcel);
            this.tabPage2.Controls.Add(this.gbxDatos);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(688, 350);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(97, 46);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Importar\r\ndesde Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(14, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Productos";
            // 
            // vista_productoTableAdapter
            // 
            this.vista_productoTableAdapter.ClearBeforeFill = true;
            // 
            // btnBajas
            // 
            this.btnBajas.Location = new System.Drawing.Point(595, 6);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(92, 32);
            this.btnBajas.TabIndex = 7;
            this.btnBajas.Text = "&Dar de baja";
            this.btnBajas.UseVisualStyleBackColor = true;
            this.btnBajas.Click += new System.EventHandler(this.btnBajas_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 496);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbsisventasDataSet dbsisventasDataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private dbsisventasDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private dbsisventasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dbsisventasDataSetTableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtValorVenta;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private dbsisventasDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource vista_productoBindingSource;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox txtValorMayorista;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private dbsisventasDataSetTableAdapters.vista_productoTableAdapter vista_productoTableAdapter;
        private System.Windows.Forms.Button btnBajas;
    }
}