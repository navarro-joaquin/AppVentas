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

using Microsoft.Reporting.WinForms;

namespace AppVentas
{
    public partial class FrmRepBalanceDia : Form
    {
        public FrmRepBalanceDia()
        {
            InitializeComponent();
        }

        private void FrmRepBalanceDia_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFecha.Value.ToShortDateString();

            string fecha1 = fecha + " 00:00:00";
            string fecha2 = fecha + " 23:59:59";

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("Fecha", fecha));

            reportViewer1.LocalReport.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);
            string query = "select dv.id, v.fecha, p.nombre_producto as producto, p.valor_compra, p.valor_venta, v.total_venta, v.descuento, v.importe_pagado, (v.importe_pagado - v.total_venta + v.descuento) as cambio, v.id as id_venta, v.numero_factura as nro_recibo, u.usuario, " +
                            "(select sum(dv.subtotal - (p.valor_compra * dv.cantidad) - v.descuento) " +
                            "from detalle_venta dv " +
                            "inner join venta v " +
                            "on dv.id_venta = v.id " +
                            "inner join producto p " +
                            "on dv.id_producto = p.id " +
                            "where v.fecha between '" + fecha1 + "' and '" + fecha2 + "') as ganancia, " +
                            "(select sum(monto_pagado) from deuda_proveedor " +
                            "where fecha = '" + fecha + "' and monto_pagado is not null) as deudas_pagadas " +
                            "from detalle_venta dv " +
                            "inner join venta v " +
                            "on dv.id_venta = v.id " +
                            "inner join producto p " +
                            "on dv.id_producto = p.id " +
                            "inner join usuario u " +
                            "on v.id_usuario = u.id " +
                            "where v.fecha between '" + fecha1 + "' and '" + fecha2 + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[6].TableName);

            ReportDataSource rds = new ReportDataSource("DetalleBalanceDia", con.Tables[6]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
