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
    public partial class FrmProveedor : Form
    {
        private bool Nuevo = true;
        private bool Editar = false;
        private int id_editar = 0;
        private int nivel_acceso = 0;

        public FrmProveedor(int acceso)
        {
            InitializeComponent();
            nivel_acceso = acceso;
            Restringir();
        }

        public FrmProveedor(string nombre)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = 1;
            txtNombreEmpresa.Text = nombre;
            txtRepresentante.Focus();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dbsisventasDataSet.proveedor);

            cmbBuscar.SelectedIndex = 0;
            TotalRegistros();
        }

        private void Restringir()
        {
            if (nivel_acceso != 1)
            {
                btnEliminar.Visible = false;
            }
        }

        private void LimpiarCajas()
        {
            txtNombreEmpresa.ResetText();
            txtRepresentante.ResetText();
            txtNITCI.ResetText();
            txtDireccion.ResetText();
            txtTelefono.ResetText();

            txtNombreEmpresa.Focus();
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros: " + dgvProveedor.RowCount;
        }

        private void ActualzarListado()
        {
            this.proveedorTableAdapter.Fill(this.dbsisventasDataSet.proveedor);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtNombreEmpresa.Text.Equals("") || txtRepresentante.Text.Equals("") || txtNITCI.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos");
                }
                else
                {
                    string nombre_empresa = txtNombreEmpresa.Text;
                    string representante = txtRepresentante.Text;
                    string nit_ci = txtNITCI.Text;
                    string direccion = txtDireccion.Text;
                    string telefono = txtTelefono.Text;

                    try
                    {
                        this.proveedorTableAdapter.InsertarProveedor(nombre_empresa, representante, nit_ci, direccion, telefono);
                        MessageBox.Show("Registro guardado correctamente");
                        ActualzarListado();
                        LimpiarCajas();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if (Editar)
                {
                    if (txtNombreEmpresa.Text.Equals("") || txtRepresentante.Text.Equals("") || txtNITCI.Text.Equals("") || txtDireccion.Text.Equals("") || txtTelefono.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                    else
                    {
                        string nombre_empresa = txtNombreEmpresa.Text;
                        string representante = txtRepresentante.Text;
                        string nit_ci = txtNITCI.Text;
                        string direccion = txtDireccion.Text;
                        string telefono = txtTelefono.Text;

                        try
                        {
                            this.proveedorTableAdapter.EditarProveedor(nombre_empresa, representante, nit_ci, direccion, telefono, id_editar);
                            MessageBox.Show("guardado correctamente");
                            ActualzarListado();
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

                    int nro_filas = dgvProveedor.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvProveedor.SelectedRows[i].Cells[0].Value);
                        this.proveedorTableAdapter.EliminarProveedor(id);
                    }

                    MessageBox.Show(nro_filas + " registros fueron eliminados");
                    ActualzarListado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            if (nivel_acceso == 1)
            {
                id_editar = Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value);
                txtNombreEmpresa.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                txtRepresentante.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
                txtNITCI.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvProveedor.CurrentRow.Cells[4].Value.ToString();
                txtTelefono.Text = dgvProveedor.CurrentRow.Cells[5].Value.ToString();

                tabControl1.SelectedIndex = 1;

                Nuevo = true;
                Editar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Nombre Empresa"))
            {
                this.proveedorTableAdapter.BuscarNombreEmpresaProveedor(this.dbsisventasDataSet.proveedor, txtBuscar.Text);
                TotalRegistros();
            }
        }
    }
}
