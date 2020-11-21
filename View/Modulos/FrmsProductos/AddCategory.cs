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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCategoria = this.textCategoria.Text;
            ICategoria categoria = new GestorCategoria();

            if (nombreCategoria.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos", "Campo vacio");
            
            }
            else if (categoria.validarNombre(nombreCategoria))
            {
                MessageBox.Show("Esa categoria ya existe", "Nombre de categoria no disponible");
            }     
            else
            {
                categoria.crear(nombreCategoria);
                MessageBox.Show("Categoria agregada con exito", "Categoria agregada");
                limpiarDatos();
            }   
        }

        private void limpiarDatos()
        {
            this.textCategoria.Text = "";
        }
    }
}
