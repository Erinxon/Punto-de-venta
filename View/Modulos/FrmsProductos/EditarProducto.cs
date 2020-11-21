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
    public partial class EditarProducto : Form
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }
        public int idCategoria { get; set; }

        public EditarProducto()
        {
            InitializeComponent();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            cargarDatosCategoria();
            cargarDatosProdcutos();
            tableCategoria.ClearSelection();
        }

        private void cargarDatosCategoria()
        {
            ICategoria categoria = new GestorCategoria();
            tableCategoria.DataSource = categoria.getCategoriaProductos();
            
        }

        private void cargarDatosProdcutos()
        {
            this.textNombre.Text = this.nombre;
            this.textCantidad.Text = this.stock.ToString();
            this.textPrecio.Text = this.precio.ToString();

        }

        private void editarProducto()
        {
            
            IGestorProductos gestorProductos = new GestorProductos(); 
            if(this.textNombre.Text.Equals("") || this.textCantidad.Text.Equals("") || this.textPrecio.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos", "Campo vacio");
            }
            else
            {
                stock = int.Parse(this.textCantidad.Text);
                precio  = decimal.Parse(this.textPrecio.Text);

                if (tableCategoria.CurrentRow.Selected)
                {
                    idCategoria = int.Parse(tableCategoria.CurrentRow.Cells[0].Value.ToString());
                    if (!gestorProductos.validarNombreProducto(this.textNombre.Text) || this.nombre.Equals(this.textNombre.Text))
                    {
                        gestorProductos.editar(this.idProducto, this.textNombre.Text, idCategoria, stock, double.Parse(precio.ToString()));
                        MessageBox.Show("Producto edita correctamente", "Producto editado");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ese producto ya existe", "Nombre de Producto no disponible");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una categoria", "Categoria no seleccionada");
                }
                

              
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            editarProducto();
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
