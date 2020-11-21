namespace Punto_de_venta.View.Modulos.FrmsClientes
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.textDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.textApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.textNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
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
            this.btnGuardar.Location = new System.Drawing.Point(90, 250);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ShadowDecoration.Parent = this.btnGuardar;
            this.btnGuardar.Size = new System.Drawing.Size(270, 44);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textDireccion
            // 
            this.textDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textDireccion.BorderRadius = 5;
            this.textDireccion.BorderThickness = 2;
            this.textDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDireccion.DefaultText = "";
            this.textDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDireccion.DisabledState.Parent = this.textDireccion;
            this.textDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textDireccion.FocusedState.Parent = this.textDireccion;
            this.textDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textDireccion.HoverState.Parent = this.textDireccion;
            this.textDireccion.Location = new System.Drawing.Point(90, 181);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.PasswordChar = '\0';
            this.textDireccion.PlaceholderText = "Dirección";
            this.textDireccion.SelectedText = "";
            this.textDireccion.ShadowDecoration.Parent = this.textDireccion;
            this.textDireccion.Size = new System.Drawing.Size(269, 45);
            this.textDireccion.TabIndex = 8;
            // 
            // textApellido
            // 
            this.textApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textApellido.BorderRadius = 5;
            this.textApellido.BorderThickness = 2;
            this.textApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textApellido.DefaultText = "";
            this.textApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textApellido.DisabledState.Parent = this.textApellido;
            this.textApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textApellido.FocusedState.Parent = this.textApellido;
            this.textApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.textApellido.HoverState.Parent = this.textApellido;
            this.textApellido.Location = new System.Drawing.Point(90, 105);
            this.textApellido.Name = "textApellido";
            this.textApellido.PasswordChar = '\0';
            this.textApellido.PlaceholderText = "Apellido";
            this.textApellido.SelectedText = "";
            this.textApellido.ShadowDecoration.Parent = this.textApellido;
            this.textApellido.Size = new System.Drawing.Size(269, 45);
            this.textApellido.TabIndex = 7;
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
            this.textNombre.Location = new System.Drawing.Point(90, 33);
            this.textNombre.Name = "textNombre";
            this.textNombre.PasswordChar = '\0';
            this.textNombre.PlaceholderText = "Nombre ";
            this.textNombre.SelectedText = "";
            this.textNombre.ShadowDecoration.Parent = this.textNombre;
            this.textNombre.Size = new System.Drawing.Size(269, 45);
            this.textNombre.TabIndex = 6;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 340);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2TextBox textDireccion;
        private Guna.UI2.WinForms.Guna2TextBox textApellido;
        private Guna.UI2.WinForms.Guna2TextBox textNombre;
    }
}