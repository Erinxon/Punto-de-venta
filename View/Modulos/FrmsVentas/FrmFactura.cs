using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.View.Modulos.FrmsVentas
{
    public partial class FrmFactura : Form
    {
        public int idVenta { get; set; }

        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            try
            {

                this.imprimirFacturaTableAdapter.Fill(this.puntoVentaProyectoFinalDataSet1.imprimirFactura, this.idVenta);
                this.reportViewer1.RefreshReport();

            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
  
        }
    }
}
