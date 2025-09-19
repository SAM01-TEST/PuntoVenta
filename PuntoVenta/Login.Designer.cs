namespace PuntoVenta
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            buttonLogin = new Button();
            labelUsuario = new Label();
            labelContrasena = new Label();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Font = new Font("Segoe UI", 10F);
            textBoxUsuario.Location = new Point(300, 150);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(200, 30);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.BorderStyle = BorderStyle.FixedSingle;
            textBoxContrasena.Font = new Font("Segoe UI", 10F);
            textBoxContrasena.Location = new Point(300, 220);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.Size = new Size(200, 30);
            textBoxContrasena.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(0, 123, 255);
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(300, 280);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 40);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Iniciar sesión";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 10F);
            labelUsuario.Location = new Point(300, 120);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(68, 23);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            labelContrasena.AutoSize = true;
            labelContrasena.Font = new Font("Segoe UI", 10F);
            labelContrasena.Location = new Point(300, 190);
            labelContrasena.Name = "labelContrasena";
            labelContrasena.Size = new Size(97, 23);
            labelContrasena.TabIndex = 4;
            labelContrasena.Text = "Contraseña";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(300, 50);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(217, 37);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Inicio de Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTitulo);
            Controls.Add(labelContrasena);
            Controls.Add(labelUsuario);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Name = "Login";
            Text = "Punto de Venta - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Button buttonLogin;
        private Label labelUsuario;
        private Label labelContrasena;
        private Label labelTitulo;
    }
}