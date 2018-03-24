using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;

namespace AppVentas
{
    class RepRecibo
    {
        /** Propiedades para el reporte */
        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        public RepRecibo()
        {

        }

        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.0in</MarginTop>
                <MarginLeft>0.0in</MarginLeft>
                <MarginRight>0.0in</MarginRight>
                <MarginBottom>0.0in</MarginBottom>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }

        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            System.Drawing.Imaging.Metafile pageImage = new
               System.Drawing.Imaging.Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public void Imprimir(string nit_cliente, string nombre_cliente, string fecha_venta, string numero_recibo, string numero_nit, int id_venta)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"RepRecibo.rdlc";

            List<ReportParameter> reportParams = new List<ReportParameter>();
            reportParams.Add(new ReportParameter("NitCliente", nit_cliente));
            reportParams.Add(new ReportParameter("NombreCliente", nombre_cliente));
            reportParams.Add(new ReportParameter("FechaVenta", fecha_venta));
            reportParams.Add(new ReportParameter("NumeroRecibo", numero_recibo));
            reportParams.Add(new ReportParameter("NumeroNit", numero_nit));
            report.SetParameters(reportParams);

            Consultas con = new Consultas();
            string cs = AppVentas.Properties.Settings.Default.dbsisventasConnString;
            SqlConnection cn = new SqlConnection(cs);

            string query = "select p.nombre_producto, dv.cantidad, dv.precio, dv.subtotal, v.total_venta from detalle_venta dv " +
                            "inner join producto p " +
                            "on dv.id_producto = p.id " +
                            "inner join venta v " +
                            "on dv.id_venta = v.id " +
                            "where id_venta = " + id_venta;

            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            da.Fill(con, con.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("Detalle_Venta", con.Tables[0]);

            report.DataSources.Clear();
            report.DataSources.Add(rds);

            report.Refresh();
            Export(report);
            Print();
        }
    }
}
