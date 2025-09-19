namespace PuntoVenta
{
    partial class PantallaClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtBoxNombre = new TextBox();
            lblApellidos = new Label();
            txtBoxApellidos = new TextBox();
            lblTelefonoContacto = new Label();
            txtBoxTelefonoContacto = new TextBox();
            lblDireccion = new Label();
            txtBoxDireccion = new TextBox();
            lblBuscar = new Label();
            txtBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonGuardar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            buttonLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 118);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(160, 114);
            txtBoxNombre.Margin = new Padding(3, 4, 3, 4);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(377, 27);
            txtBoxNombre.TabIndex = 1;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(23, 171);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(75, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // txtBoxApellidos
            // 
            txtBoxApellidos.Location = new Point(160, 167);
            txtBoxApellidos.Margin = new Padding(3, 4, 3, 4);
            txtBoxApellidos.Name = "txtBoxApellidos";
            txtBoxApellidos.Size = new Size(377, 27);
            txtBoxApellidos.TabIndex = 3;
            // 
            // lblTelefonoContacto
            // 
            lblTelefonoContacto.AutoSize = true;
            lblTelefonoContacto.Location = new Point(23, 224);
            lblTelefonoContacto.Name = "lblTelefonoContacto";
            lblTelefonoContacto.Size = new Size(155, 20);
            lblTelefonoContacto.TabIndex = 4;
            lblTelefonoContacto.Text = "Teléfono de Contacto:";
            // 
            // txtBoxTelefonoContacto
            // 
            txtBoxTelefonoContacto.Location = new Point(160, 220);
            txtBoxTelefonoContacto.Margin = new Padding(3, 4, 3, 4);
            txtBoxTelefonoContacto.Name = "txtBoxTelefonoContacto";
            txtBoxTelefonoContacto.Size = new Size(377, 27);
            txtBoxTelefonoContacto.TabIndex = 5;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(23, 278);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Dirección:";
            // 
            // txtBoxDireccion
            // 
            txtBoxDireccion.Location = new Point(160, 274);
            txtBoxDireccion.Margin = new Padding(3, 4, 3, 4);
            txtBoxDireccion.Multiline = true;
            txtBoxDireccion.Name = "txtBoxDireccion";
            txtBoxDireccion.Size = new Size(377, 79);
            txtBoxDireccion.TabIndex = 7;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(23, 45);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(160, 41);
            txtBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.Size = new Size(285, 27);
            txtBoxBuscar.TabIndex = 9;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(451, 41);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(86, 31);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(160, 400);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(86, 40);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(251, 400);
            buttonActualizar.Margin = new Padding(3, 4, 3, 4);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(86, 40);
            buttonActualizar.TabIndex = 12;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(343, 400);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(86, 40);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(451, 400);
            buttonLimpiar.Margin = new Padding(3, 4, 3, 4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(86, 40);
            buttonLimpiar.TabIndex = 14;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // PantallaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 750);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(txtBoxDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtBoxTelefonoContacto);
            Controls.Add(lblTelefonoContacto);
            Controls.Add(txtBoxApellidos);
            Controls.Add(lblApellidos);
            Controls.Add(txtBoxNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PantallaClientes";
            Text = "Gestión de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtBoxApellidos;
        private System.Windows.Forms.Label lblTelefonoContacto;
        private System.Windows.Forms.TextBox txtBoxTelefonoContacto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}