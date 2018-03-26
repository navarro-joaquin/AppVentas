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
using System.IO;

namespace AppVentas
{
    public partial class FrmRepVentasDia : Form
    {
        int id_usuario;

        public FrmRepVentasDia(int id)
        {
            InitializeComponent();
            id_usuario = id;
        }

        private void FrmRepVentasDia_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToShortDateString();

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));

            this.reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            string query = "select v.numero_factura, v.total_venta, v.descuento, v.importe_pagado, c.nombre as cliente, (u.nombres + ' ' + u.apellidos) as usuario, " +
                            "(select sum(total_venta) from venta where id_usuario = " + id_usuario + " and fecha = '" + fecha + "') as suma_total from venta v " +
                            "inner join cliente c " +
                            "on v.id_cliente = c.id " +
                            "inner join usuario u " +
                            "on v.id_usuario = u.id " +
                            "where u.id = " + id_usuario + " and v.fecha = '" + fecha + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[3].TableName);

            ReportDataSource rds = new ReportDataSource("DetalleVentasDia", con.Tables[3]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.Refresh();

            this.reportViewer1.RefreshReport();

            //GenerarPDF();
        }

        private void GenerarPDF()
        {
            string fecha = DateTime.Today.ToString("dd-MM-yyyy");
            string nombre = this.usuarioTableAdapter.ObtenerNombreUsuario(id_usuario);

            Warning[] warnings;
            string[] streamids;
            string mimetype;
            string encoding;
            string fileNameExtension;

            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimetype, out encoding,
                out fileNameExtension, out streamids, out warnings);

            string nombre_archivo = @"Reportes\Ventas-" + @fecha + "-" + nombre + ".pdf";

            using (FileStream fs = new FileStream(nombre_archivo, FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
