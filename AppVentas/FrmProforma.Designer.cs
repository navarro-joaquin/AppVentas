namespace AppVentas
{
    partial class FrmProforma
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
            this.gbxProducto = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNITCI = new System.Windows.Forms.TextBox();
            this.lblNITCI = new System.Windows.Forms.Label();
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvProforma = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.productoTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.productoTableAdapter();
            this.clienteTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.clienteTableAdapter();
            this.dbsisventasDataSet = new AppVentas.dbsisventasDataSet();
            this.detalle_proformaTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.detalle_proformaTableAdapter();
            this.tableAdapterManager = new AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager();
            this.proformaTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.proformaTableAdapter();
            this.gbxProducto.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxProducto
            // 
            this.gbxProducto.Controls.Add(this.txtCantidad);
            this.gbxProducto.Controls.Add(this.lblCantidad);
            this.gbxProducto.Controls.Add(this.txtStock);
            this.gbxProducto.Controls.Add(this.lblStock);
            this.gbxProducto.Controls.Add(this.txtPrecio);
            this.gbxProducto.Controls.Add(this.lblPrecio);
            this.gbxProducto.Controls.Add(this.txtDescripcion);
            this.gbxProducto.Controls.Add(this.lblDescripcion);
            this.gbxProducto.Controls.Add(this.txtNombre);
            this.gbxProducto.Controls.Add(this.lblNombre);
            this.gbxProducto.Controls.Add(this.btnBuscarProducto);
            this.gbxProducto.Controls.Add(this.txtCodigoProducto);
            this.gbxProducto.Controls.Add(this.lblCodigoProducto);
            this.gbxProducto.Location = new System.Drawing.Point(12, 12);
            this.gbxProducto.Name = "gbxProducto";
            this.gbxProducto.Size = new System.Drawing.Size(738, 169);
            this.gbxProducto.TabIndex = 1;
            this.gbxProducto.TabStop = false;
            this.gbxProducto.Text = "Producto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(625, 119);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 21);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(552, 122);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(60, 18);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(465, 119);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(77, 21);
            this.txtStock.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(408, 122);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 18);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(625, 79);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(77, 21);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.TabStop = false;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(568, 83);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 18);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(118, 118);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(283, 21);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(77, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(425, 21);
            this.txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(625, 29);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(78, 37);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "&Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(145, 35);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(322, 21);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(28, 38);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(104, 18);
            this.lblCodigoProducto.TabIndex = 0;
            this.lblCodigoProducto.Text = "Código Producto:";
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.btnBuscarCliente);
            this.gbxCliente.Controls.Add(this.txtNombreCliente);
            this.gbxCliente.Controls.Add(this.lblNombreCliente);
            this.gbxCliente.Controls.Add(this.txtNITCI);
            this.gbxCliente.Controls.Add(this.lblNITCI);
            this.gbxCliente.Location = new System.Drawing.Point(12, 187);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(738, 108);
            this.gbxCliente.TabIndex = 2;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(491, 21);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(127, 36);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(167, 69);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(451, 21);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(77, 72);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(55, 18);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtNITCI
            // 
            this.txtNITCI.Location = new System.Drawing.Point(167, 28);
            this.txtNITCI.Name = "txtNITCI";
            this.txtNITCI.Size = new System.Drawing.Size(145, 21);
            this.txtNITCI.TabIndex = 1;
            this.txtNITCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNITCI_KeyPress);
            // 
            // lblNITCI
            // 
            this.lblNITCI.AutoSize = true;
            this.lblNITCI.Location = new System.Drawing.Point(77, 32);
            this.lblNITCI.Name = "lblNITCI";
            this.lblNITCI.Size = new System.Drawing.Size(46, 18);
            this.lblNITCI.TabIndex = 0;
            this.lblNITCI.Text = "NIT/CI:";
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.dgvProforma);
            this.gbxListado.Location = new System.Drawing.Point(12, 301);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(738, 246);
            this.gbxListado.TabIndex = 3;
            this.gbxListado.TabStop = false;
            // 
            // dgvProforma
            // 
            this.dgvProforma.AllowUserToAddRows = false;
            this.dgvProforma.AllowUserToDeleteRows = false;
            this.dgvProforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProforma.Location = new System.Drawing.Point(7, 21);
            this.dgvProforma.Name = "dgvProforma";
            this.dgvProforma.ReadOnly = true;
            this.dgvProforma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProforma.Size = new System.Drawing.Size(724, 218);
            this.dgvProforma.TabIndex = 0;
            this.dgvProforma.DoubleClick += new System.EventHandler(this.dgvProforma_DoubleClick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(637, 553);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 45);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir Proforma";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(61, 564);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(123, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 567);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dbsisventasDataSet
            // 
            this.dbsisventasDataSet.DataSetName = "dbsisventasDataSet";
            this.dbsisventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalle_proformaTableAdapter
            // 
            this.detalle_proformaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.detalle_proformaTableAdapter = this.detalle_proformaTableAdapter;
            this.tableAdapterManager.detalle_ventaTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.proformaTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.tipo_clienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // proformaTableAdapter
            // 
            this.proformaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(766, 612);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxProducto);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProforma";
            this.Text = "FrmProforma";
            this.Load += new System.EventHandler(this.FrmProforma_Load);
            this.gbxProducto.ResumeLayout(false);
            this.gbxProducto.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNITCI;
        private System.Windows.Forms.Label lblNITCI;
        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.DataGridView dgvProforma;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private dbsisventasDataSetTableAdapters.productoTableAdapter productoTableAdapter;
        private dbsisventasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private dbsisventasDataSet dbsisventasDataSet;
        private dbsisventasDataSetTableAdapters.detalle_proformaTableAdapter detalle_proformaTableAdapter;
        private dbsisventasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private dbsisventasDataSetTableAdapters.proformaTableAdapter proformaTableAdapter;
    }
}