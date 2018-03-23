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
    public partial class FrmBuscarCliente : Form
    {
        private string nombre_cliente;
        private string nit_cliente;

        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Nit_cliente { get => nit_cliente; set => nit_cliente = value; }

        public FrmBuscarCliente()
        {
            InitializeComponent();
            cmbBuscar.SelectedIndex = 0;
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dbsisventasDataSet.cliente);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("NIT/CI"))
            {
                this.clienteTableAdapter.BuscarNITCliente(this.dbsisventasDataSet.cliente, txtBuscar.Text);
            }
            else
            {
                if (cmbBuscar.Text.Equals("Nombre"))
                {
                    this.clienteTableAdapter.BuscarNombreCliente(this.dbsisventasDataSet.cliente, txtBuscar.Text);
                }
            }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            Nit_cliente = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            Nombre_cliente = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }
    }
}
