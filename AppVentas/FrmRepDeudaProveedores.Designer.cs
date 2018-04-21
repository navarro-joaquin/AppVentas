namespace AppVentas
{
    partial class FrmRepDeudaProveedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Consultas = new AppVentas.Consultas();
            this.DetalleDeudaTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleDeudaTotalTableAdapter = new AppVentas.ConsultasTableAdapters.DetalleDeudaTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDeudaTotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DetalleDeudaTotal";
            reportDataSource1.Value = this.DetalleDeudaTotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVentas.RepDeudaProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // Consultas
            // 
            this.Consultas.DataSetName = "Consultas";
            this.Consultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleDeudaTotalBindingSource
            // 
            this.DetalleDeudaTotalBindingSource.DataMember = "DetalleDeudaTotal";
            this.DetalleDeudaTotalBindingSource.DataSource = this.Consultas;
            // 
            // DetalleDeudaTotalTableAdapter
            // 
            this.DetalleDeudaTotalTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepDeudaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepDeudaProveedores";
            this.Text = "FrmRepDeudaProveedores";
            this.Load += new System.EventHandler(this.FrmRepDeudaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDeudaTotalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetalleDeudaTotalBindingSource;
        private Consultas Consultas;
        private ConsultasTableAdapters.DetalleDeudaTotalTableAdapter DetalleDeudaTotalTableAdapter;
    }
}