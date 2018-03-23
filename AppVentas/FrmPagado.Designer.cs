namespace AppVentas
{
    partial class FrmPagado
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
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.lblImportePagado = new System.Windows.Forms.Label();
            this.txtImportePagado = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblCambioImporte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(31, 18);
            this.lblTotalVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(95, 22);
            this.lblTotalVenta.TabIndex = 0;
            this.lblTotalVenta.Text = "Total venta:";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.Location = new System.Drawing.Point(35, 54);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.ReadOnly = true;
            this.txtTotalVenta.Size = new System.Drawing.Size(132, 26);
            this.txtTotalVenta.TabIndex = 1;
            this.txtTotalVenta.TabStop = false;
            // 
            // lblImportePagado
            // 
            this.lblImportePagado.AutoSize = true;
            this.lblImportePagado.Location = new System.Drawing.Point(31, 98);
            this.lblImportePagado.Name = "lblImportePagado";
            this.lblImportePagado.Size = new System.Drawing.Size(128, 22);
            this.lblImportePagado.TabIndex = 2;
            this.lblImportePagado.Text = "Importe pagado:";
            // 
            // txtImportePagado
            // 
            this.txtImportePagado.Location = new System.Drawing.Point(35, 137);
            this.txtImportePagado.Name = "txtImportePagado";
            this.txtImportePagado.Size = new System.Drawing.Size(132, 26);
            this.txtImportePagado.TabIndex = 3;
            this.txtImportePagado.Text = "0.00";
            this.txtImportePagado.TextChanged += new System.EventHandler(this.txtImportePagado_TextChanged);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(17, 260);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 31);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(122, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(31, 183);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(70, 22);
            this.lblCambio.TabIndex = 6;
            this.lblCambio.Text = "Cambio:";
            // 
            // lblCambioImporte
            // 
            this.lblCambioImporte.AutoSize = true;
            this.lblCambioImporte.Location = new System.Drawing.Point(31, 217);
            this.lblCambioImporte.Name = "lblCambioImporte";
            this.lblCambioImporte.Size = new System.Drawing.Size(40, 22);
            this.lblCambioImporte.TabIndex = 7;
            this.lblCambioImporte.Text = "0.00";
            // 
            // FrmPagado
            // 
            this.AcceptButton = this.btnVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(215, 303);
            this.Controls.Add(this.lblCambioImporte);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtImportePagado);
            this.Controls.Add(this.lblImportePagado);
            this.Controls.Add(this.txtTotalVenta);
            this.Controls.Add(this.lblTotalVenta);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPagado";
            this.Text = "FrmPagado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Label lblImportePagado;
        private System.Windows.Forms.TextBox txtImportePagado;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblCambioImporte;
    }
}