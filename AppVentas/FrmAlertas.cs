using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CodigoControl;

namespace AppVentas
{
    public partial class FrmAlertas : Form
    {
        public FrmAlertas()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void FrmAlertas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_alerta_vencimiento' Puede moverla o quitarla según sea necesario.
            this.vista_alerta_vencimientoTableAdapter.Fill(this.dbsisventasDataSet.vista_alerta_vencimiento);
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_alerta_stock' Puede moverla o quitarla según sea necesario.
            this.vista_alerta_stockTableAdapter.Fill(this.dbsisventasDataSet.vista_alerta_stock);

            if (tabControl1.SelectedIndex == 0)
            {
                lblTitulo.Text = "Listado de productos con bajo stock";
            }

            //MessageBox.Show(CodigoControl.CodigoControl.generateControlCode("7904006306693", "876814", "1665979", "20080519", "35958,60", "zZ7Z]xssKqkEf_6K9uH(EcV+%x+u[Cca9T%+_$kiLjT8(zr3T9b5Fx2xG-D+_EBS"));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                lblTitulo.Text = "Listado de productos con bajo stock";
            }
            else
            {
                if (tabControl1.SelectedIndex == 1)
                {
                    lblTitulo.Text = "Listado de productos con fecha de vencimiento próxima";
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
