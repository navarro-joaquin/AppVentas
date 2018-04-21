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
    public partial class FrmRepDeudaProveedores : Form
    {
        public FrmRepDeudaProveedores()
        {
            InitializeComponent();
        }

        private void FrmRepDeudaProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Consultas.DetalleDeudaTotal' Puede moverla o quitarla según sea necesario.
            this.DetalleDeudaTotalTableAdapter.Fill(this.Consultas.DetalleDeudaTotal);

            this.reportViewer1.RefreshReport();

        }
    }
}
