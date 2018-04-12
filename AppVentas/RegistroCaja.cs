using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;

namespace AppVentas
{
    class RegistroCaja
    {
        decimal monto_inicial = Convert.ToDecimal(File.ReadAllText(@"Caja.txt"));

        public void InicioCaja(int nivel_acceso, int id)
        {
            string monto_recibido = "";

            while (monto_inicial <= 0)
            {
                monto_recibido = Interaction.InputBox("Monto:", "Inicio de Caja", monto_inicial.ToString());
            }
            File.WriteAllText(@"Caja.txt", monto_recibido);

            if (nivel_acceso == 3)
            {
                FrmVistaVendedor frm = new FrmVistaVendedor(id);
                frm.ShowDialog();
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal(id);
                frm.ShowDialog();
            }
        }

        public void CierreDia()
        {

        }

    }
}
