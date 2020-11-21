using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CProductos
{
    public class GestorProductos : IGestorProductos
    {
        PuntoVentaProyectoFinalEntities entities = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public void crear(string nombre, int idCategoria, int stock, double precio)
        {      
            entities.agregarProductos(nombre, stock, precio, idCategoria);
            entities.SaveChanges();
        }

        public void editar(int idProducto, string nombre, int idCategoria, int stock, double precio)
        {
            entities.editarProductos(idProducto, nombre, stock, precio, idCategoria);
            entities.SaveChanges();
        }

        public string[] getProductoEditar(int id)
        {
            string[] listProductos = new string[4];

            var consulta = (from productos in entities.productos
                            where productos.idProducto == id
                            select new
                            {
                                ID = productos.idProducto,
                                Producto = productos.nombreProducto,
                                Categoria = productos.idProducto,
                                Existencia = productos.stock,
                                Precio = productos.precio

                            }
                            ).ToList();

            foreach(var item in consulta)
            {
                listProductos[0] = item.Producto.ToString();
                listProductos[1] = item.Categoria.ToString();
                listProductos[2] = item.Existencia.ToString();
                listProductos[3] = item.Precio.ToString();
            }

            return listProductos;
        }

        public Array getProductos()
        {
            var consulta = (from productos in entities.productos
                            join categoria in entities.categoriaProductos
                            on productos.idCategoria equals categoria.idCategoria
                            select new
                            {
                                ID = productos.idProducto,
                                Producto = productos.nombreProducto,
                                Categoria = categoria.nombreCategoria,
                                Existencia = productos.stock,
                                Precio = productos.precio                                               

                            }
                            ).ToArray();

            return consulta;
        }

        public Array getProductosFiltrados(string nombreProducto)
        {
            var consulta = (from productos in entities.productos
                            join categoria in entities.categoriaProductos
                            on productos.idCategoria equals categoria.idCategoria
                            where productos.nombreProducto.Contains(nombreProducto)
                            select new
                            {
                                ID = productos.idProducto,
                                Producto = productos.nombreProducto,
                                Categoria = categoria.nombreCategoria,
                                Existencia = productos.stock,
                                Precio = productos.precio

                            }
                             ).ToArray();

            return consulta;
        }

        public Array getProductosFiltradosVenta(string nombreProducto)
        {
            var consulta = (from productos in entities.productos
                            join categoria in entities.categoriaProductos
                            on productos.idCategoria equals categoria.idCategoria
                            where productos.nombreProducto.Contains(nombreProducto)
                            select new
                            {
                                ID = productos.idProducto,
                                Producto = productos.nombreProducto,
                                Existencia = productos.stock,
                                Precio = productos.precio

                            }
                            ).ToArray();

            return consulta;
        }

        public Array getProductosVenta()
        {
            var consulta = (from productos in entities.productos
                            join categoria in entities.categoriaProductos
                            on productos.idCategoria equals categoria.idCategoria
                            select new
                            {
                                ID = productos.idProducto,
                                Producto = productos.nombreProducto,
                                Existencia = productos.stock,
                                Precio = productos.precio

                            }
                           ).ToArray();

            return consulta;
        }

        public bool validarNombreProducto(string nombreProducto)
        {
            return entities.productos.Any(x => x.nombreProducto == nombreProducto);
        }

        public bool validarIdProducto(int id)
        {
            return entities.productos.Any(x => x.idProducto == id);
        }

    }


}