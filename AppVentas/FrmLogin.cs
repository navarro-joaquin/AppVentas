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
        RegistroCaja registro;
        public FrmLogin()
        {
            InitializeComponent();
            registro = new RegistroCaja();
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
                        registro.InicioCaja(nivel_acceso, id);
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
