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
                    int nivel_acceso = Convert.ToInt32(this.usuarioTableAdapter.GetNivelAcceso(id));
                    if (id != 0)
                    {
                        LimpiarCajas();
                        this.Hide();
                        int id_balance = Convert.ToInt32(this.balanceTableAdapter.ObtenerID(DateTime.Today.ToShortDateString(), id));
                        if (id_balance == 0)
                        {
                            FrmCajaInicio frm = new FrmCajaInicio(id);
                            frm.ShowDialog();
                            Acceso(id, nivel_acceso);
                        }
                        else
                        {
                            Acceso(id, nivel_acceso);
                        }
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

        private void Acceso(int id, int nivel_acceso)
        {
            if (nivel_acceso == 3)
            {
                FrmVistaVendedor frm = new FrmVistaVendedor(id);
                frm.ShowDialog();
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal(id);
                frm.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
