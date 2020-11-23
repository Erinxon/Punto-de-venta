using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.ReporteInicio
{
    public class ReporteInicio
    {
        private PuntoVentaProyectoFinalEntities db = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public double getVenta()
        {
            double total = 0;

            foreach(var i in db.reporteInicioVenta())
            {
                if (i.HasValue)
                {
                    total = double.Parse(i.Value.ToString());
                }
                else
                {
                    total = 0;
                }
                
            }
            return total;
        }

        public int getCliente()
        {

            var consulta = (from client in db.clientes
                            select client
                            ).Count();

            return consulta;
        }

        public double getIventario()
        {
            double total = 0;

            foreach (var i in db.reporteInicioIventario())
            {
                if (i.HasValue)
                {
                    total = double.Parse(i.Value.ToString());
                }
                else
                {
                    total = 0;
                }
                
            }

            return total;
        }

        public int getCountProducts()
        {
            var consulta = (from product in db.productos
                            select product
                            ).Count();

            return consulta;
        }

    }
}
