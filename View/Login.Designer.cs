namespace Punto_de_venta
{
    partial class login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textRegister = new Guna.UI.WinForms.GunaLinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(229)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(44, 251);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(270, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿No tienes una cuenta?";
            // 
            // textRegister
            // 
            this.textRegister.AutoSize = true;
            this.textRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegister.Location = new System.Drawing.Point(221, 319);
            this.textRegister.Name = "textRegister";
            this.textRegister.Size = new System.Drawing.Size(95, 25);
            this.textRegister.TabIndex = 6;
            this.textRegister.TabStop = true;
            this.textRegister.Text = "Registrate";
            this.textRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.textRegister_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Punto de venta";
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
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUsuario.HoverState.Parent = this.textUsuario;
            this.textUsuario.IconLeft = global::Punto_de_venta.Properties.Resources.usuario;
            this.textUsuario.Location = new System.Drawing.Point(44, 110);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.PasswordChar = '\0';
            this.textUsuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textUsuario.PlaceholderText = "Usuario";
            this.textUsuario.SelectedText = "";
            this.textUsuario.ShadowDecoration.Parent = this.textUsuario;
            this.textUsuario.Size = new System.Drawing.Size(270, 44);
            this.textUsuario.TabIndex = 3;
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
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword.HoverState.Parent = this.textPassword;
            this.textPassword.IconLeft = global::Punto_de_venta.Properties.Resources.login;
            this.textPassword.Location = new System.Drawing.Point(44, 180);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textPassword.PlaceholderText = "Contraseña";
            this.textPassword.SelectedText = "";
            this.textPassword.ShadowDecoration.Parent = this.textPassword;
            this.textPassword.Size = new System.Drawing.Size(270, 44);
            this.textPassword.TabIndex = 2;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\r\nIniciar sesión";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textPassword;
        private Guna.UI2.WinForms.Guna2TextBox textUsuario;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLinkLabel textRegister;
        private System.Windows.Forms.Label label2;
    }
}

