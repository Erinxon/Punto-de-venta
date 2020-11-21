using Punto_de_venta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Controller.CProductos.Categorias
{
    public class GestorCategoria : ICategoria
    {
        private PuntoVentaProyectoFinalEntities db = PuntoVentaProyectoFinalEntitiesInstance.getInstance;

        public GestorCategoria()
        {

        }

        public void crear(string nombreCategoria)
        {
            db.crearCategorias(nombreCategoria);
            db.SaveChanges();
        }

        public void editar(int id, string nombreCategoria)
        {
            db.editarCategorias(id,nombreCategoria);
            db.SaveChanges();
        }

        public Array getCategoria()
        {
            var consulta = (from categoria in db.categoriaProductos 
                            join producto in db.productos
                            on categoria.idCategoria equals producto.idCategoria into count
                            select new
                            {
                                ID = categoria.idCategoria,
                                Categoria = categoria.nombreCategoria,
                                NumerosProductos = count.Count()          

                            }
                            ).ToArray();

            return consulta;
        }

        public Array getCategoriaFiltrada(string nameCategoria)
        {
            var consulta = (from categoria in db.categoriaProductos
                            join producto in db.productos
                            on categoria.idCategoria equals producto.idCategoria into count
                            where categoria.nombreCategoria.Contains(nameCategoria)
                            select new
                            {
                                ID = categoria.idCategoria,
                                Categoria = categoria.nombreCategoria,
                                NumerosProductos = count.Count()

                            }
                            ).ToArray();

            return consulta;
        }

        public Array getCategoriaProductos()
        {
            var consulta = (from categoria in db.categoriaProductos
                            select new
                            {
                                ID = categoria.idCategoria,
                                Categoria = categoria.nombreCategoria
                            }
                            ).ToArray();

            return consulta;
        }

        public string getNombreCategoria(int id)
        {
            var consulta = (from categoria in db.categoriaProductos
                            where categoria.idCategoria == id
                            select new
                            {
                                nombre = categoria.nombreCategoria

                            }).Single().nombre;

            return consulta.ToString();

        }

        public bool validarID(int id)
        {
            return db.categoriaProductos.Any(x => x.idCategoria == id);
        }

        public bool validarNombre(string nombre)
        {
            return db.categoriaProductos.Any(x => x.nombreCategoria == nombre);
        }

        
    }
}
