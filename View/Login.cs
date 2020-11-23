using Punto_de_venta.Controller;
using Punto_de_venta.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void iniciarSesion()
        {
            string usuario = this.textUsuario.Text;
            string password =  this.textPassword.Text;

            if(usuario.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Todos los campos son requeridos", "Tal parece que hay algun campo vacio");
            }
            else
            {
                ValidarUsuario validar = new ValidarUsuario(usuario,password);
                if (validar.validarUser())
                {
                    if (validar.validarPassword())
                    {
                        redirigir();                   
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Contraseña incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Ese usuario no existe", "Usuario incorrecto");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            iniciarSesion();
        }

        private void textRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();

        }

        private void redirigir()
        {
            Home home = new Home();
            home.setUsuario(this.textUsuario.Text);
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
