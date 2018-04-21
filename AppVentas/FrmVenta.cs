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
    public partial class FrmVenta : Form
    {
        private DataTable dtDetalle;
        private Decimal total = 0;
        private bool nuevoRegistro = true;
        private DataGridViewRow fila;
        private bool nuevoCliente = false;
        private int id_usuario = -1;
        private RepRecibo recibo = new RepRecibo();
        private int porcentaje_descuento = 0;
        private List<Object> precios;

        public FrmVenta(int id)
        {
            InitializeComponent();
            CrearTabla();
            txtTotal.Text = total.ToString("#0.00#");
            txtDescuento.Text = total.ToString("#0.00#");
            id_usuario = id;
        }

        private void CargarPrecios(decimal valor_venta, decimal valor_mayorista)
        {
            precios = new List<object>();
            precios.Add(new { Id = valor_venta, Value = valor_venta });
            precios.Add(new { Id = valor_mayorista, Value = valor_mayorista });
            cmbPrecios.DataSource = precios;
            cmbPrecios.ValueMember = "Id";
            cmbPrecios.DisplayMember = "Value";
        }

        private void CrearTabla()
        {
            dtDetalle = new DataTable("Detalle");
            dtDetalle.Columns.Add("Código", Type.GetType("System.String"));
            dtDetalle.Columns.Add("Producto", Type.GetType("System.String"));
            dtDetalle.Columns.Add("Cantidad", Type.GetType("System.Int32"));
            dtDetalle.Columns.Add("Precio", Type.GetType("System.Decimal"));
            dtDetalle.Columns.Add("Subtotal", Type.GetType("System.Decimal"));

            dgvVenta.DataSource = dtDetalle;
        }

        private void BuscarProducto()
        {
            string codigo_producto = txtCodigoProducto.Text;
            try
            {
                DataTable consulta = this.productoTableAdapter.DTBuscarProducto(codigo_producto);
                DataRow fila = consulta.Rows[0];

                decimal valor_venta, valor_mayorista;

                txtNombre.Text = fila["nombre_producto"].ToString();
                txtDescripcion.Text = fila["descripcion"].ToString();
                txtStock.Text = fila["stock"].ToString();
                valor_venta = Convert.ToDecimal(fila["valor_venta"].ToString());
                if (fila["valor_mayorista"].ToString() == "")
                {
                    valor_mayorista = valor_venta;
                }
                else
                {
                    valor_mayorista = Convert.ToDecimal(fila["valor_mayorista"].ToString());
                }
                CargarPrecios(valor_venta, valor_mayorista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no existe\n" + ex.Message);
            }
        }

        private void AgregarProducto()
        {
            if (dgvVenta.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvVenta.Rows)
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
                    decimal precio = Convert.ToDecimal(cmbPrecios.Text);
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
            //txtPrecio.ResetText();
            cmbPrecios.DataSource = null;
            txtCantidad.ResetText();

            txtCodigoProducto.Focus();
        }

        private void LimpiarCamposCliente()
        {
            txtNITCI.ResetText();
            txtNombreCliente.ResetText();
            cmbTipoCliente.SelectedIndex = 0;
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
                cmbPrecios.Focus();
                txtCantidad.Text = "1";
                //SendKeys.Send("{TAB}");
                //e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnBuscarProducto.PerformClick();
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

        private void dgvVenta_DoubleClick(object sender, EventArgs e)
        {
            string codigo_producto = dgvVenta.CurrentRow.Cells[0].Value.ToString();
            string nombre_producto = dgvVenta.CurrentRow.Cells[1].Value.ToString();
            int cantidad = Convert.ToInt32(dgvVenta.CurrentRow.Cells[2].Value.ToString());
            decimal precio = Convert.ToDecimal(dgvVenta.CurrentRow.Cells[3].Value.ToString());
            decimal subtotal = Convert.ToDecimal(dgvVenta.CurrentRow.Cells[4].Value.ToString());

            total -= subtotal;

            int nueva_cantidad = Convert.ToInt32(Interaction.InputBox("Ingrese la nueva cantidad", "Modificar cantidad", cantidad.ToString()));

            int filaActual = dgvVenta.CurrentRow.Index;

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

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (dgvVenta.RowCount <= 0)
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
                    decimal descuento = Convert.ToDecimal(txtDescuento.Text);
                    FrmPagado frm = new FrmPagado(total - descuento);
                    frm.ShowDialog();
                    decimal importe_pagado = frm.Importe_pagado;

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

                        DateTime fecha = DateTime.Now;

                        this.ventaTableAdapter.InsertarVenta(fecha, total, descuento, importe_pagado, "00-00-00-00-00", "", id_cliente, id_usuario);

                        //MessageBox.Show("Venta insertada");

                        int id_venta = Convert.ToInt32(this.ventaTableAdapter.ObtenerID(fecha, total, descuento, importe_pagado, "00-00-00-00-00", "", id_cliente, id_usuario));

                        //MessageBox.Show(id_venta.ToString());

                        //Insertar detalle de venta

                        foreach (DataGridViewRow row in dgvVenta.Rows)
                        {
                            string codigo_producto = row.Cells[0].Value.ToString();
                            string nombre_producto = row.Cells[1].Value.ToString();
                            int cantidad = Convert.ToInt32(row.Cells[2].Value);
                            decimal precio = Convert.ToDecimal(row.Cells[3].Value);
                            decimal subtotal = Convert.ToDecimal(row.Cells[4].Value);

                            int id_producto = Convert.ToInt32(this.productoTableAdapter.ObtenerID(codigo_producto, nombre_producto));

                            this.productoTableAdapter.ActualizarStock(cantidad, id_producto);

                            this.detalle_ventaTableAdapter.InsertarDetalleVenta(id_producto, precio, cantidad, subtotal, id_venta);
                        }

                        DialogResult confirmacion = MessageBox.Show("¿Desea imprimir el recibo?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmacion == DialogResult.Yes)
                        {
                            //Imprimir recibo
                            string numero_nit = "10381527";
                            recibo.Imprimir(txtNITCI.Text, txtNombreCliente.Text, fecha.ToString(), id_venta.ToString().PadLeft(7, '0'), numero_nit, id_venta);
                        }

                        //Limpiar datos del cliente
                        LimpiarCamposCliente();

                        //Limpiar datos de productos en venta;
                        LimpiarDetalle();

                        //Reiniciar el total de la venta a 0
                        total = 0;
                        txtTotal.Text = total.ToString("#0.00#");
                        txtDescuento.Text = total.ToString("#0.00#");
                    }
                }
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.tipo_cliente' Puede moverla o quitarla según sea necesario.
            this.tipo_clienteTableAdapter.Fill(this.dbsisventasDataSet.tipo_cliente);

        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCliente.Text.Equals("Preferencial"))
            {
                if (txtNITCI.Text.Equals("") || txtNombreCliente.Text.Equals(""))
                {
                    MessageBox.Show("Complete los datos del cliente antes de comprobar el código");
                }
                else
                {
                    string codigo_descuento = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el código de descuento del cliente", "Descuento", "");

                    int id_cliente = Convert.ToInt32(this.clienteTableAdapter.ComprobarCodigo(codigo_descuento, txtNITCI.Text, txtNombreCliente.Text));

                    if (id_cliente != 0)
                    {
                        porcentaje_descuento = Convert.ToInt32(cmbTipoCliente.SelectedValue);

                        txtDescuento.Text = ((total * porcentaje_descuento) / 100).ToString("#0.00#");
                    }
                    else
                    {
                        MessageBox.Show("El código es incorrecto");
                        cmbTipoCliente.SelectedIndex = 0;
                    }
                }
            }
        }
    }
}
