using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CClientes
{
    interface IGestionClientes
    {
        void crear(string nombre, string apellido, string direccion);
        void editar(int idcliente, string nombre, string apellido, string direccion);
        Array getClientes();
        Array getClientesFiltrada(string nombre);
        string[] getClienteEditar(int id);
        Array getClientesVentas();
        Array getClientesVentasFiltrado(string nombre);
        bool validarIDCliente(int id);

    }
}
