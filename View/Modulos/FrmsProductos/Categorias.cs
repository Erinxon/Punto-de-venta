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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.ShowDialog();
            llenarTable();
            noSelectTable();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tableCategoria.CurrentRow.Selected)
            {
                EditCategory editCategory = new EditCategory();
                editCategory.id = idSelect();
                editCategory.ShowDialog();
                llenarTable();
                noSelectTable();
            }
            else
            {
                MessageBox.Show("Por favor seleccione uan categoria","Categoria no seleccionada");
            }
               
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            llenarTable();
            this.tableCategoria.ClearSelection();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarTableFiltrada();
        }

        private void llenarTableFiltrada()
        {
            if (!this.textBuscar.Text.Equals(""))
            {
                ICategoria categoria = new GestorCategoria();
                tableCategoria.DataSource = categoria.getCategoriaFiltrada(textBuscar.Text);
            }
            else
            {
                llenarTable();
            }
        }

        private void llenarTable()
        {
            ICategoria categoria = new GestorCategoria();
            tableCategoria.DataSource = categoria.getCategoria();
        }

        private int idSelect()
        {
            return int.Parse(tableCategoria.CurrentRow.Cells[0].Value.ToString());
        }

        private void noSelectTable()
        {
            this.tableCategoria.ClearSelection();
        }
    }
}
