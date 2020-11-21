using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.Controller.Reportes;
using Punto_de_venta.View.Modulos.FrmReportes;

namespace Punto_de_venta.View.Modulos
{
    public partial class Reportes : UserControl
    {
        
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string tipo = this.comboxReporte.Text;
            if (tipo.Equals("Reporte de Iventario"))
            {
                FrmReporteIventario frmReporteIventario = new FrmReporteIventario();
                frmReporteIventario.ShowDialog();
            }
            else if (tipo.Equals("Reporte de Ventas"))
            {
                FrmReporteVentas frmReporteVentas = new FrmReporteVentas();
                frmReporteVentas.ShowDialog();
             
            }
            else
            {
                FrmReporteProductos frmReporteProductos = new FrmReporteProductos();
                frmReporteProductos.ShowDialog();
            }
                     
        }

        public void mastrarReporte(String tipo)
        {
            IReporte tipoReporte = ShapeReporte.getReporte(tipo);
            this.tableReportes.DataSource =  tipoReporte.reporte();
            this.tableReportes.ClearSelection();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            string tipo = this.comboxReporte.Text;
            mastrarReporte(tipo);
        }

        private void comboxReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = this.comboxReporte.Text;
            mastrarReporte(tipo);
        }

        public void noSelectTable()
        {
            this.tableReportes.ClearSelection();
        }


    }
}
