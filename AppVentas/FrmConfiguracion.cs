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
            FrmRepRecibo frm = new FrmRepRecibo("10381527", "Alvaro Navarro", DateTime.Today.ToShortDateString(), "0000001", "10381527");
            frm.Show();
        }
    }
}
