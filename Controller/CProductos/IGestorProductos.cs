using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CProductos
{
    interface IGestorProductos
    {
        void crear(string nombre, int idCategoria, int stock, double precio);
        void editar(int idProducto,string nombre, int idCategoria, int stock, double precio);
        bool validarNombreProducto(string nombreProducto);
        Array getProductos();
        Array getProductosFiltrados(string nombreProducto);
        string[] getProductoEditar(int id);
        Array getProductosVenta();
        Array getProductosFiltradosVenta(string nombreProducto);
        bool validarIdProducto(int id);

    }
}
