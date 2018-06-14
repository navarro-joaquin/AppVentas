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
    public partial class FrmListadoProformas : Form
    {
        RepProforma proforma;
        RepCaracteristicasProforma caracteristicas;

        public FrmListadoProformas()
        {
            InitializeComponent();
            proforma = new RepProforma();
            caracteristicas = new RepCaracteristicasProforma();

            this.MaximizeBox = false;
        }

        private void FrmListadoProformas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_proformas_realizadas' Puede moverla o quitarla según sea necesario.
            this.vista_proformas_realizadasTableAdapter.Fill(this.dbsisventasDataSet.vista_proformas_realizadas);

            this.Top = 0;
            this.Left = 0;
            cmbBuscar.SelectedIndex = 0;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex == 2)
            {
                txtBuscar.Enabled = false;
                dtpFecha.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                txtBuscar.Enabled = true;
                dtpFecha.Enabled = false;
                btnBuscar.Enabled = false;
                txtBuscar.Focus();
                this.vista_proformas_realizadasTableAdapter.Fill(this.dbsisventasDataSet.vista_proformas_realizadas);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Cliente"))
            {
                this.vista_proformas_realizadasTableAdapter.BuscarPorCliente(this.dbsisventasDataSet.vista_proformas_realizadas, txtBuscar.Text);
            }
            else
            {
                if (cmbBuscar.Text.Equals("Vendedor"))
                {
                    this.vista_proformas_realizadasTableAdapter.BuscarPorVendedor(this.dbsisventasDataSet.vista_proformas_realizadas, txtBuscar.Text);
                }
            }
        }

        private void dgvProformas_DoubleClick(object sender, EventArgs e)
        {
            string nit_cliente = dgvProformas.CurrentRow.Cells[4].Value.ToString();
            string nombre_cliente = dgvProformas.CurrentRow.Cells[5].Value.ToString();
            string fecha_proforma = dgvProformas.CurrentRow.Cells[2].Value.ToString();
            string numero_proforma = dgvProformas.CurrentRow.Cells[1].Value.ToString().PadLeft(7, '0');
            string numero_nit = "7473186019";
            int id_proforma = Convert.ToInt32(dgvProformas.CurrentRow.Cells[0].Value.ToString());

            proforma.Imprimir(nit_cliente, nombre_cliente, fecha_proforma, numero_proforma, numero_nit, id_proforma);
            caracteristicas.Imprimir(fecha_proforma, id_proforma);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha_buscar = dtpFecha.Value.ToShortDateString();

            this.vista_proformas_realizadasTableAdapter.BuscarPorFecha(this.dbsisventasDataSet.vista_proformas_realizadas, fecha_buscar);
        }
    }
}
