using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CProductos.Categorias
{
    interface ICategoria
    {
        void crear(string nombreCategoria);
        void editar(int id, string nombreCategoria);
        bool validarNombre(string nombre);
        bool validarID(int id);
        Array getCategoria();
        Array getCategoriaProductos();
        Array getCategoriaFiltrada(string categoria);
        string getNombreCategoria(int id);
    }
}
