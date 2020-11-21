namespace Punto_de_venta.View.Modulos.FrmReportes
{
    partial class FrmReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVentas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.puntoVentaProyectoFinalDataSet2 = new Punto_de_venta.PuntoVentaProyectoFinalDataSet2();
            this.spDetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_DetalleVentaTableAdapter = new Punto_de_venta.PuntoVentaProyectoFinalDataSet2TableAdapters.sp_DetalleVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.spDetalleVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Punto_de_venta.Reportes.InformeVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(687, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // puntoVentaProyectoFinalDataSet2
            // 
            this.puntoVentaProyectoFinalDataSet2.DataSetName = "PuntoVentaProyectoFinalDataSet2";
            this.puntoVentaProyectoFinalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDetalleVentaBindingSource
            // 
            this.spDetalleVentaBindingSource.DataMember = "sp_DetalleVenta";
            this.spDetalleVentaBindingSource.DataSource = this.puntoVentaProyectoFinalDataSet2;
            // 
            // sp_DetalleVentaTableAdapter
            // 
            this.sp_DetalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 522);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntoVentaProyectoFinalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PuntoVentaProyectoFinalDataSet2 puntoVentaProyectoFinalDataSet2;
        private System.Windows.Forms.BindingSource spDetalleVentaBindingSource;
        private PuntoVentaProyectoFinalDataSet2TableAdapters.sp_DetalleVentaTableAdapter sp_DetalleVentaTableAdapter;
    }
}