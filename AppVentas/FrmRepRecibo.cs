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
    public partial class FrmRepRecibo : Form
    {
        private string nit_cliente;
        private string nombre_cliente;
        private string fecha_venta;
        private string numero_recibo;
        private string numero_nit;

        public FrmRepRecibo(string nitCliente, string nombreCliente, string fechaVenta, string numeroRecibo, string numeroNit)
        {
            InitializeComponent();
            nit_cliente = nitCliente;
            nombre_cliente = nombreCliente;
            fecha_venta = fechaVenta;
            numero_recibo = numeroRecibo;
            numero_nit = numeroNit;

            this.sp_vista_reciboTableAdapter.Fill(this.consultas.sp_vista_recibo, 1);
        }

        private void FrmRepRecibo_Load(object sender, EventArgs e)
        {
            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("NitCliente", nit_cliente));
            reportParams.Add(new ReportParameter("NombreCliente", nombre_cliente));
            reportParams.Add(new ReportParameter("FechaVenta", fecha_venta));
            reportParams.Add(new ReportParameter("NumeroRecibo", numero_recibo));
            reportParams.Add(new ReportParameter("NumeroNit", numero_nit));

            reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            string query = "select p.nombre_producto, dv.cantidad, dv.precio, dv.subtotal, v.total_venta from detalle_venta dv " +
                            "inner join producto p " +
                            "on dv.id_producto = p.id " +
                            "inner join venta v " +
                            "on dv.id_venta = v.id " + 
                            "where id_venta = 2";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("Detalle_Venta", con.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
