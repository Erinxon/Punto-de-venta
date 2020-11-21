using Punto_de_venta.Controller.CProductos;
using Punto_de_venta.Controller.CProductos.Categorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.View.Modulos.FrmsProductos
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            ICategoria categoria = new GestorCategoria();
            tableCategoria.DataSource = categoria.getCategoriaProductos();
            tableCategoria.ClearSelection();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            addProducto();
        }

        private void addProducto()
        {
            string nombre = this.textNombre.Text;
            string precio = this.textPrecio.Text;
            string cantidad = this.textCantidad.Text;
            int idCategoria = getIdCategoria();
            IGestorProductos gestorProductos = new GestorProductos();

            if (nombre.Equals("") || precio.Equals("") || cantidad.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos","Parece que hay algun campo vacio");
            }
            else if (tableCategoria.CurrentRow.Selected)
            {
                if (gestorProductos.validarNombreProducto(nombre))
                {
                    MessageBox.Show("El nombre de ese producto ya se encuentra agregado\nIntente con otro nombre", 
                                    "Nombre de producto no disponible");
                }
                else
                {
                    gestorProductos.crear(nombre, idCategoria, int.Parse(cantidad), double.Parse(precio));
                    MessageBox.Show("Producto agregado correctamente", "Producto agregado");
                }
               
            }
            else
            {
                MessageBox.Show("Por favor seleccione una categoria", "Categoria no seleccionada");
            }
            


        }

        private int getIdCategoria()
        {
            return int.Parse(tableCategoria.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
