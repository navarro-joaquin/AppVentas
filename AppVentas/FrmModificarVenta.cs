﻿using System;
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
    public partial class FrmModificarVenta : Form
    {
        //DataTable que carga los productos anteriormente vendidos
        private DataTable dtDetalle;
        //Variable donde se almacena el total de la venta realizada
        private Decimal total = 0;
        //Bandera que sirve para el registro de nuevos productos en el grid de venta
        private bool nuevoRegistro = true;
        //Fila para agregar en el grid de productos en venta
        private DataGridViewRow fila;
        //Bandera para la insercion de nuevos clientes a base de datos
        private bool nuevoCliente = true;
        //Variable que contiene el id del usuario logeado en el sistema
        private int id_usuario = -1;
        //Variable que contiene el id de la venta a modificar
        private int venta = 100;
        //Clase para la impresión automática del recibo sin vista previa
        private RepRecibo recibo = new RepRecibo();
        //Variable que contiene el porcentaje de descuento de acuerdo al tipo de cliente
        private int porcentaje_descuento = 0;
        //Lista de objetos que almacena los precios del producto seleccionado
        private List<Object> precios;
        //Bandera evita el cambio accidental de producto al seleccionarlo por nombre (revisar)
        private bool producto = true;

        public FrmModificarVenta(int id, int id_venta, string nit, string nombre)
        {
            InitializeComponent();
            venta = id_venta;
            CrearTabla();
            total = Convert.ToDecimal(this.ventaTableAdapter.ObtenerTotalVenta(venta));
            Decimal descuento = Convert.ToDecimal(this.ventaTableAdapter.ObtenerDescuento(venta));
            txtTotal.Text = total.ToString("#0.00#");
            txtDescuento.Text = descuento.ToString("#0.00#");
            id_usuario = id;
            txtNombreCliente.Text = nombre;
            txtNITCI.Text = nit;
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
            dtDetalle = vista_detalle_ventaTableAdapter.DTBuscarPorVenta(venta);
            
            dtDetalle.Columns.Remove("id");
            dtDetalle.Columns.Remove("id_venta");

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

                cmbNombreProducto.Text = fila["nombre_producto"].ToString();
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
                    string nombre_producto = cmbNombreProducto.Text;
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    decimal precio = Convert.ToDecimal(cmbPrecios.Text);
                    decimal subtotal = cantidad * precio;

                    DataRow filaNueva = dtDetalle.NewRow();
                    filaNueva["codigo"] = codigo_producto;
                    filaNueva["producto"] = nombre_producto;
                    filaNueva["cantidad"] = cantidad;
                    filaNueva["precio"] = precio;
                    filaNueva["subtotal"] = subtotal;

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
                filaNueva["codigo"] = codigo_producto;
                filaNueva["producto"] = nombre_producto;
                filaNueva["cantidad"] = nueva_cantidad;
                filaNueva["precio"] = precio;
                filaNueva["subtotal"] = subtotal;

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
                if (nit_ci.Equals("0"))
                {
                    txtNombreCliente.Text = "Sin nombre";
                    txtNombreCliente.Focus();
                    nuevoCliente = true;
                }
                else
                {
                    string nombre = this.clienteTableAdapter.ObtenerNombre(nit_ci);

                    if (!nombre.Equals(""))
                    {
                        txtNombreCliente.Text = nombre;
                        txtNombreCliente.Focus();
                        nuevoCliente = false;
                    }
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
            cmbNombreProducto.Text = "";
            txtDescripcion.ResetText();
            txtStock.ResetText();
            cmbPrecios.DataSource = null;
            txtCantidad.ResetText();

            txtCodigoProducto.Focus();
        }

        private void LimpiarCamposCliente()
        {
            txtNITCI.ResetText();
            txtNombreCliente.ResetText();
            if (cmbTipoCliente.Items.Count > 0)
            {
                cmbTipoCliente.SelectedIndex = 0;
            }
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
                producto = true;
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
            txtModCantidad.PerformClick();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente frm = new FrmBuscarCliente();
            frm.ShowDialog();
            txtNITCI.Text = frm.Nit_cliente;
            txtNombreCliente.Text = frm.Nombre_cliente;
            txtNombreCliente.Focus();
            nuevoCliente = false;
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

                            if (txtNITCI.Text.Equals("0"))
                            {
                                nuevoCliente = true;
                            }

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

                        //Eliminar venta anterior

                        ventaTableAdapter.EliminarVenta(venta);

                        //Insertar nueva venta

                        int id_cliente = Convert.ToInt32(this.clienteTableAdapter.ObtenerID(txtNombreCliente.Text, txtNITCI.Text));

                        DateTime fecha = DateTime.Now;

                        this.ventaTableAdapter.InsertarVenta(fecha, total, descuento, importe_pagado, "00-00-00-00-00", "", id_cliente, id_usuario);
                        
                        int id_venta = Convert.ToInt32(this.ventaTableAdapter.ObtenerID(fecha, total, descuento, importe_pagado, "00-00-00-00-00", "", id_cliente, id_usuario));
                        
                        //Insertar nuevo detalle de venta con los datos anteriores y nuevos

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
                            string numero_nit = "7473186019";
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

                        //Cerrar formulario
                        this.Close();
                    }
                }
            }
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.tipo_cliente' Puede moverla o quitarla según sea necesario.
            this.tipo_clienteTableAdapter.Fill(this.dbsisventasDataSet.tipo_cliente);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dbsisventasDataSet.producto);

            cmbNombreProducto.Text = "";

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

        private void cmbNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (producto)
            {
                try
                {
                    string codigo_producto = cmbNombreProducto.SelectedValue.ToString();
                    
                    try
                    {
                        DataTable consulta = this.productoTableAdapter.DTBuscarProducto(codigo_producto);
                        DataRow fila = consulta.Rows[0];

                        decimal valor_venta, valor_mayorista;

                        txtCodigoProducto.Text = fila["codigo"].ToString();
                        txtDescripcion.Text = fila["descripcion"].ToString();
                        txtStock.Text = fila["stock"].ToString();
                        txtCantidad.Text = "1";
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
                        producto = false;
                        txtCantidad.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El producto no existe\n" + ex.Message);
                    }
                }
                catch (Exception) { }
            }
        }

        private void txtModCantidad_Click(object sender, EventArgs e)
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
            filaNueva["codigo"] = codigo_producto;
            filaNueva["producto"] = nombre_producto;
            filaNueva["cantidad"] = nueva_cantidad;
            filaNueva["precio"] = precio;
            filaNueva["subtotal"] = subtotal;

            dtDetalle.Rows.Add(filaNueva);

            total += subtotal;
            txtTotal.Text = total.ToString("#0.00#");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(dgvVenta.CurrentRow.Cells[4].Value.ToString());

            int filaActual = dgvVenta.CurrentRow.Index;
            dtDetalle.Rows.RemoveAt(filaActual);

            total -= subtotal;
            txtTotal.Text = total.ToString("#0.00#");
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            producto = true;
        }
    }
}
