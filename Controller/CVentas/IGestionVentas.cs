using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CVentas
{
    interface IGestionVentas
    {
        void nuevaVenta(int idVenta, DateTime fecha, int idCliente, int idUsuario);
        void detalleventa(List<ListProductos> listProductos);
        int getLastIdVenta();
        bool verificaStock(int idproducto, int stock);
        int getIdUsuario(string usuario);
        Array getVentas();
        Array getVentasFiltrada(string cliente);
    }
}
