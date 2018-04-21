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
    public partial class FrmCajaInicio : Form
    {
        private int id_usuario;

        public FrmCajaInicio(int id)
        {
            InitializeComponent();
            id_usuario = id;
        }

        private void FrmCajaInicio_Load(object sender, EventArgs e)
        {
            lblFecha.Text += DateTime.Now.ToShortDateString();
            lblUsuario.Text += this.usuarioTableAdapter.ObtenerNombreUsuario(id_usuario);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToShortDateString();
            if (txtMonto.Text.Equals(""))
            {
                MessageBox.Show("Ingrese algún valor para continuar");
            }
            else
            {
                decimal monto_inicial = Convert.ToDecimal(txtMonto.Text);
                if (monto_inicial <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a cero");
                }
                else
                {
                    this.balanceTableAdapter.InicioCaja(fecha, monto_inicial, id_usuario);
                    this.Close();
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
