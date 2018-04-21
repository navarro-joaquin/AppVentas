namespace AppVentas
{
    partial class FrmCajaCierre
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxMontos = new System.Windows.Forms.GroupBox();
            this.lblInicial = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbxMonto = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.balanceTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.balanceTableAdapter();
            this.usuarioTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.usuarioTableAdapter();
            this.ventaTableAdapter = new AppVentas.dbsisventasDataSetTableAdapters.ventaTableAdapter();
            this.gbxMontos.SuspendLayout();
            this.gbxMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(98, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Cierre Caja";
            // 
            // gbxMontos
            // 
            this.gbxMontos.Controls.Add(this.lblTotalVentas);
            this.gbxMontos.Controls.Add(this.lblInicial);
            this.gbxMontos.Location = new System.Drawing.Point(12, 46);
            this.gbxMontos.Name = "gbxMontos";
            this.gbxMontos.Size = new System.Drawing.Size(300, 138);
            this.gbxMontos.TabIndex = 3;
            this.gbxMontos.TabStop = false;
            // 
            // lblInicial
            // 
            this.lblInicial.AutoSize = true;
            this.lblInicial.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicial.Location = new System.Drawing.Point(23, 29);
            this.lblInicial.Name = "lblInicial";
            this.lblInicial.Size = new System.Drawing.Size(109, 20);
            this.lblInicial.TabIndex = 0;
            this.lblInicial.Text = "Monto Inicial : ";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(23, 84);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(127, 20);
            this.lblTotalVentas.TabIndex = 1;
            this.lblTotalVentas.Text = "Total Ventas Día: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(65, 348);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 18);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 324);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 18);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // gbxMonto
            // 
            this.gbxMonto.Controls.Add(this.btnAceptar);
            this.gbxMonto.Controls.Add(this.txtMonto);
            this.gbxMonto.Location = new System.Drawing.Point(12, 190);
            this.gbxMonto.Name = "gbxMonto";
            this.gbxMonto.Size = new System.Drawing.Size(300, 131);
            this.gbxMonto.TabIndex = 4;
            this.gbxMonto.TabStop = false;
            this.gbxMonto.Text = "Monto Final";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(97, 84);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 31);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(28, 40);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(246, 23);
            this.txtMonto.TabIndex = 0;
            // 
            // balanceTableAdapter
            // 
            this.balanceTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCajaCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 373);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gbxMonto);
            this.Controls.Add(this.gbxMontos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCajaCierre";
            this.Text = "FrmCajaCierre";
            this.Load += new System.EventHandler(this.FrmCajaCierre_Load);
            this.gbxMontos.ResumeLayout(false);
            this.gbxMontos.PerformLayout();
            this.gbxMonto.ResumeLayout(false);
            this.gbxMonto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxMontos;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblInicial;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbxMonto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtMonto;
        private dbsisventasDataSetTableAdapters.balanceTableAdapter balanceTableAdapter;
        private dbsisventasDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private dbsisventasDataSetTableAdapters.ventaTableAdapter ventaTableAdapter;
    }
}