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
    public partial class FrmRepDetalleEntrega : Form
    {
        int id_almacenero;
        int id_vendedor;

        public FrmRepDetalleEntrega(int almacenero, int vendedor)
        {
            InitializeComponent();
            id_almacenero = almacenero;
            id_vendedor = vendedor;
        }

        private void FrmRepDetalleEntrega_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("dd-MM-yyyy");

            string fecha1 = fecha + " 00:00:00";
            string fecha2 = fecha + " 23:59:59";

            string nombre_vendedor = this.usuarioTableAdapter.ObtenerNombreUsuario(id_vendedor);
            string nombre_almacenero = this.usuarioTableAdapter.ObtenerNombreUsuario(id_almacenero);

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));
            reportParams.Add(new ReportParameter("VendedorLogin", nombre_vendedor));
            reportParams.Add(new ReportParameter("AlmaceneroLogin", nombre_almacenero));

            reportViewer1.LocalReport.SetParameters(reportParams);

            string query = "";

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            try
            {
                query = "select e.id, e.fecha, p.nombre_producto, e.cantidad, e.id_vendedor, us.usuario as vendedor, e.id_almacenero, u.usuario as almacenero " +
                                "from entrega e " +
                                "inner join producto p " +
                                "on e.producto = p.id " +
                                "inner join usuario u " +
                                "on e.id_almacenero = u.id " +
                                "inner join usuario us " +
                                "on e.id_vendedor = us.id " +
                                "where e.fecha = '" + fecha + "'" +
                                "and e.id_vendedor = " + id_vendedor + "" +
                                "and e.id_almacenero = " + id_almacenero + "";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                da.Fill(con, con.Tables[8].TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion1: " + ex.Message);
            }

            ReportDataSource rds = new ReportDataSource("DetalleEntrega", con.Tables[8]);

            con = new Consultas();
            cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            cn = new SqlConnection(cs);
            try
            {
                query = "select v.id, v.fecha, p.nombre_producto, dv.cantidad, v.id_usuario from venta v " +
                        "inner join detalle_venta dv " +
                        "on v.id = dv.id_venta " +
                        "inner join producto p " +
                        "on dv.id_producto = p.id " +
                        "where v.fecha between '" + fecha1 + "' and '" + fecha2 + "'" +
                        "and v.id_usuario = " + id_vendedor + "";

                SqlDataAdapter da1 = new SqlDataAdapter(query, cn);
                da1.Fill(con, con.Tables[9].TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion2: " + ex.Message);
            }

            ReportDataSource rds2 = new ReportDataSource("DetalleVentaEntrega", con.Tables[9]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
