using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.View.Modulos.FrmsClientes;
using Punto_de_venta.Controller.CClientes;

namespace Punto_de_venta.View.Modulos
{
    public partial class Clientes : UserControl
    {
        private IGestionClientes gestionClientes = new GestionClientes();

        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            llenarTable();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (tableClientes.CurrentRow.Selected)
            {
                EditClient editClient = new EditClient();
                editClient.idCliente = getID();
                editClient.nombre = gestionClientes.getClienteEditar(getID())[0];
                editClient.apellido = gestionClientes.getClienteEditar(getID())[1];
                editClient.direccion = gestionClientes.getClienteEditar(getID())[2];
                editClient.ShowDialog();
                llenarTable();
                noSelectTable();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente", "Cliente no seleccionado");
            }
                
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            llenarTable();
        }

        private void llenarTable()
        {
            
            this.tableClientes.DataSource = gestionClientes.getClientes();
        }

        private void llenarTableFiltrada()
        {
            if (!this.textBuscar.Text.Equals(""))
            {
                this.tableClientes.DataSource = gestionClientes.getClientesFiltrada(this.textBuscar.Text);
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
            return int.Parse(tableClientes.CurrentRow.Cells[0].Value.ToString());
        }

        public void noSelectTable()
        {
            this.tableClientes.ClearSelection();
        }

    }
}
