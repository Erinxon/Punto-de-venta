namespace Punto_de_venta.View.Modulos.FrmReportes
{
    partial class FrmReporteIventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteIventario));
            this.reporteINventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntoVentaProyectoFinalDataSet3 = new Punto_de_venta.PuntoVentaProyectoFinalDataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteINventarioTableAdapter = new Punto_de_venta.PuntoVentaProyectoFinalDataSet3TableAdapters.reporteINventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteINventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteINventarioBindingSource
            // 
            this.reporteINventarioBindingSource.DataMember = "reporteINventario";
            this.reporteINventarioBindingSource.DataSource = this.puntoVentaProyectoFinalDataSet3;
            // 
            // puntoVentaProyectoFinalDataSet3
            // 
            this.puntoVentaProyectoFinalDataSet3.DataSetName = "PuntoVentaProyectoFinalDataSet3";
            this.puntoVentaProyectoFinalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 200;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteINventarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Punto_de_venta.Reportes.ImformeIventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(681, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteINventarioTableAdapter
            // 
            this.reporteINventarioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteIventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteIventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Reporte";
            this.Load += new System.EventHandler(this.FrmReporteIventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteINventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PuntoVentaProyectoFinalDataSet3 puntoVentaProyectoFinalDataSet3;
        private System.Windows.Forms.BindingSource reporteINventarioBindingSource;
        private PuntoVentaProyectoFinalDataSet3TableAdapters.reporteINventarioTableAdapter reporteINventarioTableAdapter;
    }
}