using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.View.Modulos.FrmsProductos;
using Punto_de_venta.Controller.CProductos;

namespace Punto_de_venta.View.Modulos
{
    public partial class Productos : UserControl
    {

        public Productos()
        {
            InitializeComponent();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
            llenarTable();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tableProductos.CurrentRow.Selected)
            {
                EditarProducto editarProducto = new EditarProducto();
                IGestorProductos gestorProductos = new GestorProductos();
                editarProducto.idProducto = int.Parse(tableProductos.CurrentRow.Cells[0].Value.ToString());
                editarProducto.nombre = gestorProductos.getProductoEditar(getID())[0];
                editarProducto.idCategoria = int.Parse(gestorProductos.getProductoEditar(getID())[1]);
                editarProducto.stock = int.Parse(gestorProductos.getProductoEditar(getID())[2]);
                editarProducto.precio = decimal.Parse(gestorProductos.getProductoEditar(getID())[3]);
                editarProducto.ShowDialog();
                llenarTable();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto","Producto no seleccionado");
            }
            
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.ShowDialog();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            llenarTable();

        }

        private void llenarTable()
        {
            
            IGestorProductos gestorProductos = new GestorProductos();
            this.tableProductos.DataSource = gestorProductos.getProductos();
            this.tableProductos.ClearSelection();

        }

        private void llenarTableFiltrada()
        {
            if (!this.textBuscar.Text.Equals(""))
            {
                IGestorProductos gestorProductos = new GestorProductos();
                this.tableProductos.DataSource = gestorProductos.getProductosFiltrados(textBuscar.Text);
            }
            else
            {
                llenarTable();
            }
            
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarTableFiltrada();
        }

        private int getID()
        {
            return int.Parse(tableProductos.CurrentRow.Cells[0].Value.ToString());
        }

        private void tableProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void noSelectTable()
        {
            this.tableProductos.ClearSelection();
        }
    }
}
