using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas
{
    class EntidadHojaExcel
    {
        public string codigo_producto { get; set; }
        public string nombre_producto { get; set; }
        public string marca { get; set; }
        public decimal valor_compra { get; set; }
        public decimal valor_venta { get; set; }
        public decimal valor_mayorista { get; set; }
        public decimal valor_constructora { get; set; }
        public decimal valor_familia { get; set; }
        public DateTime fecha_introduccion { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public int stock { get; set; }
        public int stock_minimo { get; set; }
        public string descripcion { get; set; }
        public string proveedor { get; set; }
        public string categoria { get; set; }

    }
}
