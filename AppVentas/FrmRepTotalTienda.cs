using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace AppVentas
{
    public partial class FrmRepTotalTienda : Form
    {
        public FrmRepTotalTienda()
        {
            InitializeComponent();
        }

        private void FrmRepTotalTienda_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToShortDateString();

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));

            reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            string query = "select codigo, nombre_producto, valor_venta, stock, (valor_venta * stock) as precio_total, (select sum(valor_venta * stock) from producto) as precio_final from producto";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[2].TableName);

            ReportDataSource rds = new ReportDataSource("DetalleTotalTienda", con.Tables[2]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
