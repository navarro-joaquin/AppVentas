namespace AppVentas
{
    partial class FrmCliente
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
            System.Windows.Forms.Label lblNombre;
            System.Windows.Forms.Label lblNITCI;
            System.Windows.Forms.Label lblCodigoDescuento;
            System.Windows.Forms.Label lblTelefono;
            System.Windows.Forms.Label lblRepresentante;
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsisventasDataSet = new AppVentas.dbsisventasDataSet();
            this.txtCodigoDescuento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNITCI = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager();
            lblNombre = new System.Windows.Forms.Label();
            lblNITCI = new System.Windows.Forms.Label();
            lblCodigoDescuento = new System.Windows.Forms.Label();
            lblTelefono = new System.Windows.Forms.Label();
            lblRepresentante = new System.Windows.Forms.Label();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(25, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(55, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblNITCI
            // 
            lblNITCI.AutoSize = true;
            lblNITCI.Location = new System.Drawing.Point(25, 65);
            lblNITCI.Name = "lblNITCI";
            lblNITCI.Size = new System.Drawing.Size(46, 18);
            lblNITCI.TabIndex = 2;
            lblNITCI.Text = "NIT/CI:";
            // 
            // lblCodigoDescuento
            // 
            lblCodigoDescuento.AutoSize = true;
            lblCodigoDescuento.Location = new System.Drawing.Point(25, 92);
            lblCodigoDescuento.Name = "lblCodigoDescuento";
            lblCodigoDescuento.Size = new System.Drawing.Size(112, 18);
            lblCodigoDescuento.TabIndex = 4;
            lblCodigoDescuento.Text = "Código descuento:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(344, 65);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(60, 18);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblRepresentante
            // 
            lblRepresentante.AutoSize = true;
            lblRepresentante.Location = new System.Drawing.Point(344, 92);
            lblRepresentante.Name = "lblRepresentante";
            lblRepresentante.Size = new System.Drawing.Size(94, 18);
            lblRepresentante.TabIndex = 8;
            lblRepresentante.Text = "Representante:";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(lblRepresentante);
            this.gbxDatos.Controls.Add(this.txtRepresentante);
            this.gbxDatos.Controls.Add(lblTelefono);
            this.gbxDatos.Controls.Add(lblCodigoDescuento);
            this.gbxDatos.Controls.Add(this.txtCodigoDescuento);
            this.gbxDatos.Controls.Add(this.txtTelefono);
            this.gbxDatos.Controls.Add(lblNombre);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(lblNITCI);
            this.gbxDatos.Controls.Add(this.txtNITCI);
            this.gbxDatos.Location = new System.Drawing.Point(7, 98);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(628, 146);
            this.gbxDatos.TabIndex = 1;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Introducción de Datos";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Location = new System.Drawing.Point(444, 89);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(158, 21);
            this.txtRepresentante.TabIndex = 9;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.dbsisventasDataSet;
            // 
            // dbsisventasDataSet
            // 
            this.dbsisventasDataSet.DataSetName = "dbsisventasDataSet";
            this.dbsisventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodigoDescuento
            // 
            this.txtCodigoDescuento.Location = new System.Drawing.Point(160, 89);
            this.txtCodigoDescuento.Name = "txtCodigoDescuento";
            this.txtCodigoDescuento.Size = new System.Drawing.Size(158, 21);
            this.txtCodigoDescuento.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(444, 62);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(158, 21);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(442, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // txtNITCI
            // 
            this.txtNITCI.Location = new System.Drawing.Point(160, 62);
            this.txtNITCI.Name = "txtNITCI";
            this.txtNITCI.Size = new System.Drawing.Size(158, 21);
            this.txtNITCI.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(273, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 33);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(532, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 384);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dgvCliente);
            this.tabPage1.Controls.Add(this.lblTotalRegistros);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.cmbBuscar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 353);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoGenerateColumns = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvCliente.DataSource = this.clienteBindingSource;
            this.dgvCliente.Location = new System.Drawing.Point(7, 95);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(625, 252);
            this.dgvCliente.TabIndex = 7;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nit_ci";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIT/CI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigo_descuento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código Descuento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nombre_representante";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre Representante";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(430, 57);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(127, 18);
            this.lblTotalRegistros.TabIndex = 7;
            this.lblTotalRegistros.Text = "Número de Registros:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(155, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(287, 21);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Nombre",
            "NIT/CI"});
            this.cmbBuscar.Location = new System.Drawing.Point(7, 17);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(140, 26);
            this.cmbBuscar.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.gbxDatos);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Teal;
            this.lblTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(83, 24);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Clientes";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.balanceTableAdapter = null;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.detalle_proformaTableAdapter = null;
            this.tableAdapterManager.detalle_ventaTableAdapter = null;
            this.tableAdapterManager.deuda_proveedorTableAdapter = null;
            this.tableAdapterManager.productoTableAdapter = null;
            this.tableAdapterManager.proformaTableAdapter = null;
            this.tableAdapterManager.proveedorTableAdapter = null;
            this.tableAdapterManager.tipo_clienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVentas.dbsisventasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            this.tableAdapterManager.ventaTableAdapter = null;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 442);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsisventasDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbsisventasDataSet dbsisventasDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private dbsisventasDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private dbsisventasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNITCI;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigoDescuento;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}