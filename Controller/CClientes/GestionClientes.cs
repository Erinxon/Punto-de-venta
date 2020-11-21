using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CClientes
{
    public class GestionClientes : IGestionClientes
    {
        PuntoVentaProyectoFinalEntities entities = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public void crear(string nombre, string apellido, string direccion)
        {
            entities.agregarClientes(nombre, apellido, direccion);
        }

        public void editar(int idcliente, string nombre, string apellido, string direccion)
        {
            entities.editarClientes(idcliente, nombre, apellido, direccion);
        }

        public string[] getClienteEditar(int id)
        {
            string[] listaClientes = new string[3];

            var consulta = (from cliente in entities.clientes
                            where cliente.idClientes == id
                            select new
                            {
                                ID = cliente.idClientes,
                                Nombre = cliente.nombre,
                                Apellido = cliente.apellido,
                                Direccion = cliente.direccion,

                            }
                           ).ToList();

            foreach(var item in consulta)
            {
                listaClientes[0] = item.Nombre.ToString();
                listaClientes[1] = item.Apellido.ToString();
                listaClientes[2] = item.Direccion.ToString();
            }
            return listaClientes;
        }

        public Array getClientes()
        {
            var consulta = (from cliente in entities.clientes
                            select new
                            {
                                ID = cliente.idClientes,
                                Nombre = cliente.nombre,
                                Apellido = cliente.apellido,
                                Direccion = cliente.direccion,
                                Fecha = cliente.fechaAgregado

                            }
                           ).ToArray();

            return consulta;
        }

        public Array getClientesFiltrada(string nombre)
        {
            var consulta = (from cliente in entities.clientes
                            where cliente.nombre.Contains(nombre)
                            select new
                            {
                                ID = cliente.idClientes,
                                Nombre = cliente.nombre,
                                Apellido = cliente.apellido,
                                Direccion = cliente.direccion,
                                Fecha = cliente.fechaAgregado

                            }
                           ).ToArray();

            return consulta;
        }

        public Array getClientesVentas()
        {
            var consulta = (from cliente in entities.clientes
                            select new
                            {
                                ID = cliente.idClientes,
                                Nombre = cliente.nombre + " " + cliente.apellido

                            }
                           ).ToArray();

            return consulta;
        }

        public Array getClientesVentasFiltrado(string nombre)
        {
            var consulta = (from cliente in entities.clientes
                            where cliente.nombre.Contains(nombre)
                            select new
                            {
                                ID = cliente.idClientes,
                                Nombre = cliente.nombre + " " + cliente.apellido
                            }
                           ).ToArray();

            return consulta;
        }

        public bool validarIDCliente(int id)
        {
            return entities.clientes.Any(x => x.idClientes == id);
        }
    }
}
