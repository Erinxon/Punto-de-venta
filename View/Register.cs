using Punto_de_venta.Controller.CrearUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.View
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void registrar()
        {
            string usuario = this.textUsuario.Text;
            string nombre = this.textNombre.Text;
            string apellido = this.textApellido.Text;
            string password = this.textPassword.Text;
            string password2 = this.textPassword2.Text;

            if (usuario.Equals("") || nombre.Equals("") || apellido.Equals("")
                                  || password.Equals("") || password2.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos", "Tal parece que hay algun campo vacio");
            }
            else
            {
                RegistrarUsuarios registrarUsuarios = new RegistrarUsuarios(usuario, nombre, apellido, password);

                if (registrarUsuarios.validarUsuarioExiste())
                {
                    MessageBox.Show("El usuario que intenta registrar ya existe", "Usuario no disponible");

                }
                else if (password.Equals(password2))
                {
                    registrarUsuarios.registrar();
                    MessageBox.Show("Usuario registrado con exito", "Registro exitoso");
                    redirigir();
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben ser iguales", "Contraseñas desiguales");
                }
            }

        }

        private void redirigir()
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
