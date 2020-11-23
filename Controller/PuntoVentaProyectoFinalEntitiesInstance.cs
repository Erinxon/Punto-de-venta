using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Punto_de_venta.Controller
{
    public class PuntoVentaProyectoFinalEntitiesInstance
    {
        private static PuntoVentaProyectoFinalEntities instance = null;

        protected PuntoVentaProyectoFinalEntitiesInstance() { }

        public static PuntoVentaProyectoFinalEntities getInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PuntoVentaProyectoFinalEntities();
                }

                return instance;
            }
        }
    }
}
