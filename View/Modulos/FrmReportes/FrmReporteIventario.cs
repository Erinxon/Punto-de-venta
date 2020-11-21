using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.View.Modulos.FrmReportes
{
    public partial class FrmReporteIventario : Form
    {
        public FrmReporteIventario()
        {
            InitializeComponent();
        }

        private void FrmReporteIventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoVentaProyectoFinalDataSet3.reporteINventario' Puede moverla o quitarla según sea necesario.
            this.reporteINventarioTableAdapter.Fill(this.puntoVentaProyectoFinalDataSet3.reporteINventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
