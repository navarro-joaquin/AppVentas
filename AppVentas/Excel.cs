using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;

namespace AppVentas
{
    class Excel
    {
        private string no_null(string texto)
        {
            if (texto == null)
            {
                return "";
            }
            else
            {
                return texto;
            }
        }

        public List<EntidadHojaExcel> ToEntidadHojaExcel(string pathDelFicheroExcel)
        {
            var book = new ExcelQueryFactory(pathDelFicheroExcel);
            var resultado = (from row in book.Worksheet("Hoja1")
                             let item = new EntidadHojaExcel
                             {
                                 codigo_producto = no_null(row["Código de Producto"].Cast<string>()),
                                 nombre_producto = no_null(row["Nombre"].Cast<string>()),
                                 marca = no_null(row["Marca"].Cast<string>()),
                                 valor_compra = Convert.ToDecimal(no_null(row["Precio de compra"].Cast<string>())),
                                 valor_venta = Convert.ToDecimal(no_null(row["Precio de venta"].Cast<string>())),
                                 valor_mayorista = Convert.ToDecimal(no_null(row["Precio mayorista"].Cast<string>())),
                                 fecha_introduccion = DateTime.Today,
                                 fecha_vencimiento = Convert.ToDateTime(no_null(row["Fecha de vencimiento"].Cast<string>())),
                                 stock = Convert.ToInt32(no_null(row["Stock"].Cast<string>())),
                                 stock_minimo = Convert.ToInt32(no_null(row["Stock mínimo"].Cast<string>())),
                                 descripcion = no_null(row["Descripción"].Cast<string>()),
                                 proveedor = no_null(row["Proveedor"].Cast<string>()),
                                 categoria = no_null(row["Categoría"].Cast<string>())
                             }
                             select item).ToList();
            book.Dispose();
            return resultado;
        }

    }
}
