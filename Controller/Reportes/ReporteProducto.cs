using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.Reportes
{
    class ReporteProducto : IReporte
    {
        public Array reporte()
        {
            PuntoVentaProyectoFinalEntities entities = PuntoVentaProyectoFinalEntitiesInstance.getInstance;
            return entities.reporteProductosMasVendidos2().ToArray();
        }
    }
}
