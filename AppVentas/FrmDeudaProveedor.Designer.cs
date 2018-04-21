namespace AppVentas
{
    partial class FrmDeudaProveedor
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
            System.Windows.Forms.Label lblFecha;
            System.Windows.Forms.Label lblMontoTotal;
            System.Windows.Forms.Label lblMontoRestante;
            System.Windows.Forms.Label lblFechaProximoPago;
            System.Windows.Forms.Label lblMontoPagado;
            System.Windows.Forms.Label lblProveedor;
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDeudaProveedor = new System.Windows.Forms.DataGridView();
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
            this.vista_deuda_proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsisventasDataSet = new AppVentas.dbsisventasDataSet();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtMontoRestante = new System.Windows.Forms.TextBox();
            this.dtpFechaProximoPago = new System.Windows.Forms.DateTimePicker();
            this.txtMontoPagado = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.vista_deuda_proveedorTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.vista_deuda_proveedorTableAdapter();
            this.tableAdapterManager = new AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager();
            this.deuda_proveedorTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.deuda_proveedorTableAdapter();
            this.proveedorTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.proveedorTableAdapter();
            this.deuda_proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lblFecha = new System.Windows.Forms.Label();
            lblMontoTotal = new System.Windows.Forms.Label();
            lblMontoRestante = new System.Windows.Forms.Label();
            lblFechaProximoPago = new System.Windows.Forms.Label();
            lblMontoPagado = new System.Windows.Forms.Label();
            lblProveedor = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_deuda_proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deuda_proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(90, 28);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(45, 18);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Location = new System.Drawing.Point(90, 55);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new System.Drawing.Size(79, 18);
            lblMontoTotal.TabIndex = 2;
            lblMontoTotal.Text = "Monto Total:";
            // 
            // lblMontoRestante
            // 
            lblMontoRestante.AutoSize = true;
            lblMontoRestante.Location = new System.Drawing.Point(347, 55);
            lblMontoRestante.Name = "lblMontoRestante";
            lblMontoRestante.Size = new System.Drawing.Size(101, 18);
            lblMontoRestante.TabIndex = 4;
            lblMontoRestante.Text = "Monto Restante:";
            // 
            // lblFechaProximoPago
            // 
            lblFechaProximoPago.AutoSize = true;
            lblFechaProximoPago.Location = new System.Drawing.Point(90, 84);
            lblFechaProximoPago.Name = "lblFechaProximoPago";
            lblFechaProximoPago.Size = new System.Drawing.Size(121, 18);
            lblFechaProximoPago.TabIndex = 6;
            lblFechaProximoPago.Text = "Fecha Próximo Pago:";
            // 
            // lblMontoPagado
            // 
            lblMontoPagado.AutoSize = true;
            lblMontoPagado.Location = new System.Drawing.Point(90, 118);
            lblMontoPagado.Name = "lblMontoPagado";
            lblMontoPagado.Size = new System.Drawing.Size(90, 18);
            lblMontoPagado.TabIndex = 8;
            lblMontoPagado.Text = "Monto Pagado:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new System.Drawing.Point(355, 118);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(64, 18);
            lblProveedor.TabIndex = 10;
            lblProveedor.Text = "Proveedor";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Proveedores";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 350);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dgvDeudaProveedor);
            this.tabPage1.Controls.Add(this.lblTotalRegistros);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.cmbBuscar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDeudaProveedor
            // 
            this.dgvDeudaProveedor.AllowUserToAddRows = false;
            this.dgvDeudaProveedor.AllowUserToDeleteRows = false;
            this.dgvDeudaProveedor.AutoGenerateColumns = false;
            this.dgvDeudaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvDeudaProveedor.DataSource = this.vista_deuda_proveedorBindingSource;
            this.dgvDeudaProveedor.Location = new System.Drawing.Point(6, 79);
            this.dgvDeudaProveedor.Name = "dgvDeudaProveedor";
            this.dgvDeudaProveedor.ReadOnly = true;
            this.dgvDeudaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeudaProveedor.Size = new System.Drawing.Size(712, 234);
            this.dgvDeudaProveedor.TabIndex = 6;
            this.dgvDeudaProveedor.DoubleClick += new System.EventHandler(this.dgvDeudaProveedor_DoubleClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "monto_total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "monto_restante";
            this.dataGridViewTextBoxColumn4.HeaderText = "Monto_restante";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_proximo_pago";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Próximo Pago";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "monto_pagado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Monto Pagado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "proveedor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "representante";
            this.dataGridViewTextBoxColumn8.HeaderText = "Representante";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn9.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nit_ci";
            this.dataGridViewTextBoxColumn10.HeaderText = "NIT/CI";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // vista_deuda_proveedorBindingSource
            // 
            this.vista_deuda_proveedorBindingSource.DataMember = "vista_deuda_proveedor";
            this.vista_deuda_proveedorBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // dbsisventasDataSet
            // 
            this.dbsisventasDataSet.DataSetName = "dbsisventasDataSet";
            this.dbsisventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(488, 51);
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
            this.txtBuscar.Size = new System.Drawing.Size(327, 21);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Proveedor"});
            this.cmbBuscar.Location = new System.Drawing.Point(7, 11);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(140, 26);
            this.cmbBuscar.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(626, 7);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbxDatos);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(727, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cmbProveedor);
            this.gbxDatos.Controls.Add(lblProveedor);
            this.gbxDatos.Controls.Add(lblFecha);
            this.gbxDatos.Controls.Add(this.dtpFecha);
            this.gbxDatos.Controls.Add(lblMontoTotal);
            this.gbxDatos.Controls.Add(this.txtMontoTotal);
            this.gbxDatos.Controls.Add(lblMontoRestante);
            this.gbxDatos.Controls.Add(this.txtMontoRestante);
            this.gbxDatos.Controls.Add(lblFechaProximoPago);
            this.gbxDatos.Controls.Add(this.dtpFechaProximoPago);
            this.gbxDatos.Controls.Add(lblMontoPagado);
            this.gbxDatos.Controls.Add(this.txtMontoPagado);
            this.gbxDatos.Location = new System.Drawing.Point(6, 69);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(715, 155);
            this.gbxDatos.TabIndex = 3;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Introducción de Datos";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DataSource = this.proveedorBindingSource;
            this.cmbProveedor.DisplayMember = "nombre_empresa";
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(474, 110);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(111, 26);
            this.cmbProveedor.TabIndex = 11;
            this.cmbProveedor.ValueMember = "id";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(217, 24);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(282, 21);
            this.dtpFecha.TabIndex = 1;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(217, 52);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(111, 21);
            this.txtMontoTotal.TabIndex = 3;
            // 
            // txtMontoRestante
            // 
            this.txtMontoRestante.Location = new System.Drawing.Point(474, 52);
            this.txtMontoRestante.Name = "txtMontoRestante";
            this.txtMontoRestante.ReadOnly = true;
            this.txtMontoRestante.Size = new System.Drawing.Size(111, 21);
            this.txtMontoRestante.TabIndex = 5;
            // 
            // dtpFechaProximoPago
            // 
            this.dtpFechaProximoPago.Enabled = false;
            this.dtpFechaProximoPago.Location = new System.Drawing.Point(217, 80);
            this.dtpFechaProximoPago.Name = "dtpFechaProximoPago";
            this.dtpFechaProximoPago.Size = new System.Drawing.Size(282, 21);
            this.dtpFechaProximoPago.TabIndex = 7;
            // 
            // txtMontoPagado
            // 
            this.txtMontoPagado.Enabled = false;
            this.txtMontoPagado.Location = new System.Drawing.Point(217, 115);
            this.txtMontoPagado.Name = "txtMontoPagado";
            this.txtMontoPagado.Size = new System.Drawing.Size(111, 21);
            this.txtMontoPagado.TabIndex = 9;
            this.txtMontoPagado.TextChanged += new System.EventHandler(this.txtMontoPagado_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(310, 262);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 32);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // vista_deuda_proveedorTableAdapter
            // 
            this.vista_deuda_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.balanceTableAdapter = null;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.detalle_proformaTableAdapter = null;
            this.tableAdapterManager.detalle_ventaTableAdapter = null;
            this.tableAdapterManager.deuda_proveedorTableAdapter = this.deuda_proveedorTableAdapter;
            this.tableAdapterManager.productoTableAdapter = null;
            this.tableAdapterManager.proformaTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = this.proveedorTableAdapter;
            this.tableAdapterManager.tipo_clienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // deuda_proveedorTableAdapter
            // 
            this.deuda_proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // deuda_proveedorBindingSource
            // 
            this.deuda_proveedorBindingSource.DataMember = "deuda_proveedor";
            this.deuda_proveedorBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // FrmDeudaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 414);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDeudaProveedor";
            this.Text = "FrmDeudaProveedor";
            this.Load += new System.EventHandler(this.FrmDeudaProveedor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_deuda_proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deuda_proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuardar;
        private dbsisventasDataSet dbsisventasDataSet;
        private System.Windows.Forms.BindingSource vista_deuda_proveedorBindingSource;
        private dbsisventasDataSetTableAdapters.vista_deuda_proveedorTableAdapter vista_deuda_proveedorTableAdapter;
        private dbsisventasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbxDatos;
        private dbsisventasDataSetTableAdapters.deuda_proveedorTableAdapter deuda_proveedorTableAdapter;
        private System.Windows.Forms.BindingSource deuda_proveedorBindingSource;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtMontoRestante;
        private System.Windows.Forms.DateTimePicker dtpFechaProximoPago;
        private System.Windows.Forms.TextBox txtMontoPagado;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private dbsisventasDataSetTableAdapters.proveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridView dgvDeudaProveedor;
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
    }
}