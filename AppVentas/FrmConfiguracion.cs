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
    public partial class FrmConfiguracion : Form
    {
        private RepRecibo recibo = new RepRecibo();

        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRepNuevosProductos rep = new FrmRepNuevosProductos("20-02-2018");
            rep.Show();
        }
    }
}
