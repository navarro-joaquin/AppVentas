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
    public partial class FrmRepNuevosProductos : Form
    {
        string fecha;

        public FrmRepNuevosProductos()
        {
            InitializeComponent();
            fecha = "";
        }

        public FrmRepNuevosProductos(string fecha_reporte)
        {
            InitializeComponent();
            fecha = fecha_reporte;
        }

        private void FrmRepNuevosProductos_Load(object sender, EventArgs e)
        {
            if (!fecha.Equals(""))
            {
                btnGenerar.PerformClick();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (fecha.Equals("") || fecha.Equals("Utilizado"))
            {
                fecha = dtpFecha.Value.ToShortDateString();
            }

            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));

            reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            string query = "select p.codigo, p.nombre_producto, p.valor_compra, p.valor_venta, p.fecha_vencimiento, p.stock, p.stock_minimo, p.descripcion, pr.nombre_empresa as proveedor, c.nombre as categoria from producto p " + 
                            "inner join categoria c " + 
                            "on p.id_categoria = c.id " + 
                            "inner join proveedor pr " + 
                            "on p.id_proveedor = pr.id " +
                            "where p.fecha_compra = '" + fecha + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[1].TableName);

            ReportDataSource rds = new ReportDataSource("DetalleIngresoAlmacen", con.Tables[1]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();

            fecha = "Utilizado";
        }
    }
}
