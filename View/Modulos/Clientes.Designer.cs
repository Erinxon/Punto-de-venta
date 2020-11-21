namespace Punto_de_venta.View.Modulos
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEditClient = new Guna.UI.WinForms.GunaButton();
            this.textBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddClient = new Guna.UI.WinForms.GunaButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.tableClientes);
            this.guna2Panel1.Controls.Add(this.btnEditClient);
            this.guna2Panel1.Controls.Add(this.textBuscar);
            this.guna2Panel1.Controls.Add(this.btnAddClient);
            this.guna2Panel1.Location = new System.Drawing.Point(-79, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 487);
            this.guna2Panel1.TabIndex = 8;
            // 
            // tableClientes
            // 
            this.tableClientes.AllowUserToAddRows = false;
            this.tableClientes.AllowUserToDeleteRows = false;
            this.tableClientes.AllowUserToOrderColumns = true;
            this.tableClientes.AllowUserToResizeColumns = false;
            this.tableClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableClientes.BackgroundColor = System.Drawing.Color.White;
            this.tableClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableClientes.ColumnHeadersHeight = 35;
            this.tableClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.tableClientes.EnableHeadersVisualStyles = false;
            this.tableClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableClientes.Location = new System.Drawing.Point(79, 86);
            this.tableClientes.MultiSelect = false;
            this.tableClientes.Name = "tableClientes";
            this.tableClientes.ReadOnly = true;
            this.tableClientes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableClientes.RowHeadersVisible = false;
            this.tableClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableClientes.ShowCellErrors = false;
            this.tableClientes.ShowCellToolTips = false;
            this.tableClientes.ShowEditingIcon = false;
            this.tableClientes.ShowRowErrors = false;
            this.tableClientes.Size = new System.Drawing.Size(931, 401);
            this.tableClientes.TabIndex = 6;
            this.tableClientes.TabStop = false;
            this.tableClientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableClientes.ThemeStyle.HeaderStyle.Height = 35;
            this.tableClientes.ThemeStyle.ReadOnly = true;
            this.tableClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableClientes.ThemeStyle.RowsStyle.Height = 22;
            this.tableClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnEditClient
            // 
            this.btnEditClient.AnimationHoverSpeed = 0.07F;
            this.btnEditClient.AnimationSpeed = 0.03F;
            this.btnEditClient.BackColor = System.Drawing.Color.Transparent;
            this.btnEditClient.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnEditClient.BorderColor = System.Drawing.Color.Black;
            this.btnEditClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.Image = global::Punto_de_venta.Properties.Resources.editar;
            this.btnEditClient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEditClient.Location = new System.Drawing.Point(682, 16);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnEditClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditClient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditClient.OnHoverImage = null;
            this.btnEditClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditClient.Radius = 5;
            this.btnEditClient.Size = new System.Drawing.Size(228, 51);
            this.btnEditClient.TabIndex = 5;
            this.btnEditClient.Text = "Editar Cliente";
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
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
            this.textBuscar.Location = new System.Drawing.Point(92, 16);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.PasswordChar = '\0';
            this.textBuscar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscar.PlaceholderText = "Buscar Cliente";
            this.textBuscar.SelectedText = "";
            this.textBuscar.ShadowDecoration.Parent = this.textBuscar;
            this.textBuscar.Size = new System.Drawing.Size(317, 51);
            this.textBuscar.TabIndex = 4;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // btnAddClient
            // 
            this.btnAddClient.AnimationHoverSpeed = 0.07F;
            this.btnAddClient.AnimationSpeed = 0.03F;
            this.btnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClient.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnAddClient.BorderColor = System.Drawing.Color.Black;
            this.btnAddClient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddClient.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Image = global::Punto_de_venta.Properties.Resources.addProdcut;
            this.btnAddClient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddClient.Location = new System.Drawing.Point(428, 16);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnAddClient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddClient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddClient.OnHoverImage = null;
            this.btnAddClient.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddClient.Radius = 5;
            this.btnAddClient.Size = new System.Drawing.Size(228, 51);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Agregar Cliente";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(931, 487);
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView tableClientes;
        private Guna.UI.WinForms.GunaButton btnEditClient;
        private Guna.UI2.WinForms.Guna2TextBox textBuscar;
        private Guna.UI.WinForms.GunaButton btnAddClient;
    }
}
