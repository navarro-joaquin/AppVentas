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
    public partial class FrmBajas : Form
    {
        public FrmBajas()
        {
            InitializeComponent();
        }

        private void FrmBajas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbsisventasDataSet.vista_bajas' Puede moverla o quitarla según sea necesario.
            this.vista_bajasTableAdapter.Fill(this.dbsisventasDataSet.vista_bajas);

        }
    }
}
