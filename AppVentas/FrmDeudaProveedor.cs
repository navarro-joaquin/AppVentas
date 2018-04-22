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
    public partial class FrmDeudaProveedor : Form
    {
        private bool Nuevo = true;
        private bool Editar = false;
        private int id_editar = 0;
        private int nivel_acceso = 0;

        private string Fecha, Monto_pagado, Monto_restante, Proveedor, Representante;

        private RepPagoDeuda comprobante = new RepPagoDeuda();

        public FrmDeudaProveedor(int acceso)
        {
            InitializeComponent();
            nivel_acceso = acceso;
            Restringir();

            this.MaximizeBox = false;
        }

        private void FrmDeudaProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dbsisventasDataSet.proveedor);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.deuda_proveedor' Puede moverla o quitarla según sea necesario.
            // this.deuda_proveedorTableAdapter.Fill(this.dbsisventasDataSet.deuda_proveedor);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_deuda_proveedor' Puede moverla o quitarla según sea necesario.
            this.vista_deuda_proveedorTableAdapter.Fill(this.dbsisventasDataSet.vista_deuda_proveedor);

            this.Top = 0;
            this.Left = 0;
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
            dtpFecha.ResetText();
            txtMontoTotal.ResetText();
            txtMontoRestante.ResetText();
            txtMontoPagado.ResetText();
            dtpFecha.ResetText();
            dtpFechaProximoPago.ResetText();

            txtMontoTotal.Focus();
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtMontoPagado.Enabled = habilitar;
            dtpFecha.Enabled = habilitar;
            dtpFechaProximoPago.Enabled = habilitar;
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros: " + dgvDeudaProveedor.RowCount;
        }

        private void ActualzarListado()
        {
            this.vista_deuda_proveedorTableAdapter.Fill(this.dbsisventasDataSet.vista_deuda_proveedor);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtMontoTotal.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos");
                }
                else
                {
                    decimal monto_total = Convert.ToDecimal(txtMontoTotal.Text);
                    string fecha = dtpFecha.Value.ToShortDateString();
                    int id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);

                    try
                    {
                        this.deuda_proveedorTableAdapter.IniciarDeuda(fecha, monto_total, id_proveedor);
                        MessageBox.Show("Registro guardado correctamente");
                        ActualzarListado();
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
                    if (txtMontoPagado.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                    else
                    {
                        decimal monto_restante = Convert.ToDecimal(txtMontoRestante.Text);
                        string fecha_proximo_pago = dtpFechaProximoPago.Value.ToShortDateString();
                        decimal monto_pagado = Convert.ToDecimal(txtMontoPagado.Text);
                        int id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);

                        try
                        {
                            this.deuda_proveedorTableAdapter.ConcretarPago(monto_restante, fecha_proximo_pago, monto_pagado, id_editar);
                            MessageBox.Show("guardado correctamente");
                            CargarValoresComprobante();
                            comprobante.Imprimir(Fecha, Monto_pagado, Monto_restante, Proveedor, Representante);
                            this.deuda_proveedorTableAdapter.IniciarDeuda(fecha_proximo_pago, monto_restante, id_proveedor);
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
                    HabilitarCampos(false);
                }
            }
        }

        private void dgvDeudaProveedor_DoubleClick(object sender, EventArgs e)
        {
            Nuevo = false;
            Editar = true;
            HabilitarCampos(true);
            tabControl1.SelectedIndex = 1;
            id_editar = Convert.ToInt32(dgvDeudaProveedor.CurrentRow.Cells[0].Value);
            dtpFecha.Value = Convert.ToDateTime(dgvDeudaProveedor.CurrentRow.Cells[1].Value);
            dtpFechaProximoPago.Value = dtpFecha.Value;
            txtMontoTotal.Text = dgvDeudaProveedor.CurrentRow.Cells[2].Value.ToString();
            cmbProveedor.Text = dgvDeudaProveedor.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtMontoPagado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal monto_total = Convert.ToDecimal(txtMontoTotal.Text);
                decimal monto_pagado = Convert.ToDecimal(txtMontoPagado.Text);

                decimal monto_restante = monto_total - monto_pagado;

                if (txtMontoPagado.Text.Equals(""))
                {
                    monto_restante = monto_total;
                }
                txtMontoRestante.Text = monto_restante.ToString();
            }
            catch (Exception) { }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Proveedor"))
            {
                this.vista_deuda_proveedorTableAdapter.BuscarProveedor(this.dbsisventasDataSet.vista_deuda_proveedor, txtBuscar.Text);
            }
        }

        private void CargarValoresComprobante()
        {
            Fecha = dgvDeudaProveedor.CurrentRow.Cells[1].Value.ToString();
            Monto_pagado = txtMontoPagado.Text;
            Monto_restante = txtMontoRestante.Text;
            Proveedor = dgvDeudaProveedor.CurrentRow.Cells[6].Value.ToString();
            Representante = dgvDeudaProveedor.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
