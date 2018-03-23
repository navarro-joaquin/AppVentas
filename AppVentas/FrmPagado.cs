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
    public partial class FrmPagado : Form
    {
        private decimal total_venta;
        private decimal importe_pagado;

        public decimal Total_venta { get => total_venta; set => total_venta = value; }
        public decimal Importe_pagado { get => importe_pagado; set => importe_pagado = value; }

        public FrmPagado(decimal total_venta_)
        {
            InitializeComponent();
            Total_venta = total_venta_;
            txtTotalVenta.Text = Total_venta.ToString("#0.00#");
            lblCambioImporte.Text = Total_venta.ToString("#0.00#");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            decimal importe_pagado_ = Convert.ToDecimal(txtImportePagado.Text);

            if (Importe_pagado < 0)
            {
                MessageBox.Show("El importe no puede ser menor a cero");
            }
            else
            {
                if (importe_pagado_ < Total_venta)
                {
                    MessageBox.Show("El importe no puede ser menor al total de la venta");
                }
                else
                {
                    Importe_pagado = importe_pagado_;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Importe_pagado = 0;
            this.Close();
        }

        private void txtImportePagado_TextChanged(object sender, EventArgs e)
        {
            if (txtImportePagado.Text.Equals(""))
            {
                txtImportePagado.Text = "0.00";
            }
            decimal monto = Convert.ToDecimal(txtImportePagado.Text);
            lblCambioImporte.Text = (Total_venta - monto).ToString("#0.00#");
        }
    }
}
