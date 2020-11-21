using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.Reportes
{
    class ShapeReporte
    {
        public static IReporte getReporte(string tipoReporte)
        {

            if (tipoReporte.Equals("Reporte de Ventas"))
            {
                return new ReporteVenta();
            }
            else if (tipoReporte.Equals("Reporte de Iventario"))
            {
                return new ReporteIventario();
            }
            else if (tipoReporte.Equals("Producto mas ventidos"))
            {
                return new ReporteProducto();
            }
            else
            {
               throw new Exception("Unexpected value: " + tipoReporte);
            }
        }
    }
}
