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
    public partial class EditClient : Form
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }

        public EditClient()
        {
            InitializeComponent();
            
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarDatos()
        {
            this.textNombre.Text = this.nombre;
            this.textApellido.Text = this.apellido;
            this.textDireccion.Text = this.direccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(this.textNombre.Text.Equals("") || this.textApellido.Text.Equals("") 
                || this.textDireccion.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos", "Parece que hay un campo vacio");
            }
            else
            {
                
                IGestionClientes gestionClientes = new GestionClientes();
                gestionClientes.editar(this.idCliente, this.textNombre.Text, this.textApellido.Text, this.textDireccion.Text);
                MessageBox.Show("Cliente editado correctamente", "Cliente editado");
            }
        }

        private void EditClient_Load_1(object sender, EventArgs e)
        {
            cargarDatos(); 
        }


    }
}
