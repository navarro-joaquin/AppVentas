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
    public partial class FrmProducto : Form
    {
        private bool Nuevo = true;
        private bool Editar = true;
        private int id_editar = 0;

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_producto' Puede moverla o quitarla según sea necesario.
            this.vista_productoTableAdapter.Fill(this.dbsisventasDataSet.vista_producto);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dbsisventasDataSet.categoria);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dbsisventasDataSet.proveedor);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.producto' Puede moverla o quitarla según sea necesario.
            // this.productoTableAdapter.Fill(this.dbsisventasDataSet.producto);

            cmbBuscar.SelectedIndex = 0;
            TotalRegistros();
        }

        private void LimpiarCajas()
        {
            txtCodigo.ResetText();
            txtNombreProducto.ResetText();
            txtMarca.ResetText();
            txtValorCompra.ResetText();
            txtValorVenta.ResetText();
            dtpFechaCompra.ResetText();
            dtpFechaVencimiento.ResetText();
            txtStock.ResetText();
            txtStockMinimo.ResetText();
            txtDescripcion.ResetText();

            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.Image = global::AppVentas.Properties.Resources.file;

            cmbProveedor.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;

            txtCodigo.Focus();
        }

        private void TotalRegistros()
        {
            lblTotalRegistros.Text = "Número de Registros: " + dgvProducto.RowCount;
        }

        private void ActualizarListado()
        {
            this.vista_productoTableAdapter.Fill(this.dbsisventasDataSet.vista_producto);
            TotalRegistros();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtNombreProducto.Text.Equals("") || txtMarca.Text.Equals("") || txtValorCompra.Text.Equals("") || txtValorVenta.Text.Equals("") || txtStock.Text.Equals(""))
                {
                    MessageBox.Show("Datos incompletos");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();

                    string codigo = txtCodigo.Text;
                    string nombre_producto = txtNombreProducto.Text;
                    string marca = txtMarca.Text;
                    decimal valor_compra = Convert.ToDecimal(txtValorCompra.Text);
                    decimal valor_venta = Convert.ToDecimal(txtValorVenta.Text);
                    string fecha_compra = dtpFechaCompra.Value.ToShortDateString();
                    string fecha_vencimiento = dtpFechaVencimiento.Value.ToShortDateString();
                    int stock = Convert.ToInt32(txtStock.Text);
                    int stock_minimo = Convert.ToInt32(txtStockMinimo.Text);
                    string descripcion = txtDescripcion.Text;
                    int id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                    int id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                    if (txtCodigo.Text.Equals(""))
                    {
                        try
                        {
                            codigo = this.productoTableAdapter.GenerarCodigo(id_categoria).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error1" + ex.Message);
                        }
                    }

                    try
                    {
                        this.productoTableAdapter.InsertarProducto(codigo, nombre_producto, marca, valor_compra, valor_venta, fecha_compra, fecha_vencimiento, stock, stock_minimo, descripcion, imagen, id_proveedor, id_categoria);
                        MessageBox.Show("Registro guardado correctamente");
                        ActualizarListado();
                        LimpiarCajas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error2" + ex.Message);
                    }
                }
            }
            else
            {
                if (Editar)
                {
                    if (txtNombreProducto.Text.Equals("") || txtMarca.Text.Equals("") || txtValorCompra.Text.Equals("") || txtValorVenta.Text.Equals("") || txtStock.Text.Equals("") || id_editar == 0)
                    {
                        MessageBox.Show("Datos incompletos");
                    }
                    else
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();

                        string codigo = txtCodigo.Text;
                        string nombre_producto = txtNombreProducto.Text;
                        string marca = txtMarca.Text;
                        decimal valor_compra = Convert.ToDecimal(txtValorCompra.Text);
                        decimal valor_venta = Convert.ToDecimal(txtValorVenta.Text);
                        string fecha_compra = dtpFechaCompra.Value.ToShortDateString();
                        string fecha_vencimiento = dtpFechaVencimiento.Value.ToShortDateString();
                        int stock = Convert.ToInt32(txtStock.Text);
                        int stock_minimo = Convert.ToInt32(txtStockMinimo.Text);
                        string descripcion = txtDescripcion.Text;
                        int id_proveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                        int id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                        try
                        {
                            this.productoTableAdapter.EditarProducto(codigo, nombre_producto, marca, valor_compra, valor_venta, fecha_compra, fecha_vencimiento, stock, stock_minimo, descripcion, imagen, id_proveedor, id_categoria, id_editar);
                            MessageBox.Show("guardado correctamente");
                            ActualizarListado();
                            LimpiarCajas();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error3" + ex.Message);
                        }
                    }

                    Nuevo = true;
                    Editar = false;
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

                    int nro_filas = dgvProducto.Rows.GetRowCount(DataGridViewElementStates.Selected);

                    for (int i = 0; i < nro_filas; i++)
                    {
                        id = Convert.ToInt32(dgvProducto.SelectedRows[i].Cells[0].Value);
                        this.productoTableAdapter.EliminarProducto(id);
                    }

                    MessageBox.Show(nro_filas + " registros fueron eliminados");
                    ActualizarListado();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error4" + ex.Message);
                }
            }
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            
            id_editar = Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value);
            txtCodigo.Text = dgvProducto.CurrentRow.Cells[1].Value.ToString();
            txtNombreProducto.Text = dgvProducto.CurrentRow.Cells[2].Value.ToString();
            txtMarca.Text = dgvProducto.CurrentRow.Cells[3].Value.ToString();
            txtValorCompra.Text = dgvProducto.CurrentRow.Cells[4].Value.ToString();
            txtValorVenta.Text = dgvProducto.CurrentRow.Cells[5].Value.ToString();
            dtpFechaCompra.Value = Convert.ToDateTime(dgvProducto.CurrentRow.Cells[6].Value.ToString());
            dtpFechaVencimiento.Value = Convert.ToDateTime(dgvProducto.CurrentRow.Cells[7].Value.ToString());
            txtStock.Text = dgvProducto.CurrentRow.Cells[8].Value.ToString();
            txtStockMinimo.Text = dgvProducto.CurrentRow.Cells[9].Value.ToString();
            txtDescripcion.Text = dgvProducto.CurrentRow.Cells[10].Value.ToString();

            if (dgvProducto.CurrentRow.Cells[11].Value is DBNull)
            {
                pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxImagen.Image = global::AppVentas.Properties.Resources.file;
            }
            else
            {

                byte[] imagenBuffer = (byte[])dgvProducto.CurrentRow.Cells[11].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
                pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxImagen.Image = Image.FromStream(ms);
            }

            cmbProveedor.Text = dgvProducto.CurrentRow.Cells[12].Value.ToString();
            cmbCategoria.Text = dgvProducto.CurrentRow.Cells[13].Value.ToString();

            tabControl1.SelectedIndex = 1;

            Nuevo = false;
            Editar = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pbxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxImagen.Image = global::AppVentas.Properties.Resources.file;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            switch(cmbBuscar.Text)
            {
                case "Código":
                    this.vista_productoTableAdapter.BuscarCodigoProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
                    TotalRegistros();
                    break;
                case "Nombre Producto":
                    this.vista_productoTableAdapter.BuscarNombreProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
                    TotalRegistros();
                    break;
                case "Marca":
                    this.vista_productoTableAdapter.BuscarMarcaProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
                    TotalRegistros();
                    break;
                case "Proveedor":
                    this.vista_productoTableAdapter.BuscarProveedorProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
                    TotalRegistros();
                    break;
                case "Categoría":
                    this.vista_productoTableAdapter.BuscarCategoriaProducto(this.dbsisventasDataSet.vista_producto, txtBuscar.Text);
                    TotalRegistros();
                    break;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                try
                {
                    if (txtCodigo.Text.Equals("") || txtCodigo.Text.Length < 5)
                    {
                        txtCodigo.Text = cmbCategoria.Text.Substring(0, 3).ToUpper() + "-";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error5" + ex.Message);
                }
            }
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (Nuevo)
            {
                if (txtCodigo.Text.Equals(cmbCategoria.Text.Substring(0, 3).ToUpper() + "-"))
                {
                    switch (txtMarca.Text.Length)
                    {
                        case 3:
                            txtCodigo.Text += txtMarca.Text.ToUpper() + "-";
                            break;
                    }
                }
                if (txtMarca.Text.Equals("") && txtCodigo.Text.Length > 5)
                {
                    txtCodigo.Text = txtCodigo.Text.Substring(0, 4);
                }
            }
        }
    }
}
