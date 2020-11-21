namespace Punto_de_venta.View.Modulos.FrmReportes
{
    partial class FrmReporteProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteProductos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.puntoVentaProyectoFinalDataSet4 = new Punto_de_venta.PuntoVentaProyectoFinalDataSet4();
            this.reporteProductosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteProductosMasVendidosTableAdapter = new Punto_de_venta.PuntoVentaProyectoFinalDataSet4TableAdapters.reporteProductosMasVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProductosMasVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteProductosMasVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Punto_de_venta.Reportes.InformeProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(692, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // puntoVentaProyectoFinalDataSet4
            // 
            this.puntoVentaProyectoFinalDataSet4.DataSetName = "PuntoVentaProyectoFinalDataSet4";
            this.puntoVentaProyectoFinalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteProductosMasVendidosBindingSource
            // 
            this.reporteProductosMasVendidosBindingSource.DataMember = "reporteProductosMasVendidos";
            this.reporteProductosMasVendidosBindingSource.DataSource = this.puntoVentaProyectoFinalDataSet4;
            // 
            // reporteProductosMasVendidosTableAdapter
            // 
            this.reporteProductosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Reporte";
            this.Load += new System.EventHandler(this.FrmReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProductosMasVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PuntoVentaProyectoFinalDataSet4 puntoVentaProyectoFinalDataSet4;
        private System.Windows.Forms.BindingSource reporteProductosMasVendidosBindingSource;
        private PuntoVentaProyectoFinalDataSet4TableAdapters.reporteProductosMasVendidosTableAdapter reporteProductosMasVendidosTableAdapter;
    }
}