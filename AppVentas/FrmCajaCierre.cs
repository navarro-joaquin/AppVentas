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
    public partial class FrmCajaCierre : Form
    {
        private int id_usuario;
        private decimal total_ventas = 0;
        private int id_balance = 0;
        private bool cierre_correcto = false;

        public bool Cierre_correcto { get => cierre_correcto; set => cierre_correcto = value; }

        public FrmCajaCierre(int id)
        {
            InitializeComponent();
            id_usuario = id;
        }

        private void FrmCajaCierre_Load(object sender, EventArgs e)
        {
            lblFecha.Text += DateTime.Now.ToShortDateString();
            lblUsuario.Text += this.usuarioTableAdapter.ObtenerNombreUsuario(id_usuario);
            id_balance = Convert.ToInt32(this.balanceTableAdapter.ObtenerID(DateTime.Now.ToShortDateString(), id_usuario));
            decimal monto_inicial = Convert.ToDecimal(this.balanceTableAdapter.ObtenerMontoInicial(id_balance));
            lblInicial.Text += monto_inicial.ToString("#0.00#") + " Bs.";

            DateTime fecha1 = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 00:00:00");
            DateTime fecha2 = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 23:59:59");

            total_ventas = Convert.ToDecimal(this.ventaTableAdapter.ObtenerTotalVentas(fecha1, fecha2, id_usuario));

            lblTotalVentas.Text += total_ventas.ToString("#0.00#") + " Bs.";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text.Equals(""))
            {
                MessageBox.Show("Introduzca un monto antes de continuar");
            }
            else
            {
                decimal monto_final = Convert.ToDecimal(txtMonto.Text);
                this.balanceTableAdapter.CierreCaja(DateTime.Now, monto_final, id_balance);
                MessageBox.Show("Cierre de Caja realizado correctamente!");
                Cierre_correcto = true;
                this.Close();
            }
        }
    }
}
