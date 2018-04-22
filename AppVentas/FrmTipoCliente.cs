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
    public partial class FrmTipoCliente : Form
    {
        bool Nuevo = true;
        bool Editar = false;
        int id_editar = 0;
        int nivel_acceso = 0;

        public FrmTipoCliente(int acceso)
        {
            InitializeComponent();
            nivel_acceso = acceso;
            Restringir();

            this.MaximizeBox = false;
        }

        private void FrmTipoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.tipo_cliente' Puede moverla o quitarla según sea necesario.
            this.tipo_clienteTableAdapter.Fill(this.dbsisventasDataSet.tipo_cliente);

            this.Top = 0;
            this.Left = 0;
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
            txtTipo.ResetText();
            txtPorcentajeDescuento.ResetText();
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros :" + dgvTipoCliente.RowCount;
        }

        private void ActualizarListado()
        {
            this.tipo_clienteTableAdapter.Fill(this.dbsisventasDataSet.tipo_cliente);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtTipo.Text.Equals("") || txtPorcentajeDescuento.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos");
                }
                else
                {
                    string tipo = txtTipo.Text;
                    int porcentaje_descuento = Convert.ToInt32(txtPorcentajeDescuento.Text);

                    try
                    {
                        this.tipo_clienteTableAdapter.InsertarTipoCliente(tipo, porcentaje_descuento);
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
                    if (txtTipo.Text.Equals("") || txtPorcentajeDescuento.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                    else
                    {
                        string tipo = txtTipo.Text;
                        int porcentaje_descuento = Convert.ToInt32(txtPorcentajeDescuento.Text);
                        try
                        {
                            this.tipo_clienteTableAdapter.EditarTipoCliente(tipo, porcentaje_descuento, id_editar);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion;
            confirmacion = MessageBox.Show("¿Desea eliminar los registros seleccionados?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.OK)
            {
                try
                {
                    int id;

                    int nro_filas = dgvTipoCliente.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvTipoCliente.SelectedRows[i].Cells[0].Value);
                        this.tipo_clienteTableAdapter.EliminarTipoCliente(id);
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

        private void dgvTipoCliente_DoubleClick(object sender, EventArgs e)
        {
            if (nivel_acceso == 1)
            {
                id_editar = Convert.ToInt32(dgvTipoCliente.CurrentRow.Cells[0].Value);
                txtTipo.Text = dgvTipoCliente.CurrentRow.Cells[1].Value.ToString();
                txtPorcentajeDescuento.Text = dgvTipoCliente.CurrentRow.Cells[2].Value.ToString();
                tabControl1.SelectedIndex = 1;
                Editar = true;
                Nuevo = false;
            }
        }
    }
}
