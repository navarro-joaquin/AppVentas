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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtUsuario.ResetText();
            txtContraseña.ResetText();
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Datos incorrectos");
            }
            else
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                try
                {
                    int id = Convert.ToInt32(this.usuarioTableAdapter.Login(usuario, contraseña));
                    if (id != 0)
                    {
                        LimpiarCajas();
                        FrmPrincipal frm = new FrmPrincipal(id);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                        txtContraseña.ResetText();
                        txtContraseña.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
