using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentas
{
    public partial class FrmPruebaReporte : Form
    {
        private string Fecha, Monto_pagado, Monto_restante, Proveedor, Representante;

        public FrmPruebaReporte()
        {
            InitializeComponent();
        }

        public  void cargarDatos(string fecha, string monto_pagado, string monto_restante, string proveedor, string representante)
        {
            /*
            Fecha = fecha;
            Monto_pagado = monto_pagado;
            Monto_restante = monto_restante;
            Proveedor = proveedor;
            Representante = representante;

            MessageBox.Show(Fecha + "\n" + Monto_pagado + "\n" + Monto_restante + "\n" + Proveedor + "\n" + Representante);
            */
        }

        private void FrmPruebaReporte_Load(object sender, EventArgs e)
        {
            Fecha = DateTime.Today.ToShortDateString();

            LocalReport report = new LocalReport();
            report.ReportPath = @"RepPagoDeuda.rdlc";

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", Fecha));
            //reportParams.Add(new ReportParameter("MontoPagado", Monto_pagado));
            //reportParams.Add(new ReportParameter("MontoRestante", Monto_restante));
            //reportParams.Add(new ReportParameter("Proveedor", Proveedor));
            //reportParams.Add(new ReportParameter("Representante", Representante));
            reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);

            string query = "select p.codigo, p.nombre_producto, p.marca, p.imagen, p.descripcion, p.valor_venta, dp.id from detalle_proforma dp " +
                            "inner join producto p " +
                            "on dp.id_producto = p.id " +
                            "where dp.id_proforma = " + 2;

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[7].TableName);

            ReportDataSource rds = new ReportDataSource("DetalleCaracteristicasProforma", con.Tables[7]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);


            this.reportViewer1.RefreshReport();
        }
    }
}
