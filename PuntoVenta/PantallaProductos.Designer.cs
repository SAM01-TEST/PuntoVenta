namespace PuntoVenta
{
    partial class PantallaProductos
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
        // Definición de variables globales para personalización
        private Font fuenteGeneral = new Font("Arial", 10);
        private int tamañoFuente = 10;
        private int alturaControles = 27;
        private Color colorFondoTextBox = Color.White;
        private Color colorFondoBoton = Color.LightGray;
        private BorderStyle estiloBordeTextBox = BorderStyle.FixedSingle;
        private FlatStyle estiloBordeBoton = FlatStyle.Standard;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigoBarras = new Label();
            txtBoxCodigoBarras = new TextBox();
            lblCategoria = new Label();
            lblTipoProducto = new Label();
            lblMarca = new Label();
            txtBoxMarca = new TextBox();
            lblStockCritico = new Label();
            txtBoxStockCritico = new TextBox();
            lblStock = new Label();
            txtBoxStock = new TextBox();
            lblCodigo = new Label();
            txtBoxCodigo = new TextBox();
            lblClave = new Label();
            txtBoxClave = new TextBox();
            lblDescripcion = new Label();
            txtBoxDescripcion = new TextBox();
            lblPrecioCompraSinIVA = new Label();
            txtBoxPrecioCompraSinIVA = new TextBox();
            lblPrecioVentaSinIVA = new Label();
            txtBoxPrecioVentaSinIVA = new TextBox();
            lblUnidad = new Label();
            txtBoxBusqueda = new TextBox();
            buttonBuscar = new Button();
            buttonInsertar = new Button();
            buttonEliminar = new Button();
            buttonActualizar = new Button();
            txtBoxPrecioVentaConIVA = new TextBox();
            lblPrecioVentaConIVA = new Label();
            txtBoxPrecioCompraConIVA = new TextBox();
            lblPrecioCompraConIVA = new Label();
            listBoxResultados = new ListBox();
            comboBoxTipoProducto = new ComboBox();
            comboBoxCategoria = new ComboBox();
            comboBoxUnidad = new ComboBox();
            buttonLimpiar = new Button();
            SuspendLayout();
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Location = new Point(64, 84);
            lblCodigoBarras.Margin = new Padding(4, 0, 4, 0);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(124, 20);
            lblCodigoBarras.TabIndex = 0;
            lblCodigoBarras.Text = "Código de Barras";
            // 
            // txtBoxCodigoBarras
            // 
            txtBoxCodigoBarras.Location = new Point(197, 84);
            txtBoxCodigoBarras.Margin = new Padding(4, 5, 4, 5);
            txtBoxCodigoBarras.Name = "txtBoxCodigoBarras";
            txtBoxCodigoBarras.Size = new Size(351, 27);
            txtBoxCodigoBarras.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(114, 436);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.Location = new Point(64, 374);
            lblTipoProducto.Margin = new Padding(4, 0, 4, 0);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(124, 20);
            lblTipoProducto.TabIndex = 4;
            lblTipoProducto.Text = "Tipo de Producto";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(481, 366);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca";
            // 
            // txtBoxMarca
            // 
            txtBoxMarca.Location = new Point(544, 366);
            txtBoxMarca.Margin = new Padding(4, 5, 4, 5);
            txtBoxMarca.Name = "txtBoxMarca";
            txtBoxMarca.Size = new Size(181, 27);
            txtBoxMarca.TabIndex = 7;
            // 
            // lblStockCritico
            // 
            lblStockCritico.AutoSize = true;
            lblStockCritico.Location = new Point(444, 225);
            lblStockCritico.Margin = new Padding(4, 0, 4, 0);
            lblStockCritico.Name = "lblStockCritico";
            lblStockCritico.Size = new Size(92, 20);
            lblStockCritico.TabIndex = 8;
            lblStockCritico.Text = "Stock Crítico";
            // 
            // txtBoxStockCritico
            // 
            txtBoxStockCritico.Location = new Point(544, 225);
            txtBoxStockCritico.Margin = new Padding(4, 5, 4, 5);
            txtBoxStockCritico.Name = "txtBoxStockCritico";
            txtBoxStockCritico.Size = new Size(136, 27);
            txtBoxStockCritico.TabIndex = 9;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(143, 225);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock";
            // 
            // txtBoxStock
            // 
            txtBoxStock.Location = new Point(197, 225);
            txtBoxStock.Margin = new Padding(4, 5, 4, 5);
            txtBoxStock.Name = "txtBoxStock";
            txtBoxStock.Size = new Size(136, 27);
            txtBoxStock.TabIndex = 11;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(130, 118);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 12;
            lblCodigo.Text = "Código";
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Location = new Point(196, 118);
            txtBoxCodigo.Margin = new Padding(4, 5, 4, 5);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(136, 27);
            txtBoxCodigo.TabIndex = 13;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(491, 118);
            lblClave.Margin = new Padding(4, 0, 4, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(45, 20);
            lblClave.TabIndex = 14;
            lblClave.Text = "Clave";
            // 
            // txtBoxClave
            // 
            txtBoxClave.Location = new Point(544, 118);
            txtBoxClave.Margin = new Padding(4, 5, 4, 5);
            txtBoxClave.Name = "txtBoxClave";
            txtBoxClave.Size = new Size(136, 27);
            txtBoxClave.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(101, 155);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripción";
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(197, 155);
            txtBoxDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtBoxDescripcion.Multiline = true;
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(550, 60);
            txtBoxDescripcion.TabIndex = 17;
            // 
            // lblPrecioCompraSinIVA
            // 
            lblPrecioCompraSinIVA.AutoSize = true;
            lblPrecioCompraSinIVA.Location = new Point(33, 301);
            lblPrecioCompraSinIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCompraSinIVA.Name = "lblPrecioCompraSinIVA";
            lblPrecioCompraSinIVA.Size = new Size(155, 20);
            lblPrecioCompraSinIVA.TabIndex = 18;
            lblPrecioCompraSinIVA.Text = "Precio Compra sin IVA";
            // 
            // txtBoxPrecioCompraSinIVA
            // 
            txtBoxPrecioCompraSinIVA.Location = new Point(197, 301);
            txtBoxPrecioCompraSinIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioCompraSinIVA.Name = "txtBoxPrecioCompraSinIVA";
            txtBoxPrecioCompraSinIVA.Size = new Size(185, 27);
            txtBoxPrecioCompraSinIVA.TabIndex = 19;
            // 
            // lblPrecioVentaSinIVA
            // 
            lblPrecioVentaSinIVA.AutoSize = true;
            lblPrecioVentaSinIVA.Location = new Point(397, 301);
            lblPrecioVentaSinIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVentaSinIVA.Name = "lblPrecioVentaSinIVA";
            lblPrecioVentaSinIVA.Size = new Size(139, 20);
            lblPrecioVentaSinIVA.TabIndex = 20;
            lblPrecioVentaSinIVA.Text = "Precio Venta sin IVA";
            // 
            // txtBoxPrecioVentaSinIVA
            // 
            txtBoxPrecioVentaSinIVA.Location = new Point(544, 294);
            txtBoxPrecioVentaSinIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioVentaSinIVA.Name = "txtBoxPrecioVentaSinIVA";
            txtBoxPrecioVentaSinIVA.Size = new Size(185, 27);
            txtBoxPrecioVentaSinIVA.TabIndex = 21;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(474, 436);
            lblUnidad.Margin = new Padding(4, 0, 4, 0);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(57, 20);
            lblUnidad.TabIndex = 22;
            lblUnidad.Text = "Unidad";
            // 
            // txtBoxBusqueda
            // 
            txtBoxBusqueda.Location = new Point(197, 24);
            txtBoxBusqueda.Margin = new Padding(4, 5, 4, 5);
            txtBoxBusqueda.Name = "txtBoxBusqueda";
            txtBoxBusqueda.Size = new Size(498, 27);
            txtBoxBusqueda.TabIndex = 24;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(703, 20);
            buttonBuscar.Margin = new Padding(4, 5, 4, 5);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(100, 35);
            buttonBuscar.TabIndex = 25;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Location = new Point(244, 524);
            buttonInsertar.Margin = new Padding(4, 5, 4, 5);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(100, 35);
            buttonInsertar.TabIndex = 26;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(397, 524);
            buttonEliminar.Margin = new Padding(4, 5, 4, 5);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(100, 35);
            buttonEliminar.TabIndex = 27;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(544, 524);
            buttonActualizar.Margin = new Padding(4, 5, 4, 5);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(100, 35);
            buttonActualizar.TabIndex = 28;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // txtBoxPrecioVentaConIVA
            // 
            txtBoxPrecioVentaConIVA.Location = new Point(544, 332);
            txtBoxPrecioVentaConIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioVentaConIVA.Name = "txtBoxPrecioVentaConIVA";
            txtBoxPrecioVentaConIVA.Size = new Size(185, 27);
            txtBoxPrecioVentaConIVA.TabIndex = 55;
            // 
            // lblPrecioVentaConIVA
            // 
            lblPrecioVentaConIVA.AutoSize = true;
            lblPrecioVentaConIVA.Location = new Point(397, 335);
            lblPrecioVentaConIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVentaConIVA.Name = "lblPrecioVentaConIVA";
            lblPrecioVentaConIVA.Size = new Size(145, 20);
            lblPrecioVentaConIVA.TabIndex = 54;
            lblPrecioVentaConIVA.Text = "Precio Venta con IVA";
            // 
            // txtBoxPrecioCompraConIVA
            // 
            txtBoxPrecioCompraConIVA.Location = new Point(197, 338);
            txtBoxPrecioCompraConIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioCompraConIVA.Name = "txtBoxPrecioCompraConIVA";
            txtBoxPrecioCompraConIVA.Size = new Size(185, 27);
            txtBoxPrecioCompraConIVA.TabIndex = 53;
            // 
            // lblPrecioCompraConIVA
            // 
            lblPrecioCompraConIVA.AutoSize = true;
            lblPrecioCompraConIVA.Location = new Point(33, 338);
            lblPrecioCompraConIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCompraConIVA.Name = "lblPrecioCompraConIVA";
            lblPrecioCompraConIVA.Size = new Size(161, 20);
            lblPrecioCompraConIVA.TabIndex = 52;
            lblPrecioCompraConIVA.Text = "Precio Compra con IVA";
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(196, 52);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(500, 24);
            listBoxResultados.TabIndex = 56;
            listBoxResultados.Visible = false;
            // 
            // comboBoxTipoProducto
            // 
            comboBoxTipoProducto.FormattingEnabled = true;
            comboBoxTipoProducto.Location = new Point(202, 377);
            comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            comboBoxTipoProducto.Size = new Size(151, 28);
            comboBoxTipoProducto.TabIndex = 57;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(193, 436);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(151, 28);
            comboBoxCategoria.TabIndex = 58;
            // 
            // comboBoxUnidad
            // 
            comboBoxUnidad.FormattingEnabled = true;
            comboBoxUnidad.Location = new Point(539, 441);
            comboBoxUnidad.Name = "comboBoxUnidad";
            comboBoxUnidad.Size = new Size(151, 28);
            comboBoxUnidad.TabIndex = 59;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(711, 532);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(94, 29);
            buttonLimpiar.TabIndex = 60;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // PantallaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 750);
            Controls.Add(buttonLimpiar);
            Controls.Add(comboBoxUnidad);
            Controls.Add(comboBoxCategoria);
            Controls.Add(comboBoxTipoProducto);
            Controls.Add(listBoxResultados);
            Controls.Add(txtBoxPrecioVentaConIVA);
            Controls.Add(lblPrecioVentaConIVA);
            Controls.Add(txtBoxPrecioCompraConIVA);
            Controls.Add(lblPrecioCompraConIVA);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonInsertar);
            Controls.Add(buttonBuscar);
            Controls.Add(txtBoxBusqueda);
            Controls.Add(lblUnidad);
            Controls.Add(txtBoxPrecioVentaSinIVA);
            Controls.Add(lblPrecioVentaSinIVA);
            Controls.Add(txtBoxPrecioCompraSinIVA);
            Controls.Add(lblPrecioCompraSinIVA);
            Controls.Add(txtBoxDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtBoxClave);
            Controls.Add(lblClave);
            Controls.Add(txtBoxCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtBoxStock);
            Controls.Add(lblStock);
            Controls.Add(txtBoxStockCritico);
            Controls.Add(lblStockCritico);
            Controls.Add(txtBoxMarca);
            Controls.Add(lblMarca);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblCategoria);
            Controls.Add(txtBoxCodigoBarras);
            Controls.Add(lblCodigoBarras);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "PantallaProductos";
            Text = "Control de Productos";
            Load += PantallaProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtBoxCodigoBarras;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.Label lblStockCritico;
        private System.Windows.Forms.TextBox txtBoxStockCritico;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtBoxStock;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtBoxClave;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.Label lblPrecioCompraSinIVA;
        private System.Windows.Forms.TextBox txtBoxPrecioCompraSinIVA;
        private System.Windows.Forms.Label lblPrecioVentaSinIVA;
        private System.Windows.Forms.TextBox txtBoxPrecioVentaSinIVA;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private TextBox txtBoxPrecioVentaConIVA;
        private Label lblPrecioVentaConIVA;
        private TextBox txtBoxPrecioCompraConIVA;
        private Label lblPrecioCompraConIVA;
        private ListBox listBoxResultados;
        private ComboBox comboBoxTipoProducto;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxUnidad;
        private Button buttonLimpiar;
    }
}