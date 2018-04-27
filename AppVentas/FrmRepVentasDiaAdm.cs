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
    public partial class FrmRepVentasDiaAdm : Form
    {
        public FrmRepVentasDiaAdm()
        {
            InitializeComponent();
        }

        private void FrmRepVentasDiaAdm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dbsisventasDataSet.usuario);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString();

            string fecha1 = DateTime.Now.ToShortDateString() + " 00:00:00";
            string fecha2 = DateTime.Now.ToShortDateString() + " 23:59:59";

            int id_usuario = Convert.ToInt32(cmbUsuario.SelectedValue);

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));

            this.reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            string query = "select v.numero_factura, v.total_venta, v.descuento, v.importe_pagado, c.nombre as cliente, (u.nombres + ' ' + u.apellidos) as usuario, " +
                            "(select sum(total_venta) from venta where id_usuario = " + id_usuario + " and fecha between '" + fecha1 + "' and '" + fecha2 + "') as suma_total from venta v " +
                            "inner join cliente c " +
                            "on v.id_cliente = c.id " +
                            "inner join usuario u " +
                            "on v.id_usuario = u.id " +
                            "where u.id = " + id_usuario + " and v.fecha between '" + fecha1 + "' and '" + fecha2 + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[3].TableName);

            ReportDataSource rds = new ReportDataSource("DetalleVentasDia", con.Tables[3]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
