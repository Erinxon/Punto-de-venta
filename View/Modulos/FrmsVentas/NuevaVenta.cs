using Punto_de_venta.Controller.CClientes;
using Punto_de_venta.Controller.CProductos;
using Punto_de_venta.Controller.CVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.View.Modulos.FrmsVentas
{
    public partial class NuevaVenta : Form
    {
        public string usuario { get; set; }
        private int idUsuario;
        private List<ListProductos> productos = new List<ListProductos>();
        private IGestionClientes gestionClientes = new GestionClientes();
        private IGestorProductos gestorProductos = new GestorProductos();
        private IGestionVentas gestionVentas = new GestionVentas();
        private double totalDineriProducto;
        public NuevaVenta()
        {
            InitializeComponent();
            
        }

        private void setIDUsuario()
        {
            this.idUsuario = gestionVentas.getIdUsuario(this.usuario);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

            if (this.textIdCliente.Text.Equals(""))
            {
                MessageBox.Show("El campo cliente es requerido", "Campo vacio");

            }else if (!gestionClientes.validarIDCliente(int.Parse(this.textIdCliente.Text)))
            {
                MessageBox.Show("El cliente que selecciono no existe", "Cliente no encontrado");
            }
            else
            {
                if (productos.Count > 0)
                {          
                    gestionVentas.nuevaVenta(gestionVentas.getLastIdVenta(), DateTime.Now, int.Parse(this.textIdCliente.Text), this.idUsuario);
                    gestionVentas.detalleventa(productos);
                    MessageBox.Show("Venta realizada con correctamente", "Venta realizada");
                    limpiar();

                }
            }

           
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            llenarTablaProductosAdd();
            llenarTableCliente();
            llenarTablaProducto();
            setIDUsuario();
        }

        private void llenarTableCliente()
        {
            
            this.tableClientes.DataSource = gestionClientes.getClientesVentas();
        }

        private void llenarTableClienteFiltrado()
        {
            if (!this.textBuscarCliente.Text.Equals(""))
            {
                this.tableClientes.DataSource = gestionClientes.getClientesVentasFiltrado(textBuscarCliente.Text);
            }
            else
            {
                llenarTableCliente();
            }
            
        }

        private void textBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            llenarTableClienteFiltrado();
        }

        private void textBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            llenarTablaProductoFiltrado();
        }

        private void llenarTablaProducto()
        {
            this.tableProductos.DataSource = gestorProductos.getProductosVenta();
            tableProductos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void llenarTablaProductoFiltrado()
        {
            if (!this.textBuscarProducto.Text.Equals(""))
            {
                this.tableProductos.DataSource = gestorProductos.getProductosFiltradosVenta(textBuscarProducto.Text);
            }
            else
            {
                llenarTablaProducto();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ListProductos listProductos = new ListProductos();

            if (this.textIDProducto.Text.Equals("") || this.textCantidad.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos", "Campos vacio");
            }
            else
            {
                if (!gestorProductos.validarIdProducto(int.Parse(this.textIDProducto.Text)))
                {
                    MessageBox.Show("Ese producto no existe, intentelo de nuevo", "Producto no encontrado");
                }
                else
                {
                    string nombre = gestorProductos.getProductoEditar(int.Parse(textIDProducto.Text))[0];
                    int stock = int.Parse(gestorProductos.getProductoEditar(int.Parse(textIDProducto.Text))[2]);
                    double precio = double.Parse(gestorProductos.getProductoEditar(int.Parse(textIDProducto.Text))[3]);
                    int cantidad = int.Parse(this.textCantidad.Text);
                    double total = precio * cantidad;

                    if (validarProductoAdd(int.Parse(this.textIDProducto.Text)))
                    {
                        MessageBox.Show("Ya ese producto esta agregado en la cesta", "Error: Producto agregado");
                    }else if (cantidad > stock)
                    {
                        MessageBox.Show("No hay suficiente stock para este producto, " + 
                            "el stock del producto seleccionado es de " +stock.ToString(), "No hay suficiente stock");
                    }
                    else
                    {
                        listProductos.ID = int.Parse(textIDProducto.Text);
                        listProductos.Nombre = nombre;
                        listProductos.Cantidad = cantidad;
                        listProductos.Precio = precio;
                        listProductos.Total = total;
                        this.totalDineriProducto += total;
                        this.labelTotal.Text = "Total: " + this.totalDineriProducto.ToString();
                        productos.Add(listProductos);
                        llenarTablaProductosAdd();
                    }
                }
                               
            }

        }

        private void llenarTablaProductosAdd()
        {
   
             this.tableProductosAdd.DataSource = this.productos.ToArray();
             this.tableProductosAdd.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private bool validarProductoAdd(int id)
        {
            bool validar = false;

            foreach(var item in productos)
            {
                if(item.ID == id)
                {
                    validar = true;
                }
                else
                {
                    validar = false;
                }
            }
            return validar;
        }

        private void limpiar()
        {
            this.productos.Clear();
            this.textBuscarCliente.Text = "";
            this.textCantidad.Text = "";
            this.textIdCliente.Text = "";
            this.textIDProducto.Text = "";
            this.labelCliente.Text = "Cliente: ";
            this.labelTotal.Text = "Total: ";
            llenarTablaProductosAdd();
            llenarTableCliente();
            llenarTablaProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void textIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (!this.textIdCliente.Text.Equals(""))
            {
                string nameCliente = gestionClientes.getClienteEditar(int.Parse(this.textIdCliente.Text))[0];
                string apellidCliente = gestionClientes.getClienteEditar(int.Parse(this.textIdCliente.Text))[1];

                this.labelCliente.Text = "Cliente: " + nameCliente + " " + apellidCliente;
            }
            else
            {
                this.labelCliente.Text = "Cliente: ";
            }
        }

        private void textIDProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textIdCliente_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
