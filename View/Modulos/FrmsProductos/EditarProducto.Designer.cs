namespace Punto_de_venta.View.Modulos.FrmsProductos
{
    partial class EditarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProducto));
            this.textNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.textCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.tableCategoria = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaProductosBindingSource
            // 
            // 
            // puntoVentaProyectoFinalDataSet
            // 
    
            // 
            // textNombre
            // 
            this.textNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombre.BorderRadius = 5;
            this.textNombre.BorderThickness = 2;
            this.textNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNombre.DefaultText = "";
            this.textNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNombre.DisabledState.Parent = this.textNombre;
            this.textNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textNombre.FocusedState.Parent = this.textNombre;
            this.textNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textNombre.HoverState.Parent = this.textNombre;
            this.textNombre.Location = new System.Drawing.Point(410, 42);
            this.textNombre.Name = "textNombre";
            this.textNombre.PasswordChar = '\0';
            this.textNombre.PlaceholderText = "Nombre del Producto";
            this.textNombre.SelectedText = "";
            this.textNombre.ShadowDecoration.Parent = this.textNombre;
            this.textNombre.Size = new System.Drawing.Size(269, 45);
            this.textNombre.TabIndex = 7;
            // 
            // textPrecio
            // 
            this.textPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPrecio.BorderRadius = 5;
            this.textPrecio.BorderThickness = 2;
            this.textPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPrecio.DefaultText = "";
            this.textPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPrecio.DisabledState.Parent = this.textPrecio;
            this.textPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textPrecio.FocusedState.Parent = this.textPrecio;
            this.textPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textPrecio.HoverState.Parent = this.textPrecio;
            this.textPrecio.Location = new System.Drawing.Point(410, 114);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.PasswordChar = '\0';
            this.textPrecio.PlaceholderText = "Precio del Producto";
            this.textPrecio.SelectedText = "";
            this.textPrecio.ShadowDecoration.Parent = this.textPrecio;
            this.textPrecio.Size = new System.Drawing.Size(269, 45);
            this.textPrecio.TabIndex = 8;
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // textCantidad
            // 
            this.textCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textCantidad.BorderRadius = 5;
            this.textCantidad.BorderThickness = 2;
            this.textCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCantidad.DefaultText = "";
            this.textCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCantidad.DisabledState.Parent = this.textCantidad;
            this.textCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textCantidad.FocusedState.Parent = this.textCantidad;
            this.textCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textCantidad.HoverState.Parent = this.textCantidad;
            this.textCantidad.Location = new System.Drawing.Point(410, 190);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.PasswordChar = '\0';
            this.textCantidad.PlaceholderText = "Cantidad";
            this.textCantidad.SelectedText = "";
            this.textCantidad.ShadowDecoration.Parent = this.textCantidad;
            this.textCantidad.Size = new System.Drawing.Size(269, 45);
            this.textCantidad.TabIndex = 9;
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 5;
            this.btnGuardar.CheckedState.Parent = this.btnGuardar;
            this.btnGuardar.CustomImages.Parent = this.btnGuardar;
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.HoverState.Parent = this.btnGuardar;
            this.btnGuardar.Location = new System.Drawing.Point(410, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(270, 44);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tableCategoria
            // 
            this.tableCategoria.AllowUserToAddRows = false;
            this.tableCategoria.AllowUserToDeleteRows = false;
            this.tableCategoria.AllowUserToResizeColumns = false;
            this.tableCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableCategoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCategoria.BackgroundColor = System.Drawing.Color.White;
            this.tableCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCategoria.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tableCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableCategoria.ColumnHeadersHeight = 40;
            this.tableCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableCategoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableCategoria.EnableHeadersVisualStyles = false;
            this.tableCategoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCategoria.Location = new System.Drawing.Point(22, 42);
            this.tableCategoria.MultiSelect = false;
            this.tableCategoria.Name = "tableCategoria";
            this.tableCategoria.ReadOnly = true;
            this.tableCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableCategoria.RowHeadersVisible = false;
            this.tableCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCategoria.ShowCellErrors = false;
            this.tableCategoria.ShowCellToolTips = false;
            this.tableCategoria.ShowEditingIcon = false;
            this.tableCategoria.ShowRowErrors = false;
            this.tableCategoria.Size = new System.Drawing.Size(371, 261);
            this.tableCategoria.TabIndex = 11;
            this.tableCategoria.TabStop = false;
            this.tableCategoria.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableCategoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCategoria.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableCategoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableCategoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableCategoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableCategoria.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableCategoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCategoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableCategoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableCategoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableCategoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableCategoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableCategoria.ThemeStyle.HeaderStyle.Height = 40;
            this.tableCategoria.ThemeStyle.ReadOnly = true;
            this.tableCategoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableCategoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableCategoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableCategoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableCategoria.ThemeStyle.RowsStyle.Height = 22;
            this.tableCategoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableCategoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 354);
            this.Controls.Add(this.tableCategoria);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.EditarProducto_Load);
         
            ((System.ComponentModel.ISupportInitialize)(this.tableCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      
        private Guna.UI2.WinForms.Guna2TextBox textNombre;
        private Guna.UI2.WinForms.Guna2TextBox textPrecio;
        private Guna.UI2.WinForms.Guna2TextBox textCantidad;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2DataGridView tableCategoria;
    }
}