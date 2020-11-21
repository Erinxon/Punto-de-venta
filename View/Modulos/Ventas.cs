using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Punto_de_venta.View.Modulos.FrmsVentas;
using Punto_de_venta.Controller.CVentas;

namespace Punto_de_venta.View.Modulos
{
    public partial class Ventas : UserControl
    {
        public string usuario { get; set; }
        IGestionVentas gestionVentas = new GestionVentas();
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            NuevaVenta nuevaVenta = new NuevaVenta();
            nuevaVenta.usuario = usuario;
            nuevaVenta.ShowDialog();
            llenarTabla();
        }

        private void llenarTabla()
        {
            this.tableVentas.DataSource = gestionVentas.getVentas();
        }

        private void llenarTablaFiltrada()
        {
            if (!this.textBuscar.Text.Equals(""))
            {
                this.tableVentas.DataSource = gestionVentas.getVentasFiltrada(this.textBuscar.Text);
            }
            else
            {
                llenarTabla();
            }
            
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            llenarTablaFiltrada();
        }

        private void btnPrintFactura_Click(object sender, EventArgs e)
        {
            if (tableVentas.CurrentRow.Selected)
            {
                imprimirFactura();
            }
            else
            {
                MessageBox.Show("Por favor seleccione la venta", "Venta no seleccionada");
            }
                
        }

        private void imprimirFactura()
        {
            FrmFactura frmFactura = new FrmFactura();
            frmFactura.idVenta = getIdVenta();
            frmFactura.ShowDialog();
        }

        private int getIdVenta()
        {
            return int.Parse(tableVentas.CurrentRow.Cells[0].Value.ToString());
        }

        public void noSelectTable()
        {
            this.tableVentas.ClearSelection();
        }
    }
}
