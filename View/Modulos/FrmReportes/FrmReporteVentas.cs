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
    public partial class FrmReporteVentas : Form
    {
        public FrmReporteVentas()
        {
            InitializeComponent();
        }

        private void FrmReporteVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoVentaProyectoFinalDataSet2.sp_DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.sp_DetalleVentaTableAdapter.Fill(this.puntoVentaProyectoFinalDataSet2.sp_DetalleVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
