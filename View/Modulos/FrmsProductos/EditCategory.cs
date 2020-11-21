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
    public partial class EditCategory : Form
    {
        public int id;
        private string nameCategoria;
        private ICategoria categoria = new GestorCategoria();

        public EditCategory()
        {
            InitializeComponent();
        }

        private void EditCategory_Load(object sender, EventArgs e)
        {
            optenerDatos();
        }

        private void optenerDatos()
        {
            this.textID.Text = this.id.ToString();
            this.textCategoria.Text = categoria.getNombreCategoria(this.id);
            this.nameCategoria = categoria.getNombreCategoria(this.id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.textCategoria.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos","Campo vacio");
            }
            else
            {
                if(!categoria.validarNombre(this.textCategoria.Text) || this.nameCategoria.Equals(this.textCategoria.Text))
                {
                    categoria.editar(this.id, this.textCategoria.Text);
                    MessageBox.Show("Categoria editada correctamente", "Categoria editada");
                }
                else
                {
                    MessageBox.Show("Esa categoria ya existe", "Nombre de categoria no disponible");
                }
                
            }
        }
    }
}
