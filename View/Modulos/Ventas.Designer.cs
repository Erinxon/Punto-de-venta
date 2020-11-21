namespace Punto_de_venta.View.Modulos
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableVentas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPrintFactura = new Guna.UI.WinForms.GunaButton();
            this.textBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNewSale = new Guna.UI.WinForms.GunaButton();
          
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVentas)).BeginInit();
          
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.tableVentas);
            this.guna2Panel1.Controls.Add(this.btnPrintFactura);
            this.guna2Panel1.Controls.Add(this.textBuscar);
            this.guna2Panel1.Controls.Add(this.btnNewSale);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 487);
            this.guna2Panel1.TabIndex = 9;
            // 
            // tableVentas
            // 
            this.tableVentas.AllowUserToAddRows = false;
            this.tableVentas.AllowUserToDeleteRows = false;
            this.tableVentas.AllowUserToResizeColumns = false;
            this.tableVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tableVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableVentas.BackgroundColor = System.Drawing.Color.White;
            this.tableVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableVentas.ColumnHeadersHeight = 35;
            this.tableVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableVentas.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableVentas.EnableHeadersVisualStyles = false;
            this.tableVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableVentas.Location = new System.Drawing.Point(0, 86);
            this.tableVentas.MultiSelect = false;
            this.tableVentas.Name = "tableVentas";
            this.tableVentas.ReadOnly = true;
            this.tableVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableVentas.RowHeadersVisible = false;
            this.tableVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVentas.ShowCellErrors = false;
            this.tableVentas.ShowCellToolTips = false;
            this.tableVentas.ShowEditingIcon = false;
            this.tableVentas.ShowRowErrors = false;
            this.tableVentas.Size = new System.Drawing.Size(1010, 393);
            this.tableVentas.TabIndex = 7;
            this.tableVentas.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableVentas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableVentas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableVentas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableVentas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableVentas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableVentas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableVentas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableVentas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableVentas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableVentas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableVentas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableVentas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableVentas.ThemeStyle.HeaderStyle.Height = 35;
            this.tableVentas.ThemeStyle.ReadOnly = true;
            this.tableVentas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableVentas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableVentas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableVentas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableVentas.ThemeStyle.RowsStyle.Height = 22;
            this.tableVentas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableVentas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnPrintFactura
            // 
            this.btnPrintFactura.AnimationHoverSpeed = 0.07F;
            this.btnPrintFactura.AnimationSpeed = 0.03F;
            this.btnPrintFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintFactura.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnPrintFactura.BorderColor = System.Drawing.Color.Black;
            this.btnPrintFactura.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintFactura.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintFactura.ForeColor = System.Drawing.Color.White;
            this.btnPrintFactura.Image = global::Punto_de_venta.Properties.Resources.impresora;
            this.btnPrintFactura.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrintFactura.Location = new System.Drawing.Point(603, 16);
            this.btnPrintFactura.Name = "btnPrintFactura";
            this.btnPrintFactura.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnPrintFactura.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintFactura.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintFactura.OnHoverImage = null;
            this.btnPrintFactura.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintFactura.Radius = 5;
            this.btnPrintFactura.Size = new System.Drawing.Size(228, 51);
            this.btnPrintFactura.TabIndex = 5;
            this.btnPrintFactura.Text = "Imprimir Factura";
            this.btnPrintFactura.Click += new System.EventHandler(this.btnPrintFactura_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscar.BorderRadius = 5;
            this.textBuscar.BorderThickness = 2;
            this.textBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscar.DefaultText = "";
            this.textBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscar.DisabledState.Parent = this.textBuscar;
            this.textBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscar.FocusedState.Parent = this.textBuscar;
            this.textBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscar.HoverState.Parent = this.textBuscar;
            this.textBuscar.IconLeft = global::Punto_de_venta.Properties.Resources.Buscar2;
            this.textBuscar.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBuscar.IconLeftSize = new System.Drawing.Size(25, 25);
            this.textBuscar.Location = new System.Drawing.Point(13, 16);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.PasswordChar = '\0';
            this.textBuscar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscar.PlaceholderText = "Buscar Venta Por Cliente";
            this.textBuscar.SelectedText = "";
            this.textBuscar.ShadowDecoration.Parent = this.textBuscar;
            this.textBuscar.Size = new System.Drawing.Size(317, 51);
            this.textBuscar.TabIndex = 4;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // btnNewSale
            // 
            this.btnNewSale.AnimationHoverSpeed = 0.07F;
            this.btnNewSale.AnimationSpeed = 0.03F;
            this.btnNewSale.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSale.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnNewSale.BorderColor = System.Drawing.Color.Black;
            this.btnNewSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewSale.FocusedColor = System.Drawing.Color.Empty;
            this.btnNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.Image = global::Punto_de_venta.Properties.Resources.addProdcut;
            this.btnNewSale.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNewSale.Location = new System.Drawing.Point(349, 16);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnNewSale.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNewSale.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNewSale.OnHoverImage = null;
            this.btnNewSale.OnPressedColor = System.Drawing.Color.Black;
            this.btnNewSale.Radius = 5;
            this.btnNewSale.Size = new System.Drawing.Size(228, 51);
            this.btnNewSale.TabIndex = 2;
            this.btnNewSale.Text = "Nueva Venta";
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // puntoVentaProyectoFinalDataSet
            // 
         
            // 
            // categoriaProductosTableAdapter
            // 

            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(1010, 487);
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableVentas)).EndInit();
           
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaButton btnPrintFactura;
        private Guna.UI2.WinForms.Guna2TextBox textBuscar;
        private Guna.UI.WinForms.GunaButton btnNewSale;

      
        private Guna.UI2.WinForms.Guna2DataGridView tableVentas;
     
    }
}
