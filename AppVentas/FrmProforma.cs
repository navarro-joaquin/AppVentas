using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AppVentas
{
    public partial class FrmProforma : Form
    {
        private DataTable dtDetalle;
        private Decimal total = 0;
        private bool nuevoRegistro = true;
        private DataGridViewRow fila;
        private bool nuevoCliente = false;
        private int id_usuario = -1;
        private RepProforma proforma = new RepProforma();

        public FrmProforma(int id)
        {
            InitializeComponent();
            CrearTabla();
            txtTotal.Text = total.ToString("#0.00#");
            id_usuario = id;
        }

        private void CrearTabla()
        {
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("Código", Type.GetType("System.String"));
            dtDetalle.Columns.Add("Producto", Type.GetType("System.String"));
            dtDetalle.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Precio", Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("Subtotal", Type.GetType("System.Decimal"));

            dgvProforma.DataSource = dtDetalle;
        }

        private void BuscarProducto()
        {
            string codigo_producto = txtCodigoProducto.Text;
            try
            {
                DataTable consulta = this.productoTableAdapter.DTBuscarProducto(codigo_producto);
                DataRow fila = consulta.Rows[0];

                txtNombre.Text = fila["nombre_producto"].ToString();
                txtDescripcion.Text = fila["descripcion"].ToString();
                txtStock.Text = fila["stock"].ToString();
                txtPrecio.Text = fila["valor_venta"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no existe\n" + ex.Message);
            }
        }

        private void AgregarProducto()
        {
            if (dgvProforma.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvProforma.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(txtCodigoProducto.Text))
                    {
                        nuevoRegistro = false;
                        fila = row;
                        break;
                    }
                }
            }
            if (nuevoRegistro)
            {
                if (Convert.ToInt32(txtStock.Text) >= Convert.ToInt32(txtCantidad.Text))
                {
                    string codigo_producto = txtCodigoProducto.Text;
                    string nombre_producto = txtNombre.Text;
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    decimal precio = Convert.ToDecimal(txtPrecio.Text);
                    decimal subtotal = cantidad * precio;

                    DataRow filaNueva = dtDetalle.NewRow();
                    filaNueva["Código"] = codigo_producto;
                    filaNueva["Producto"] = nombre_producto;
                    filaNueva["Cantidad"] = cantidad;
                    filaNueva["Precio"] = precio;
                    filaNueva["Subtotal"] = subtotal;

                    total += subtotal;
                    txtTotal.Text = total.ToString("#0.00#");

                    dtDetalle.Rows.Add(filaNueva);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se tienen productos suficientes en stock");
                    txtCantidad.Focus();
                }
            }
            else
            {
                string codigo_producto = fila.Cells[0].Value.ToString();
                string nombre_producto = fila.Cells[1].Value.ToString();
                int cantidad = Convert.ToInt32(fila.Cells[2].Value.ToString());
                decimal precio = Convert.ToDecimal(fila.Cells[3].Value.ToString());
                decimal subtotal = Convert.ToDecimal(fila.Cells[4].Value.ToString());

                total -= subtotal;

                int nueva_cantidad = cantidad + Convert.ToInt32(txtCantidad.Text);

                int filaActual = fila.Index;

                dtDetalle.Rows.RemoveAt(filaActual);

                subtotal = nueva_cantidad * precio;

                DataRow filaNueva = dtDetalle.NewRow();
                filaNueva["Código"] = codigo_producto;
                filaNueva["Producto"] = nombre_producto;
                filaNueva["Cantidad"] = nueva_cantidad;
                filaNueva["Precio"] = precio;
                filaNueva["Subtotal"] = subtotal;

                dtDetalle.Rows.Add(filaNueva);

                total += subtotal;
                txtTotal.Text = total.ToString("#0.00#");

                LimpiarCampos();
                nuevoRegistro = true;
            }
        }

        private void BuscarCliente()
        {
            string nit_ci = txtNITCI.Text;
            try
            {
                string nombre = this.clienteTableAdapter.ObtenerNombre(nit_ci);

                if (!nombre.Equals(""))
                {
                    txtNombreCliente.Text = nombre;
                    txtNombreCliente.Focus();
                    nuevoCliente = false;
                }
            }
            catch (Exception)
            {
                txtNombreCliente.Text = "Sin nombre";
                txtNombreCliente.Focus();
                nuevoCliente = true;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigoProducto.ResetText();
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            txtStock.ResetText();
            txtPrecio.ResetText();
            txtCantidad.ResetText();

            txtCodigoProducto.Focus();
        }

        private void LimpiarCamposCliente()
        {
            txtNITCI.ResetText();
            txtNombreCliente.ResetText();
        }

        private void LimpiarDetalle()
        {
            dtDetalle.Clear();
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarProducto();
                txtPrecio.Focus();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnBuscarProducto.PerformClick();
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCantidad.Text = "1";
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AgregarProducto();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto frm = new FrmBuscarProducto();
            frm.ShowDialog();
            txtCodigoProducto.Text = frm.Producto_seleccionado;
            txtCodigoProducto.Focus();
        }

        private void dgvProforma_DoubleClick(object sender, EventArgs e)
        {
            string codigo_producto = dgvProforma.CurrentRow.Cells[0].Value.ToString();
            string nombre_producto = dgvProforma.CurrentRow.Cells[1].Value.ToString();
            int cantidad = Convert.ToInt32(dgvProforma.CurrentRow.Cells[2].Value.ToString());
            decimal precio = Convert.ToDecimal(dgvProforma.CurrentRow.Cells[3].Value.ToString());
            decimal subtotal = Convert.ToDecimal(dgvProforma.CurrentRow.Cells[4].Value.ToString());

            total -= subtotal;

            int nueva_cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la nueva cantidad", "Modificar cantidad", cantidad.ToString()));

            int filaActual = dgvProforma.CurrentRow.Index;

            dtDetalle.Rows.RemoveAt(filaActual);

            subtotal = nueva_cantidad * precio;

            DataRow filaNueva = dtDetalle.NewRow();
            filaNueva["Código"] = codigo_producto;
            filaNueva["Producto"] = nombre_producto;
            filaNueva["Cantidad"] = nueva_cantidad;
            filaNueva["Precio"] = precio;
            filaNueva["Subtotal"] = subtotal;

            dtDetalle.Rows.Add(filaNueva);

            total += subtotal;
            txtTotal.Text = total.ToString("#0.00#");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();
            frm.ShowDialog();
            txtNITCI.Text = frm.Nit_cliente;
            txtNombreCliente.Text = frm.Nombre_cliente;
            txtNombreCliente.Focus();
        }

        private void txtNITCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarCliente();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvProforma.RowCount <= 0)
            {
                MessageBox.Show("Debe existir por lo menos 1 producto en la venta");
                txtCodigoProducto.Focus();
            }
            else
            {
                if (txtNITCI.Text.Equals("") || txtNombreCliente.Text.Equals(""))
                {
                    MessageBox.Show("Debe completar los datos del cliente antes de continuar");
                }
                else
                {
                    decimal importe_pagado = total;

                    if (importe_pagado > 0)
                    {
                        //Insertar o actualizar datos del cliente
                        if (txtNITCI.Text.Equals("") || txtNombreCliente.Text.Equals(""))
                        {
                            MessageBox.Show("Los datos del cliente deben ser completados antes de proceder con la venta");
                        }
                        else
                        {
                            string nit_ci = txtNITCI.Text;
                            string nombre = txtNombreCliente.Text;

                            if (nuevoCliente)
                            {
                                this.clienteTableAdapter.InsertarCliente(nombre, nit_ci);
                            }
                            else
                            {
                                int id = Convert.ToInt32(this.clienteTableAdapter.ObtenerID(nombre, nit_ci));
                                this.clienteTableAdapter.EditarCliente(nombre, nit_ci, id);
                            }
                            nuevoCliente = true;
                        }

                        //Insertar nueva venta

                        int id_cliente = Convert.ToInt32(this.clienteTableAdapter.ObtenerID(txtNombreCliente.Text, txtNITCI.Text));

                        try
                        {
                            this.proformaTableAdapter.InsertarProforma(DateTime.Today.ToShortDateString(), total, id_cliente, id_usuario);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error encontrado con try catch: " + ex.Message);
                        }

                        int id_proforma = Convert.ToInt32(this.proformaTableAdapter.ObtenerID(DateTime.Today.ToShortDateString(), total, id_cliente, id_usuario));

                        //Insertar detalle de venta

                        foreach (DataGridViewRow row in dgvProforma.Rows)
                        {
                            string codigo_producto = row.Cells[0].Value.ToString();
                            string nombre_producto = row.Cells[1].Value.ToString();
                            int cantidad = Convert.ToInt32(row.Cells[2].Value);
                            decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                            decimal subtotal = Convert.ToDecimal(row.Cells[4].Value);

                            int id_producto = Convert.ToInt32(this.productoTableAdapter.ObtenerID(codigo_producto, nombre_producto));

                            //this.productoTableAdapter.ActualizarStock(cantidad, id_producto);

                            this.detalle_proformaTableAdapter.InsertarDetalleProforma(id_producto, precio, cantidad, subtotal, id_proforma);
                        }

                        //Imprimir recibo
                        string numero_nit = "10381527";
                        proforma.Imprimir(txtNITCI.Text, txtNombreCliente.Text, DateTime.Today.ToShortDateString(), id_proforma.ToString().PadLeft(7, '0'), numero_nit, id_proforma);

                        //Limpiar datos del cliente
                        LimpiarCamposCliente();

                        //Limpiar datos de productos en venta;
                        LimpiarDetalle();

                        //Reiniciar el total de la venta a 0
                        total = 0;
                        txtTotal.Text = total.ToString("#0.00#");
                    }
                }
            }
        }

        private void FrmProforma_Load(object sender, EventArgs e)
        {

        }
    }
}
