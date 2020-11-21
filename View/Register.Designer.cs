namespace Punto_de_venta.View
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.textNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.textApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 5;
            this.btnRegister.CheckedState.Parent = this.btnRegister;
            this.btnRegister.CustomImages.Parent = this.btnRegister;
            this.btnRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.HoverState.Parent = this.btnRegister;
            this.btnRegister.Location = new System.Drawing.Point(24, 286);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ShadowDecoration.Parent = this.btnRegister;
            this.btnRegister.Size = new System.Drawing.Size(424, 47);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Iniciar sesión";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            this.textNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombre.FocusedState.Parent = this.textNombre;
            this.textNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textNombre.HoverState.Parent = this.textNombre;
            this.textNombre.IconLeft = global::Punto_de_venta.Properties.Resources.identificacion;
            this.textNombre.Location = new System.Drawing.Point(24, 137);
            this.textNombre.Name = "textNombre";
            this.textNombre.PasswordChar = '\0';
            this.textNombre.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textNombre.PlaceholderText = "Apellido";
            this.textNombre.SelectedText = "";
            this.textNombre.ShadowDecoration.Parent = this.textNombre;
            this.textNombre.Size = new System.Drawing.Size(201, 44);
            this.textNombre.TabIndex = 8;
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
            this.textApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textApellido.FocusedState.Parent = this.textApellido;
            this.textApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textApellido.HoverState.Parent = this.textApellido;
            this.textApellido.IconLeft = global::Punto_de_venta.Properties.Resources.identificacion;
            this.textApellido.Location = new System.Drawing.Point(248, 137);
            this.textApellido.Name = "textApellido";
            this.textApellido.PasswordChar = '\0';
            this.textApellido.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textApellido.PlaceholderText = "Nombre";
            this.textApellido.SelectedText = "";
            this.textApellido.ShadowDecoration.Parent = this.textApellido;
            this.textApellido.Size = new System.Drawing.Size(201, 44);
            this.textApellido.TabIndex = 7;
            // 
            // textPassword2
            // 
            this.textPassword2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword2.BorderRadius = 5;
            this.textPassword2.BorderThickness = 2;
            this.textPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword2.DefaultText = "";
            this.textPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword2.DisabledState.Parent = this.textPassword2;
            this.textPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword2.FocusedState.Parent = this.textPassword2;
            this.textPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword2.HoverState.Parent = this.textPassword2;
            this.textPassword2.IconLeft = global::Punto_de_venta.Properties.Resources.login;
            this.textPassword2.Location = new System.Drawing.Point(248, 210);
            this.textPassword2.Name = "textPassword2";
            this.textPassword2.PasswordChar = '*';
            this.textPassword2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textPassword2.PlaceholderText = "Repetir Contraseña";
            this.textPassword2.SelectedText = "";
            this.textPassword2.ShadowDecoration.Parent = this.textPassword2;
            this.textPassword2.Size = new System.Drawing.Size(201, 44);
            this.textPassword2.TabIndex = 6;
            // 
            // textUsuario
            // 
            this.textUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUsuario.BorderRadius = 5;
            this.textUsuario.BorderThickness = 2;
            this.textUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsuario.DefaultText = "";
            this.textUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsuario.DisabledState.Parent = this.textUsuario;
            this.textUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUsuario.FocusedState.Parent = this.textUsuario;
            this.textUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUsuario.HoverState.Parent = this.textUsuario;
            this.textUsuario.IconLeft = global::Punto_de_venta.Properties.Resources.usuario;
            this.textUsuario.Location = new System.Drawing.Point(24, 70);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.PasswordChar = '\0';
            this.textUsuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textUsuario.PlaceholderText = "Usuario";
            this.textUsuario.SelectedText = "";
            this.textUsuario.ShadowDecoration.Parent = this.textUsuario;
            this.textUsuario.Size = new System.Drawing.Size(424, 44);
            this.textUsuario.TabIndex = 5;
            // 
            // textPassword
            // 
            this.textPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword.BorderRadius = 5;
            this.textPassword.BorderThickness = 2;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.DefaultText = "";
            this.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.DisabledState.Parent = this.textPassword;
            this.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword.FocusedState.Parent = this.textPassword;
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword.HoverState.Parent = this.textPassword;
            this.textPassword.IconLeft = global::Punto_de_venta.Properties.Resources.login;
            this.textPassword.Location = new System.Drawing.Point(24, 210);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textPassword.PlaceholderText = "Contraseña";
            this.textPassword.SelectedText = "";
            this.textPassword.ShadowDecoration.Parent = this.textPassword;
            this.textPassword.Size = new System.Drawing.Size(201, 44);
            this.textPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registrate";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textPassword2);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textUsuario;
        private Guna.UI2.WinForms.Guna2TextBox textPassword;
        private Guna.UI2.WinForms.Guna2TextBox textPassword2;
        private Guna.UI2.WinForms.Guna2TextBox textApellido;
        private Guna.UI2.WinForms.Guna2TextBox textNombre;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private System.Windows.Forms.Label label2;
    }
}