namespace Punto_de_venta.View.Modulos.FrmsVentas
{
    partial class FrmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.imprimirFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntoVentaProyectoFinalDataSet1 = new Punto_de_venta.PuntoVentaProyectoFinalDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.imprimirFacturaTableAdapter = new Punto_de_venta.PuntoVentaProyectoFinalDataSet1TableAdapters.imprimirFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imprimirFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // imprimirFacturaBindingSource
            // 
            this.imprimirFacturaBindingSource.DataMember = "imprimirFactura";
            this.imprimirFacturaBindingSource.DataSource = this.puntoVentaProyectoFinalDataSet1;
            // 
            // puntoVentaProyectoFinalDataSet1
            // 
            this.puntoVentaProyectoFinalDataSet1.DataSetName = "PuntoVentaProyectoFinalDataSet1";
            this.puntoVentaProyectoFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.imprimirFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Punto_de_venta.Reportes.ReporteFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(666, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // imprimirFacturaTableAdapter
            // 
            this.imprimirFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imprimirFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource imprimirFacturaBindingSource;
        private PuntoVentaProyectoFinalDataSet1 puntoVentaProyectoFinalDataSet1;
        private PuntoVentaProyectoFinalDataSet1TableAdapters.imprimirFacturaTableAdapter imprimirFacturaTableAdapter;
    }
}