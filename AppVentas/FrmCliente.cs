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
    public partial class FrmCliente : Form
    {
        bool Nuevo = true;
        bool Editar = false;
        int id_editar = 0;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dbsisventasDataSet.cliente);

            cmbBuscar.SelectedIndex = 0;
            TotalRegistros();
        }

        private void LimpiarCajas()
        {
            txtNombre.ResetText();
            txtNITCI.ResetText();
            txtNombre.Focus();
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros :" + dgvCliente.RowCount;
        }

        private void ActualizarListado()
        {
            this.clienteTableAdapter.Fill(this.dbsisventasDataSet.cliente);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtNombre.Text.Equals("") || txtNITCI.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos");
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string nit_ci = txtNITCI.Text;
                    try
                    {
                        this.clienteTableAdapter.InsertarCliente(nombre, nit_ci);
                        MessageBox.Show("Registro guardado correctamente");
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
                    if (txtNombre.Text.Equals("") || txtNITCI.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                    else
                    {
                        string nombre = txtNombre.Text;
                        string nit_ci = txtNITCI.Text;
                        try
                        {
                            this.clienteTableAdapter.EditarCliente(nombre, nit_ci, id_editar);
                            MessageBox.Show("guardado correctamente");
                            ActualizarListado();
                            LimpiarCajas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                Nuevo = true;
                Editar = false;
                id_editar = 0;
            }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            id_editar = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtNITCI.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            tabControl1.SelectedIndex = 1;
            Editar = true;
            Nuevo = false;
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

                    int nro_filas = dgvCliente.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvCliente.SelectedRows[i].Cells[0].Value);
                        this.clienteTableAdapter.EliminarCliente(id);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Nombre"))
            {
                this.clienteTableAdapter.BuscarNombreCliente(this.dbsisventasDataSet.cliente, txtBuscar.Text);
                TotalRegistros();
            }
            else
            {
                if (cmbBuscar.Text.Equals("NIT/CI"))
                {
                    this.clienteTableAdapter.BuscarNITCliente(this.dbsisventasDataSet.cliente, txtBuscar.Text);
                    TotalRegistros();
                }
            }
        }
    }
}
