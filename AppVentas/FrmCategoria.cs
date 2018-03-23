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
    public partial class FrmCategoria : Form
    {
        bool Nuevo = true;
        bool Editar = false;
        int id_editar = 0;

        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dbsisventasDataSet.categoria);

            cmbBuscar.SelectedIndex = 0;
            TotalRegistros();
        }

        private void LimpiarCajas()
        {
            txtNombre.ResetText();
            txtCodigo.ResetText();
            txtNombre.Focus();
        }

        private void TotalRegistros()
        {
            lblRegistros.Text = "Número de Registros: " + dgvCategoria.RowCount;
        }

        private void ActualizarListado()
        {
            this.categoriaTableAdapter.Fill(this.dbsisventasDataSet.categoria);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos");
                    txtNombre.Focus();
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string codigo = txtCodigo.Text;
                    try
                    {
                        this.categoriaTableAdapter.InsertarCategoria(nombre, codigo);
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
                    if (txtNombre.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Datos incompletos");
                        txtNombre.Focus();
                    }
                    else
                    {
                        string nombre = txtNombre.Text;
                        string codigo = txtCodigo.Text;
                        try
                        {
                            this.categoriaTableAdapter.EditarCategoria(nombre, codigo, id_editar);
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

        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            id_editar = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            txtCodigo.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();

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

                    int nro_filas = dgvCategoria.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvCategoria.SelectedRows[i].Cells[0].Value);
                        this.categoriaTableAdapter.EliminarCategoria(id);
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
                this.categoriaTableAdapter.BuscarNombreCategoria(this.dbsisventasDataSet.categoria, txtBuscar.Text);
                TotalRegistros();
            }
            else
            {
                if (cmbBuscar.Text.Equals("Código"))
                {
                    this.categoriaTableAdapter.BuscarCodigoCategoria(this.dbsisventasDataSet.categoria, txtBuscar.Text);
                    TotalRegistros();
                }
            }
        }
    }
}
