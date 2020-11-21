namespace Punto_de_venta.View.Modulos.FrmsVentas
{
    partial class NuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaVenta));
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.textCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIdCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIDProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnVenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.tableProductosAdd = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelCliente = new Guna.UI.WinForms.GunaLabel();
            this.labelTotal = new Guna.UI.WinForms.GunaLabel();
            this.textBuscarCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductosAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BorderRadius = 5;
            this.btnAddProduct.CheckedState.Parent = this.btnAddProduct;
            this.btnAddProduct.CustomImages.Parent = this.btnAddProduct;
            this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.HoverState.Parent = this.btnAddProduct;
            this.btnAddProduct.Location = new System.Drawing.Point(960, 191);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.ShadowDecoration.Parent = this.btnAddProduct;
            this.btnAddProduct.Size = new System.Drawing.Size(270, 44);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Agregar Producto";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            this.textCantidad.Location = new System.Drawing.Point(959, 129);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.PasswordChar = '\0';
            this.textCantidad.PlaceholderText = "Cantidad";
            this.textCantidad.SelectedText = "";
            this.textCantidad.ShadowDecoration.Parent = this.textCantidad;
            this.textCantidad.Size = new System.Drawing.Size(269, 45);
            this.textCantidad.TabIndex = 8;
            this.textCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantidad_KeyPress);
            // 
            // textIdCliente
            // 
            this.textIdCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textIdCliente.BorderRadius = 5;
            this.textIdCliente.BorderThickness = 2;
            this.textIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIdCliente.DefaultText = "";
            this.textIdCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIdCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIdCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIdCliente.DisabledState.Parent = this.textIdCliente;
            this.textIdCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIdCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textIdCliente.FocusedState.Parent = this.textIdCliente;
            this.textIdCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textIdCliente.HoverState.Parent = this.textIdCliente;
            this.textIdCliente.Location = new System.Drawing.Point(959, 69);
            this.textIdCliente.Name = "textIdCliente";
            this.textIdCliente.PasswordChar = '\0';
            this.textIdCliente.PlaceholderText = "ID Cliente";
            this.textIdCliente.SelectedText = "";
            this.textIdCliente.ShadowDecoration.Parent = this.textIdCliente;
            this.textIdCliente.Size = new System.Drawing.Size(269, 45);
            this.textIdCliente.TabIndex = 7;
            this.textIdCliente.TextChanged += new System.EventHandler(this.textIdCliente_TextChanged);
            this.textIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdCliente_KeyPress);
            // 
            // textIDProducto
            // 
            this.textIDProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textIDProducto.BorderRadius = 5;
            this.textIDProducto.BorderThickness = 2;
            this.textIDProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textIDProducto.DefaultText = "";
            this.textIDProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textIDProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textIDProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIDProducto.DisabledState.Parent = this.textIDProducto;
            this.textIDProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textIDProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textIDProducto.FocusedState.Parent = this.textIDProducto;
            this.textIDProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textIDProducto.HoverState.Parent = this.textIDProducto;
            this.textIDProducto.Location = new System.Drawing.Point(960, 11);
            this.textIDProducto.Name = "textIDProducto";
            this.textIDProducto.PasswordChar = '\0';
            this.textIDProducto.PlaceholderText = "ID producto";
            this.textIDProducto.SelectedText = "";
            this.textIDProducto.ShadowDecoration.Parent = this.textIDProducto;
            this.textIDProducto.Size = new System.Drawing.Size(269, 45);
            this.textIDProducto.TabIndex = 6;
            this.textIDProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIDProducto_KeyPress);
            // 
            // tableProductos
            // 
            this.tableProductos.AllowUserToAddRows = false;
            this.tableProductos.AllowUserToDeleteRows = false;
            this.tableProductos.AllowUserToResizeColumns = false;
            this.tableProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.tableProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.tableProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableProductos.BackgroundColor = System.Drawing.Color.White;
            this.tableProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableProductos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tableProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.tableProductos.ColumnHeadersHeight = 40;
            this.tableProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableProductos.DefaultCellStyle = dataGridViewCellStyle21;
            this.tableProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableProductos.EnableHeadersVisualStyles = false;
            this.tableProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableProductos.Location = new System.Drawing.Point(25, 51);
            this.tableProductos.MultiSelect = false;
            this.tableProductos.Name = "tableProductos";
            this.tableProductos.ReadOnly = true;
            this.tableProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableProductos.RowHeadersVisible = false;
            this.tableProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableProductos.ShowCellErrors = false;
            this.tableProductos.ShowCellToolTips = false;
            this.tableProductos.ShowEditingIcon = false;
            this.tableProductos.ShowRowErrors = false;
            this.tableProductos.Size = new System.Drawing.Size(563, 246);
            this.tableProductos.TabIndex = 11;
            this.tableProductos.TabStop = false;
            this.tableProductos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableProductos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableProductos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableProductos.ThemeStyle.HeaderStyle.Height = 40;
            this.tableProductos.ThemeStyle.ReadOnly = true;
            this.tableProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableProductos.ThemeStyle.RowsStyle.Height = 22;
            this.tableProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tableClientes
            // 
            this.tableClientes.AllowUserToAddRows = false;
            this.tableClientes.AllowUserToDeleteRows = false;
            this.tableClientes.AllowUserToResizeColumns = false;
            this.tableClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.tableClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.tableClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableClientes.BackgroundColor = System.Drawing.Color.White;
            this.tableClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableClientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tableClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.tableClientes.ColumnHeadersHeight = 40;
            this.tableClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableClientes.DefaultCellStyle = dataGridViewCellStyle24;
            this.tableClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableClientes.EnableHeadersVisualStyles = false;
            this.tableClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableClientes.Location = new System.Drawing.Point(620, 51);
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
            this.tableClientes.Size = new System.Drawing.Size(326, 246);
            this.tableClientes.TabIndex = 12;
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
            this.tableClientes.ThemeStyle.HeaderStyle.Height = 40;
            this.tableClientes.ThemeStyle.ReadOnly = true;
            this.tableClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableClientes.ThemeStyle.RowsStyle.Height = 22;
            this.tableClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnVenta
            // 
            this.btnVenta.BorderRadius = 5;
            this.btnVenta.CheckedState.Parent = this.btnVenta;
            this.btnVenta.CustomImages.Parent = this.btnVenta;
            this.btnVenta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.HoverState.Parent = this.btnVenta;
            this.btnVenta.Location = new System.Drawing.Point(958, 320);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.ShadowDecoration.Parent = this.btnVenta;
            this.btnVenta.Size = new System.Drawing.Size(270, 44);
            this.btnVenta.TabIndex = 13;
            this.btnVenta.Text = "Concretar Venta";
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 5;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(958, 373);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(270, 44);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableProductosAdd
            // 
            this.tableProductosAdd.AllowUserToAddRows = false;
            this.tableProductosAdd.AllowUserToDeleteRows = false;
            this.tableProductosAdd.AllowUserToResizeColumns = false;
            this.tableProductosAdd.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.tableProductosAdd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.tableProductosAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableProductosAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableProductosAdd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableProductosAdd.BackgroundColor = System.Drawing.Color.White;
            this.tableProductosAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableProductosAdd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableProductosAdd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.tableProductosAdd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableProductosAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.tableProductosAdd.ColumnHeadersHeight = 40;
            this.tableProductosAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableProductosAdd.DefaultCellStyle = dataGridViewCellStyle27;
            this.tableProductosAdd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tableProductosAdd.EnableHeadersVisualStyles = false;
            this.tableProductosAdd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableProductosAdd.Location = new System.Drawing.Point(25, 322);
            this.tableProductosAdd.MultiSelect = false;
            this.tableProductosAdd.Name = "tableProductosAdd";
            this.tableProductosAdd.ReadOnly = true;
            this.tableProductosAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableProductosAdd.RowHeadersVisible = false;
            this.tableProductosAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableProductosAdd.ShowCellErrors = false;
            this.tableProductosAdd.ShowCellToolTips = false;
            this.tableProductosAdd.ShowEditingIcon = false;
            this.tableProductosAdd.ShowRowErrors = false;
            this.tableProductosAdd.Size = new System.Drawing.Size(921, 273);
            this.tableProductosAdd.TabIndex = 15;
            this.tableProductosAdd.TabStop = false;
            this.tableProductosAdd.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.tableProductosAdd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableProductosAdd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableProductosAdd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableProductosAdd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableProductosAdd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableProductosAdd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tableProductosAdd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableProductosAdd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tableProductosAdd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableProductosAdd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableProductosAdd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableProductosAdd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tableProductosAdd.ThemeStyle.HeaderStyle.Height = 40;
            this.tableProductosAdd.ThemeStyle.ReadOnly = true;
            this.tableProductosAdd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableProductosAdd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableProductosAdd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableProductosAdd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableProductosAdd.ThemeStyle.RowsStyle.Height = 22;
            this.tableProductosAdd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableProductosAdd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // labelCliente
            // 
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(955, 441);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(245, 33);
            this.labelCliente.TabIndex = 18;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(955, 489);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(245, 33);
            this.labelTotal.TabIndex = 19;
            this.labelTotal.Text = "Total:";
            // 
            // textBuscarCliente
            // 
            this.textBuscarCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscarCliente.DefaultText = "";
            this.textBuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscarCliente.DisabledState.Parent = this.textBuscarCliente;
            this.textBuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarCliente.FocusedState.Parent = this.textBuscarCliente;
            this.textBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarCliente.HoverState.Parent = this.textBuscarCliente;
            this.textBuscarCliente.IconLeft = global::Punto_de_venta.Properties.Resources.Buscar2;
            this.textBuscarCliente.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBuscarCliente.Location = new System.Drawing.Point(620, 13);
            this.textBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBuscarCliente.Name = "textBuscarCliente";
            this.textBuscarCliente.PasswordChar = '\0';
            this.textBuscarCliente.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarCliente.PlaceholderText = "Buscar Cliente";
            this.textBuscarCliente.SelectedText = "";
            this.textBuscarCliente.ShadowDecoration.Parent = this.textBuscarCliente;
            this.textBuscarCliente.Size = new System.Drawing.Size(326, 38);
            this.textBuscarCliente.TabIndex = 17;
            this.textBuscarCliente.TextChanged += new System.EventHandler(this.textBuscarCliente_TextChanged);
            // 
            // textBuscarProducto
            // 
            this.textBuscarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBuscarProducto.DefaultText = "";
            this.textBuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscarProducto.DisabledState.Parent = this.textBuscarProducto;
            this.textBuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarProducto.FocusedState.Parent = this.textBuscarProducto;
            this.textBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarProducto.HoverState.Parent = this.textBuscarProducto;
            this.textBuscarProducto.IconLeft = global::Punto_de_venta.Properties.Resources.Buscar2;
            this.textBuscarProducto.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.textBuscarProducto.Location = new System.Drawing.Point(25, 14);
            this.textBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBuscarProducto.Name = "textBuscarProducto";
            this.textBuscarProducto.PasswordChar = '\0';
            this.textBuscarProducto.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textBuscarProducto.PlaceholderText = "Buscar Producto";
            this.textBuscarProducto.SelectedText = "";
            this.textBuscarProducto.ShadowDecoration.Parent = this.textBuscarProducto;
            this.textBuscarProducto.Size = new System.Drawing.Size(563, 38);
            this.textBuscarProducto.TabIndex = 16;
            this.textBuscarProducto.TextChanged += new System.EventHandler(this.textBuscarProducto_TextChanged);
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 604);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.textBuscarCliente);
            this.Controls.Add(this.textBuscarProducto);
            this.Controls.Add(this.tableProductosAdd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.tableClientes);
            this.Controls.Add(this.tableProductos);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textIdCliente);
            this.Controls.Add(this.textIDProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductosAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private Guna.UI2.WinForms.Guna2TextBox textCantidad;
        private Guna.UI2.WinForms.Guna2TextBox textIdCliente;
        private Guna.UI2.WinForms.Guna2TextBox textIDProducto;
        private Guna.UI2.WinForms.Guna2DataGridView tableProductos;
        private Guna.UI2.WinForms.Guna2DataGridView tableClientes;
        private Guna.UI2.WinForms.Guna2Button btnVenta;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2DataGridView tableProductosAdd;
        private Guna.UI2.WinForms.Guna2TextBox textBuscarProducto;
        private Guna.UI2.WinForms.Guna2TextBox textBuscarCliente;
        private Guna.UI.WinForms.GunaLabel labelCliente;
        private Guna.UI.WinForms.GunaLabel labelTotal;
    }
}