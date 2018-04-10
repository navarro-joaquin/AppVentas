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
    public partial class FrmPrincipal : Form
    {
        int id_usuario;
        int nivel_acceso;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(int id)
        {
            InitializeComponent();
            id_usuario = id;
            nivel_acceso = Convert.ToInt32(this.usuarioTableAdapter.GetNivelAcceso(id_usuario));
            Acceso(nivel_acceso);
        }

        private void Acceso(int acceso)
        {
            switch(acceso)
            {
                case 1:
                    toolStripStatusLabel.Text = "Administrador";
                    break;
                case 2:
                    toolStripStatusLabel.Text = "Almacenero";
                    MnuVentas.Visible = false;
                    MnuProformas.Visible = false;
                    MnuPersonas.Visible = false;
                    MnuHerramientas.Visible = false;
                    MnuItemVentasDia.Visible = false;
                    MnuItemVentasDiaAdm.Visible = false;
                    break;
                case 3:
                    toolStripStatusLabel.Text = "Vendedor";
                    MnuPersonas.Visible = false;
                    MnuAlmacen.Visible = false;
                    MnuItemListadoVentas.Visible = false;
                    MnuItemVentasDiaAdm.Visible = false;
                    MnuItemRepNuevoAlmacen.Visible = false;
                    MnuItemTotalTienda.Visible = false;
                    MnuHerramientas.Visible = false;
                    break;
            }
        }

        private void MnuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuItemHerramientas_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = MnuItemHerramientas.Checked;
        }

        private void MnuItemEstado_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = MnuItemEstado.Checked;
        }

        private void MnuItemCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuItemVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuItemHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MnuItemCerrarTodo_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MnuItemCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria(nivel_acceso);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario(nivel_acceso);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente(nivel_acceso);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor(nivel_acceso);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemProductos_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto(nivel_acceso);
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmAlertas frm = new FrmAlertas();
            frm.ShowDialog();
        }

        private void MnuItemNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta(id_usuario);
            frm.Show();
        }

        private void MnuItemConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();
            frm.Show();
        }

        private void MnuItemListadoVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemRepNuevoAlmacen_Click(object sender, EventArgs e)
        {
            FrmRepNuevosProductos frm = new FrmRepNuevosProductos();
            frm.Show();
        }

        private void MnuItemTotalTienda_Click(object sender, EventArgs e)
        {
            FrmRepTotalTienda frm = new FrmRepTotalTienda();
            frm.Show();
        }

        private void ventasDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRepVentasDia frm = new FrmRepVentasDia(id_usuario);
            frm.Show();
        }

        private void MnuItemVentasDiaAdm_Click(object sender, EventArgs e)
        {
            FrmRepVentasDiaAdm frm = new FrmRepVentasDiaAdm();
            frm.Show();
        }

        private void MnuItemTipoCliente_Click(object sender, EventArgs e)
        {
            FrmTipoCliente frm = new FrmTipoCliente(nivel_acceso);
            frm.MdiParent = this;
            frm.Show();
        }

        private void MnuItemNuevaProforma_Click(object sender, EventArgs e)
        {
            FrmProforma frm = new FrmProforma(id_usuario);
            frm.Show();
        }

        private void MnuItemListadoProformas_Click(object sender, EventArgs e)
        {
            FrmListadoProformas frm = new FrmListadoProformas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
