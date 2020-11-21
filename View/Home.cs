using Punto_de_venta.View.Modulos;
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
    public partial class Home : Form
    {
        private string usuario;
        
        public Home()
        {
            InitializeComponent();
        }

        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        private void colorMenu(Color color1, Color color2, Color color3, Color color4, Color color5)
        {
            this.btnMenuInicio.BaseColor = color1;
            this.btnMenuProductos.BaseColor = color2;
            this.btnMenuClientes.BaseColor = color3;
            this.btnMenuVentas.BaseColor = color4;
            this.btnReportes.BaseColor = color5;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.panelPadre.Controls.Add(inicio);
            inicio.Dock = DockStyle.Fill;
            inicio.BringToFront();
        }

        private void btnMenuInicio_Click(object sender, EventArgs e)
        {
            colorMenu(Color.FromArgb(39, 48, 54), Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229),
                      Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229));

            Inicio inicio = new Inicio();
            this.panelPadre.Controls.Add(inicio);
            inicio.Dock = DockStyle.Fill;
            inicio.BringToFront();
        }

        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
            colorMenu(Color.FromArgb(125, 0, 229), Color.FromArgb(39, 48, 54), Color.FromArgb(125, 0, 229),
                      Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229));

            Productos productos = new Productos();
            this.panelPadre.Controls.Add(productos);
            productos.noSelectTable();
            productos.Dock = DockStyle.Fill;
            productos.BringToFront();

        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
           colorMenu(Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229), Color.FromArgb(39, 48, 54),
                      Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229));

            Clientes clientes = new Clientes();
            this.panelPadre.Controls.Add(clientes);
            clientes.noSelectTable();
            clientes.Dock = DockStyle.Fill;
            clientes.BringToFront();
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            colorMenu(Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229),
                      Color.FromArgb(39, 54, 54), Color.FromArgb(125, 0, 229));

            Ventas ventas = new Ventas();
            ventas.usuario = this.usuario;
            this.panelPadre.Controls.Add(ventas);
            ventas.noSelectTable();
            ventas.Dock = DockStyle.Fill;
            ventas.BringToFront();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            colorMenu(Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229), Color.FromArgb(125, 0, 229),
                      Color.FromArgb(125, 0, 229), Color.FromArgb(39, 48, 54));

            Reportes reportes = new Reportes();
            this.panelPadre.Controls.Add(reportes);
            reportes.noSelectTable();
            reportes.Dock = DockStyle.Fill;
            reportes.BringToFront();
        }
    }
}
