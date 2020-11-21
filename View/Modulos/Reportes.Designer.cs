namespace Punto_de_venta.View.Modulos
{
    partial class Reportes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new Guna.UI.WinForms.GunaButton();
            this.tableReportes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboxReporte = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tableReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.AnimationHoverSpeed = 0.07F;
            this.btnImprimir.AnimationSpeed = 0.03F;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BaseColor = System.Drawing.Color.Red;
            this.btnImprimir.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimir.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::Punto_de_venta.Properties.Resources.pdf;
            this.btnImprimir.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImprimir.Location = new System.Drawing.Point(299, 11);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnImprimir.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimir.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimir.OnHoverImage = null;
            this.btnImprimir.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimir.Radius = 5;
            this.btnImprimir.Size = new System.Drawing.Size(244, 62);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir Reporte";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // tableReportes
            // 
            this.tableReportes.AllowUserToAddRows = false;
            this.tableReportes.AllowUserToDeleteRows = false;
            this.tableReportes.AllowUserToResizeColumns = false;
            this.tableReportes.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.tableReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableReportes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableReportes.BackgroundColor = System.Drawing.Color.White;
            this.tableReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableReportes.ColumnHeadersHeight = 35;
            this.tableReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReportes.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableReportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableReportes.EnableHeadersVisualStyles = false;
            this.tableReportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReportes.Location = new System.Drawing.Point(0, 105);
            this.tableReportes.MultiSelect = false;
            this.tableReportes.Name = "tableReportes";
            this.tableReportes.ReadOnly = true;
            this.tableReportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableReportes.RowHeadersVisible = false;
            this.tableReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableReportes.ShowCellErrors = false;
            this.tableReportes.ShowCellToolTips = false;
            this.tableReportes.ShowEditingIcon = false;
            this.tableReportes.ShowRowErrors = false;
            this.tableReportes.Size = new System.Drawing.Size(831, 382);
            this.tableReportes.TabIndex = 8;
            this.tableReportes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableReportes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReportes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableReportes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableReportes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableReportes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableReportes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableReportes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReportes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableReportes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableReportes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableReportes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableReportes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableReportes.ThemeStyle.HeaderStyle.Height = 35;
            this.tableReportes.ThemeStyle.ReadOnly = true;
            this.tableReportes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableReportes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReportes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableReportes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableReportes.ThemeStyle.RowsStyle.Height = 22;
            this.tableReportes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableReportes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // comboxReporte
            // 
            this.comboxReporte.BackColor = System.Drawing.Color.Transparent;
            this.comboxReporte.BorderRadius = 5;
            this.comboxReporte.DisplayMember = "Reporte de Ventas";
            this.comboxReporte.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxReporte.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxReporte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxReporte.FocusedState.Parent = this.comboxReporte;
            this.comboxReporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboxReporte.ForeColor = System.Drawing.Color.Black;
            this.comboxReporte.HoverState.Parent = this.comboxReporte;
            this.comboxReporte.ItemHeight = 30;
            this.comboxReporte.Items.AddRange(new object[] {
            "Producto mas ventidos",
            "Reporte de Iventario",
            "Reporte de Ventas"});
            this.comboxReporte.ItemsAppearance.Parent = this.comboxReporte;
            this.comboxReporte.Location = new System.Drawing.Point(18, 37);
            this.comboxReporte.Name = "comboxReporte";
            this.comboxReporte.ShadowDecoration.Parent = this.comboxReporte;
            this.comboxReporte.Size = new System.Drawing.Size(264, 36);
            this.comboxReporte.StartIndex = 2;
            this.comboxReporte.TabIndex = 9;
            this.comboxReporte.Tag = "";
            this.comboxReporte.SelectedIndexChanged += new System.EventHandler(this.comboxReporte_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(17, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(245, 23);
            this.gunaLabel1.TabIndex = 19;
            this.gunaLabel1.Text = "Seleccione el tipo de reporte:";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.comboxReporte);
            this.Controls.Add(this.tableReportes);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(831, 487);
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnImprimir;
        private Guna.UI2.WinForms.Guna2DataGridView tableReportes;
        private Guna.UI2.WinForms.Guna2ComboBox comboxReporte;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
