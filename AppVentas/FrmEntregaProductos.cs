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
    public partial class FrmEntregaProductos : Form
    {
        int id_usuario;
        int nivel_acceso = 0;

        public FrmEntregaProductos(int id, int acceso)
        {
            InitializeComponent();
            id_usuario = id;
            nivel_acceso = acceso;
        }

        private void FrmEntregaProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.FillByVendedores(this.dbsisventasDataSet.usuario);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dbsisventasDataSet.producto);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_detalle_entrega' Puede moverla o quitarla según sea necesario.
            this.vista_detalle_entregaTableAdapter.FillByID(this.dbsisventasDataSet.vista_detalle_entrega, id_usuario);

            TotalRegistros();
            Restringir();
        }

        private void LimpiarCampos()
        {
            dtpFecha.ResetText();
            cmbNombreProducto.SelectedIndex = 1;
            txtCantidad.ResetText();
            cmbEntregadoA.SelectedIndex = 1;
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros : " + dgvDetalleEntrega.RowCount;
        }

        private void ActualizarListado()
        {
            this.vista_detalle_entregaTableAdapter.FillByID(this.dbsisventasDataSet.vista_detalle_entrega, id_usuario);
            TotalRegistros();
        }

        private void Restringir()
        {
            if (nivel_acceso != 1)
            {
                btnEliminar.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = dtpFecha.Value.ToString("dd-MM-yyyy");
                int id_producto = Convert.ToInt32(cmbNombreProducto.SelectedValue);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int id_entregado_a = Convert.ToInt32(cmbEntregadoA.SelectedValue);

                this.entregaTableAdapter.Insertar(fecha, id_producto, cantidad, id_entregado_a, id_usuario);
                MessageBox.Show("Guardado correctamente");

                LimpiarCampos();

                ActualizarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = dtpFechaBuscar.Value.ToString("dd-MM-yyyy");
                this.vista_detalle_entregaTableAdapter.FillByIDFecha(this.dbsisventasDataSet.vista_detalle_entrega, id_usuario, fecha);
                TotalRegistros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            int id_vendedor = Convert.ToInt32(cmbVendedor.SelectedValue);
            FrmRepDetalleEntrega frm = new FrmRepDetalleEntrega(id_usuario, id_vendedor);
            frm.Show();
        }
    }
}
