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
    public partial class FrmBuscarProducto : Form
    {
        private string producto_seleccionado;

        public string Producto_seleccionado { get; set; }

        public FrmBuscarProducto()
        {
            InitializeComponent();
            cmbBuscar.SelectedIndex = 0;
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_producto' Puede moverla o quitarla según sea necesario.
            this.vista_productoTableAdapter.Fill(this.dbsisventasDataSet.vista_producto);

        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            Producto_seleccionado = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("Código"))
            {
                this.vista_productoTableAdapter.BuscarCodigoProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
            }
            else
            {
                if (cmbBuscar.Text.Equals("Nombre"))
                {
                    this.vista_productoTableAdapter.BuscarNombreProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
                }
            }
        }
    }
}
