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
    public partial class FrmReporteProductos : Form
    {
        public FrmReporteProductos()
        {
            InitializeComponent();
        }

        private void FrmReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoVentaProyectoFinalDataSet4.reporteProductosMasVendidos' Puede moverla o quitarla según sea necesario.
            this.reporteProductosMasVendidosTableAdapter.Fill(this.puntoVentaProyectoFinalDataSet4.reporteProductosMasVendidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
