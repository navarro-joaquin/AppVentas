﻿using System;
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
    public partial class FrmVistaVendedor : Form
    {
        int id_usuario;

        public FrmVistaVendedor(int id)
        {
            InitializeComponent();
            id_usuario = id;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta(id_usuario);
            frm.Show();
        }

        private void btnCierre_Click(object sender, EventArgs e)
        {
            FrmCajaCierre frm = new FrmCajaCierre(id_usuario);
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProforma_Click(object sender, EventArgs e)
        {
            FrmProforma frm = new FrmProforma(id_usuario);
            frm.Show();
        }
    }
}
