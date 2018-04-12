using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentas
{
    public partial class FrmDetalleVenta : Form
    {
        private int id_venta;
        private string nit_cliente;
        private string nombre_cliente;
        private decimal descuento_venta;

        public FrmDetalleVenta(int id, string nit, string nombre, decimal descuento)
        {
            InitializeComponent();
            id_venta = id;
            nit_cliente = nit;
            nombre_cliente = nombre;
            descuento_venta = descuento;
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                total += Convert.ToDecimal(row.Cells[5].Value);
            }

            txtTotal.Text = total.ToString("#0.00#") + " Bs.";
            txtDescuento.Text = descuento_venta.ToString("#0.00#") + " Bs.";
            decimal total_venta = total - descuento_venta;
            txtTotalVenta.Text = total_venta.ToString("#0.00#") + " Bs.";
        }

        private void DatosCliente()
        {
            txtNITCI.Text = nit_cliente;
            txtNombreCliente.Text = nombre_cliente;
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_detalle_venta' Puede moverla o quitarla según sea necesario.
            //this.vista_detalle_ventaTableAdapter.Fill(this.dbsisventasDataSet.vista_detalle_venta);
            this.vista_detalle_ventaTableAdapter.BuscarPorVenta(this.dbsisventasDataSet.vista_detalle_venta, id_venta);
            CalcularTotal();
            DatosCliente();
        }
    }
}
