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
    public partial class FrmVentas : Form
    {
        private RepRecibo recibo;

        public FrmVentas()
        {
            InitializeComponent();
            recibo = new RepRecibo();

            this.MaximizeBox = false;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_ventas_realizadas' Puede moverla o quitarla según sea necesario.
            this.vista_ventas_realizadasTableAdapter.Fill(this.dbsisventasDataSet.vista_ventas_realizadas);

            this.Top = 0;
            this.Left = 0;
            cmbBuscar.SelectedIndex = 0;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex == 2)
            {
                txtBuscar.Enabled = false;
                dtpFecha.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                txtBuscar.Enabled = true;
                dtpFecha.Enabled = false;
                btnBuscar.Enabled = false;
                txtBuscar.Focus();
                this.vista_ventas_realizadasTableAdapter.Fill(this.dbsisventasDataSet.vista_ventas_realizadas);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Cliente"))
            {
                this.vista_ventas_realizadasTableAdapter.BuscarPorCliente(this.dbsisventasDataSet.vista_ventas_realizadas, txtBuscar.Text);
            }
            else
            {
                if (cmbBuscar.Text.Equals("Vendedor"))
                {
                    this.vista_ventas_realizadasTableAdapter.BuscarPorVendedor(this.dbsisventasDataSet.vista_ventas_realizadas, txtBuscar.Text);
                }
            }
        }

        private void dgvVentas_DoubleClick(object sender, EventArgs e)
        {
            int id_venta = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value);
            string nit_cliente = dgvVentas.CurrentRow.Cells[6].Value.ToString();
            string nombre_cliente = dgvVentas.CurrentRow.Cells[7].Value.ToString();
            decimal descuento = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[4].Value);
            FrmDetalleVenta frm = new FrmDetalleVenta(id_venta, nit_cliente, nombre_cliente, descuento);
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha_buscar = dtpFecha.Value.ToShortDateString();

            this.vista_ventas_realizadasTableAdapter.BuscarPorFecha(this.dbsisventasDataSet.vista_ventas_realizadas, fecha_buscar);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string nit_cliente = dgvVentas.CurrentRow.Cells[6].Value.ToString();
            string nombre_cliente = dgvVentas.CurrentRow.Cells[7].Value.ToString();
            string fecha_venta = dgvVentas.CurrentRow.Cells[2].Value.ToString();
            string numero_recibo = dgvVentas.CurrentRow.Cells[1].Value.ToString().PadLeft(7, '0');
            string numero_nit = "10381527";
            int id_venta = Convert.ToInt32(dgvVentas.CurrentRow.Cells[0].Value.ToString());

            recibo.Imprimir(nit_cliente, nombre_cliente, fecha_venta, numero_recibo, numero_nit, id_venta);
        }
    }
}
