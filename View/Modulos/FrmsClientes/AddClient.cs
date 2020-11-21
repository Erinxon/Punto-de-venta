using Punto_de_venta.Controller.CClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.View.Modulos.FrmsClientes
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = this.textNombre.Text;
            string apellaido = this.textApellido.Text;
            string direccion = this.textDireccion.Text;

            IGestionClientes gestionClientes = new GestionClientes();

            if(nombre.Equals("") || apellaido.Equals("") || direccion.Equals(""))
            {
                MessageBox.Show("Todos los campos son requetidos", "Parece que hay un campo vacio");
            }
            else
            {
                gestionClientes.crear(nombre,apellaido,direccion);
                MessageBox.Show("Cliente agregado correctamente", "Cliente agregado");
            }
        }
    }
}
