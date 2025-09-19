namespace PuntoVenta
{
    partial class PantallaPrincipal
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonProductos = new Button();
            buttonAdmin = new Button();
            buttonCerrarSesion = new Button();
            buttonReportes = new Button();
            buttonSalir = new Button();
            buttonProveedores = new Button();
            buttonClientes = new Button();
            buttonCompras = new Button();
            buttonVentas = new Button();
            buttonInicio = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(375, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 750);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonProductos);
            panel2.Controls.Add(buttonAdmin);
            panel2.Controls.Add(buttonCerrarSesion);
            panel2.Controls.Add(buttonReportes);
            panel2.Controls.Add(buttonSalir);
            panel2.Controls.Add(buttonProveedores);
            panel2.Controls.Add(buttonClientes);
            panel2.Controls.Add(buttonCompras);
            panel2.Controls.Add(buttonVentas);
            panel2.Controls.Add(buttonInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 750);
            panel2.TabIndex = 1;
            // 
            // buttonProductos
            // 
            buttonProductos.Location = new Point(30, 177);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Size = new Size(194, 37);
            buttonProductos.TabIndex = 9;
            buttonProductos.Text = "Productos";
            buttonProductos.UseVisualStyleBackColor = true;
            buttonProductos.Click += buttonProductos_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(27, 346);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(190, 30);
            buttonAdmin.TabIndex = 8;
            buttonAdmin.Text = "Administración";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.Location = new Point(33, 392);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(84, 30);
            buttonCerrarSesion.TabIndex = 7;
            buttonCerrarSesion.Text = "Cerrar Sesión";
            buttonCerrarSesion.UseVisualStyleBackColor = true;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // buttonReportes
            // 
            buttonReportes.Location = new Point(33, 310);
            buttonReportes.Name = "buttonReportes";
            buttonReportes.Size = new Size(191, 30);
            buttonReportes.TabIndex = 6;
            buttonReportes.Text = "Reportes";
            buttonReportes.UseVisualStyleBackColor = true;
            buttonReportes.Click += buttonReportes_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(144, 387);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(78, 29);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonProveedores
            // 
            buttonProveedores.Location = new Point(27, 276);
            buttonProveedores.Name = "buttonProveedores";
            buttonProveedores.Size = new Size(196, 28);
            buttonProveedores.TabIndex = 4;
            buttonProveedores.Text = "Proveedores";
            buttonProveedores.UseVisualStyleBackColor = true;
            buttonProveedores.Click += buttonProveedores_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.Location = new Point(27, 219);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(196, 37);
            buttonClientes.TabIndex = 3;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonCompras
            // 
            buttonCompras.Location = new Point(27, 134);
            buttonCompras.Name = "buttonCompras";
            buttonCompras.Size = new Size(194, 37);
            buttonCompras.TabIndex = 2;
            buttonCompras.Text = "Compras";
            buttonCompras.UseVisualStyleBackColor = true;
            buttonCompras.Click += buttonCompras_Click;
            // 
            // buttonVentas
            // 
            buttonVentas.Location = new Point(33, 77);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Size = new Size(185, 42);
            buttonVentas.TabIndex = 1;
            buttonVentas.Text = "Ventas";
            buttonVentas.UseVisualStyleBackColor = true;
            buttonVentas.Click += buttonVentas_Click;
            // 
            // buttonInicio
            // 
            buttonInicio.Location = new Point(56, 36);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(146, 35);
            buttonInicio.TabIndex = 0;
            buttonInicio.Text = "Inicio (icono)";
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            Load += PantallaPrincipal_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonReportes;
        private Button buttonSalir;
        private Button buttonProveedores;
        private Button buttonClientes;
        private Button buttonCompras;
        private Button buttonVentas;
        private Button buttonInicio;
        private Button buttonAdmin;
        private Button buttonCerrarSesion;
        private Button buttonProductos;
    }
}