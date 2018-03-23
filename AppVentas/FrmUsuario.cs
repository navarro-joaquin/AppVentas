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
    public partial class FrmUsuario : Form
    {
        private List<Object> accesos;
        private bool Nuevo = true;
        private bool Editar = false;
        private int id_editar = 0;

        public FrmUsuario()
        {
            InitializeComponent();

            accesos = new List<object>();
            accesos.Add(new { Id = "1", Value = "Administrador" });
            accesos.Add(new { Id = "2", Value = "Almacenero" });
            accesos.Add(new { Id = "3", Value = "Vendedor" });
            cmbNivelAcceso.DataSource = accesos;
            cmbNivelAcceso.ValueMember = "Id";
            cmbNivelAcceso.DisplayMember = "Value";
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dbsisventasDataSet.usuario);

            cmbBuscar.SelectedIndex = 0;
            TotalRegistros();
        }

        private void LimpiarCajas()
        {
            txtNombres.ResetText();
            txtApellidos.ResetText();
            txtCI.ResetText();
            txtTelefono.ResetText();
            txtDireccion.ResetText();
            cmbNivelAcceso.SelectedIndex = 1;
            txtUsuario.ResetText();
            txtContraseña.ResetText();

            txtNombres.Focus();
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros: " + dgvUsuarios.RowCount;
        }

        private void ActualizarListado()
        {
            this.usuarioTableAdapter.Fill(this.dbsisventasDataSet.usuario);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtNombres.Text.Equals("") || txtApellidos.Text.Equals("") || txtCI.Text.Equals("") || txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
                {
                    MessageBox.Show("Introduzca los todos los datos requeridos");
                    txtNombres.Focus();
                }
                else
                {
                    string nombres = txtNombres.Text;
                    string apellidos = txtApellidos.Text;
                    string ci = txtCI.Text;
                    string telefono = txtTelefono.Text;
                    string direccion = txtDireccion.Text;
                    int nivel_acceso = Convert.ToInt32(cmbNivelAcceso.SelectedValue);
                    string usuario = txtUsuario.Text;
                    string contraseña = txtContraseña.Text;

                    try
                    {
                        this.usuarioTableAdapter.InsertarUsuario(nombres, apellidos, ci, telefono, direccion, nivel_acceso, usuario, contraseña);
                        MessageBox.Show("Nuevo registro guardado");
                        ActualizarListado();
                        LimpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (Editar)
                {
                    if (txtNombres.Text.Equals("") || txtApellidos.Text.Equals("") || txtCI.Text.Equals("") || txtUsuario.Text.Equals("") || txtContraseña.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Introduzca los todos los datos requeridos");
                        txtNombres.Focus();
                    }
                    else
                    {
                        string nombres = txtNombres.Text;
                        string apellidos = txtApellidos.Text;
                        string ci = txtCI.Text;
                        string telefono = txtTelefono.Text;
                        string direccion = txtDireccion.Text;
                        int nivel_acceso = Convert.ToInt32(cmbNivelAcceso.SelectedValue);
                        string usuario = txtUsuario.Text;
                        string contraseña = txtContraseña.Text;

                        try
                        {
                            this.usuarioTableAdapter.EditarUsuario(nombres, apellidos, ci, telefono, direccion, nivel_acceso, usuario, contraseña, id_editar);
                            MessageBox.Show("Registro guardado");
                            ActualizarListado();
                            LimpiarCajas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    Nuevo = true;
                    Editar = false;
                    id_editar = 0;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Desea eliminar los registros seleccionados?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.OK)
            {
                try
                {
                    int id;

                    int nro_filas = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvUsuarios.SelectedRows[i].Cells[0].Value);
                        this.usuarioTableAdapter.EliminarUsuario(id);
                    }

                    MessageBox.Show(nro_filas + " registros fueron eliminados");
                    ActualizarListado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            id_editar = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
            txtNombres.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtCI.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            cmbNivelAcceso.SelectedIndex = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[6].Value) - 1;
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();

            tabControl1.SelectedIndex = 1;

            Editar = true;
            Nuevo = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Cédula de Identidad"))
            {
                this.usuarioTableAdapter.BuscarCIUsuario(this.dbsisventasDataSet.usuario, txtBuscar.Text);
                TotalRegistros();
            }
            else
            {
                if (cmbBuscar.Text.Equals("Usuario"))
                {
                    this.usuarioTableAdapter.BuscarUsuarioUsuario(this.dbsisventasDataSet.usuario, txtBuscar.Text);
                    TotalRegistros();
                }
            }
        }
    }
}
