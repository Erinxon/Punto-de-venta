using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CVentas
{
    class GestionVentas : IGestionVentas
    {
        PuntoVentaProyectoFinalEntities entities = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public int idVenta;
        public void nuevaVenta(int idVenta, DateTime fecha, int idCliente, int idUsuario)
        {
            var venta = new ventas();
            venta.idventa = idVenta;
            venta.fecha = fecha;
            venta.idcliente = idCliente;
            venta.idusuario = idUsuario;

            entities.ventas.Add(venta);
            entities.SaveChanges();

            this.idVenta = idVenta;

        }

        public void detalleventa(List<ListProductos> listProductos)
        {
            foreach (var item in listProductos)
            {
                entities.agregarVentaProducto(this.idVenta, item.ID, item.Cantidad, item.Precio);

            }
            entities.SaveChanges();
            this.idVenta = 0;
        }

        public int getLastIdVenta()
        {
            int id = 0;

            if (!entities.ventas.Any())
            {
                id += 1;
            }
            else
            {
                var consulta = entities.ventas
                               .OrderByDescending(x => x.idventa)
                               .First().idventa.ToString();

                id += int.Parse(consulta) + 1;
            }
            return id;

        }

        public bool verificaStock(int idproducto, int stock)
        {
            bool verificar = false;
            var consulta = entities.productos.FirstOrDefault(c => c.idProducto == idproducto);

            if (stock > int.Parse(consulta.stock.ToString()))
            {
                verificar = true;
            }
            else
            {
                verificar = false;
            }

            return verificar;
        }

        public int getIdUsuario(string usuario)
        {
            var consulta = (from user in entities.Usuarios
                            where user.usuario == usuario
                            select new
                            {
                                user.id_usuario
                            }
                           ).Single();


            return int.Parse(consulta.id_usuario.ToString());
        }

        public Array getVentas()
        {
            //return entities.sp_DetalleVentaFiltrada("dd").ToArray();
            return entities.sp_DetalleVenta1().ToArray();
        }

        public Array getVentasFiltrada(string cliente)
        {
            return entities.sp_DetalleVentaFiltrada(cliente).ToArray();

        }
    }
}
