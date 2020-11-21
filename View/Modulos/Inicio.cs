﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.Controller.ReporteInicio;

namespace Punto_de_venta.View.Modulos
{
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ReporteInicio reporteInicio = new ReporteInicio();
            this.labelTotalVenta.Text = "$" + reporteInicio.getVenta().ToString();
            this.labelTotalClientes.Text = reporteInicio.getCliente().ToString();
            this.labelTotalIventario.Text = "$" + reporteInicio.getIventario().ToString();

            this.pictureBox1.Location = new Point(this.Width /2 - this.pictureBox1.Width/2, this.Height / 2 - this.pictureBox1.Height / 3);
        }
    }
}
