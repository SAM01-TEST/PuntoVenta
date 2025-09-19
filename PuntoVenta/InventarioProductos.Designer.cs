namespace PuntoVenta
{
    partial class InventarioProductos

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
            panelSuperior = new Panel();
            lblCodigoBarras = new Label();
            txtBoxCodigoBarras = new TextBox();
            buttonBuscar = new Button();
            panelInferior = new Panel();
            txtBoxUnidad = new TextBox();
            lblUnidad = new Label();
            txtBoxPrecioVentaSinIVA = new TextBox();
            lblPrecioVentaSinIVA = new Label();
            txtBoxPrecioCompraSinIVA = new TextBox();
            lblPrecioCompraSinIVA = new Label();
            txtBoxDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtBoxClave = new TextBox();
            lblClave = new Label();
            txtBoxCodigo = new TextBox();
            lblCodigo = new Label();
            txtBoxStock = new TextBox();
            lblStock = new Label();
            txtBoxStockCritico = new TextBox();
            lblStockCritico = new Label();
            txtBoxMarca = new TextBox();
            lblMarca = new Label();
            txtBoxTipoProducto = new TextBox();
            lblTipoProducto = new Label();
            txtBoxCategoria = new TextBox();
            lblCategoria = new Label();
            txtBoxPrecioCompraConIVA = new TextBox();
            lblPrecioCompraConIVA = new Label();
            txtBoxPrecioVentaConIVA = new TextBox();
            lblPrecioVentaConIVA = new Label();
            panelSuperior.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(lblCodigoBarras);
            panelSuperior.Controls.Add(txtBoxCodigoBarras);
            panelSuperior.Controls.Add(buttonBuscar);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1175, 117);
            panelSuperior.TabIndex = 0;
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.Location = new Point(157, 29);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(128, 23);
            lblCodigoBarras.TabIndex = 0;
            lblCodigoBarras.Text = "Código de Barras";
            // 
            // txtBoxCodigoBarras
            // 
            txtBoxCodigoBarras.Location = new Point(291, 29);
            txtBoxCodigoBarras.Name = "txtBoxCodigoBarras";
            txtBoxCodigoBarras.Size = new Size(462, 27);
            txtBoxCodigoBarras.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(898, 29);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 28);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(txtBoxPrecioVentaConIVA);
            panelInferior.Controls.Add(lblPrecioVentaConIVA);
            panelInferior.Controls.Add(txtBoxPrecioCompraConIVA);
            panelInferior.Controls.Add(lblPrecioCompraConIVA);
            panelInferior.Controls.Add(txtBoxUnidad);
            panelInferior.Controls.Add(lblUnidad);
            panelInferior.Controls.Add(txtBoxPrecioVentaSinIVA);
            panelInferior.Controls.Add(lblPrecioVentaSinIVA);
            panelInferior.Controls.Add(txtBoxPrecioCompraSinIVA);
            panelInferior.Controls.Add(lblPrecioCompraSinIVA);
            panelInferior.Controls.Add(txtBoxDescripcion);
            panelInferior.Controls.Add(lblDescripcion);
            panelInferior.Controls.Add(txtBoxClave);
            panelInferior.Controls.Add(lblClave);
            panelInferior.Controls.Add(txtBoxCodigo);
            panelInferior.Controls.Add(lblCodigo);
            panelInferior.Controls.Add(txtBoxStock);
            panelInferior.Controls.Add(lblStock);
            panelInferior.Controls.Add(txtBoxStockCritico);
            panelInferior.Controls.Add(lblStockCritico);
            panelInferior.Controls.Add(txtBoxMarca);
            panelInferior.Controls.Add(lblMarca);
            panelInferior.Controls.Add(txtBoxTipoProducto);
            panelInferior.Controls.Add(lblTipoProducto);
            panelInferior.Controls.Add(txtBoxCategoria);
            panelInferior.Controls.Add(lblCategoria);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 0);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1175, 491);
            panelInferior.TabIndex = 1;
            // 
            // txtBoxUnidad
            // 
            txtBoxUnidad.Location = new Point(680, 398);
            txtBoxUnidad.Margin = new Padding(4, 5, 4, 5);
            txtBoxUnidad.Name = "txtBoxUnidad";
            txtBoxUnidad.Size = new Size(181, 27);
            txtBoxUnidad.TabIndex = 47;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(615, 398);
            lblUnidad.Margin = new Padding(4, 0, 4, 0);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(57, 20);
            lblUnidad.TabIndex = 46;
            lblUnidad.Text = "Unidad";
            // 
            // txtBoxPrecioVentaSinIVA
            // 
            txtBoxPrecioVentaSinIVA.Location = new Point(680, 287);
            txtBoxPrecioVentaSinIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioVentaSinIVA.Name = "txtBoxPrecioVentaSinIVA";
            txtBoxPrecioVentaSinIVA.Size = new Size(185, 27);
            txtBoxPrecioVentaSinIVA.TabIndex = 45;
            // 
            // lblPrecioVentaSinIVA
            // 
            lblPrecioVentaSinIVA.AutoSize = true;
            lblPrecioVentaSinIVA.Location = new Point(533, 287);
            lblPrecioVentaSinIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVentaSinIVA.Name = "lblPrecioVentaSinIVA";
            lblPrecioVentaSinIVA.Size = new Size(139, 20);
            lblPrecioVentaSinIVA.TabIndex = 44;
            lblPrecioVentaSinIVA.Text = "Precio Venta sin IVA";
            // 
            // txtBoxPrecioCompraSinIVA
            // 
            txtBoxPrecioCompraSinIVA.Location = new Point(333, 287);
            txtBoxPrecioCompraSinIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioCompraSinIVA.Name = "txtBoxPrecioCompraSinIVA";
            txtBoxPrecioCompraSinIVA.Size = new Size(185, 27);
            txtBoxPrecioCompraSinIVA.TabIndex = 43;
            // 
            // lblPrecioCompraSinIVA
            // 
            lblPrecioCompraSinIVA.AutoSize = true;
            lblPrecioCompraSinIVA.Location = new Point(169, 287);
            lblPrecioCompraSinIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCompraSinIVA.Name = "lblPrecioCompraSinIVA";
            lblPrecioCompraSinIVA.Size = new Size(155, 20);
            lblPrecioCompraSinIVA.TabIndex = 42;
            lblPrecioCompraSinIVA.Text = "Precio Compra sin IVA";
            // 
            // txtBoxDescripcion
            // 
            txtBoxDescripcion.Location = new Point(333, 180);
            txtBoxDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtBoxDescripcion.Multiline = true;
            txtBoxDescripcion.Name = "txtBoxDescripcion";
            txtBoxDescripcion.Size = new Size(550, 60);
            txtBoxDescripcion.TabIndex = 41;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(237, 183);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 40;
            lblDescripcion.Text = "Descripción";
            // 
            // txtBoxClave
            // 
            txtBoxClave.Location = new Point(680, 143);
            txtBoxClave.Margin = new Padding(4, 5, 4, 5);
            txtBoxClave.Name = "txtBoxClave";
            txtBoxClave.Size = new Size(136, 27);
            txtBoxClave.TabIndex = 39;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(627, 143);
            lblClave.Margin = new Padding(4, 0, 4, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(45, 20);
            lblClave.TabIndex = 38;
            lblClave.Text = "Clave";
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Location = new Point(333, 143);
            txtBoxCodigo.Margin = new Padding(4, 5, 4, 5);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(136, 27);
            txtBoxCodigo.TabIndex = 37;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(266, 146);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 36;
            lblCodigo.Text = "Código";
            // 
            // txtBoxStock
            // 
            txtBoxStock.Location = new Point(333, 250);
            txtBoxStock.Margin = new Padding(4, 5, 4, 5);
            txtBoxStock.Name = "txtBoxStock";
            txtBoxStock.Size = new Size(136, 27);
            txtBoxStock.TabIndex = 35;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(279, 250);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 34;
            lblStock.Text = "Stock";
            // 
            // txtBoxStockCritico
            // 
            txtBoxStockCritico.Location = new Point(680, 250);
            txtBoxStockCritico.Margin = new Padding(4, 5, 4, 5);
            txtBoxStockCritico.Name = "txtBoxStockCritico";
            txtBoxStockCritico.Size = new Size(136, 27);
            txtBoxStockCritico.TabIndex = 33;
            // 
            // lblStockCritico
            // 
            lblStockCritico.AutoSize = true;
            lblStockCritico.Location = new Point(580, 250);
            lblStockCritico.Margin = new Padding(4, 0, 4, 0);
            lblStockCritico.Name = "lblStockCritico";
            lblStockCritico.Size = new Size(92, 20);
            lblStockCritico.TabIndex = 32;
            lblStockCritico.Text = "Stock Crítico";
            // 
            // txtBoxMarca
            // 
            txtBoxMarca.Location = new Point(680, 361);
            txtBoxMarca.Margin = new Padding(4, 5, 4, 5);
            txtBoxMarca.Name = "txtBoxMarca";
            txtBoxMarca.Size = new Size(181, 27);
            txtBoxMarca.TabIndex = 31;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(622, 361);
            lblMarca.Margin = new Padding(4, 0, 4, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 30;
            lblMarca.Text = "Marca";
            // 
            // txtBoxTipoProducto
            // 
            txtBoxTipoProducto.Location = new Point(333, 361);
            txtBoxTipoProducto.Margin = new Padding(4, 5, 4, 5);
            txtBoxTipoProducto.Name = "txtBoxTipoProducto";
            txtBoxTipoProducto.Size = new Size(181, 27);
            txtBoxTipoProducto.TabIndex = 29;
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.Location = new Point(201, 361);
            lblTipoProducto.Margin = new Padding(4, 0, 4, 0);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(124, 20);
            lblTipoProducto.TabIndex = 28;
            lblTipoProducto.Text = "Tipo de Producto";
            // 
            // txtBoxCategoria
            // 
            txtBoxCategoria.Location = new Point(333, 398);
            txtBoxCategoria.Margin = new Padding(4, 5, 4, 5);
            txtBoxCategoria.Name = "txtBoxCategoria";
            txtBoxCategoria.Size = new Size(181, 27);
            txtBoxCategoria.TabIndex = 27;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(251, 398);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 26;
            lblCategoria.Text = "Categoría";
            // 
            // txtBoxPrecioCompraConIVA
            // 
            txtBoxPrecioCompraConIVA.Location = new Point(333, 324);
            txtBoxPrecioCompraConIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioCompraConIVA.Name = "txtBoxPrecioCompraConIVA";
            txtBoxPrecioCompraConIVA.Size = new Size(185, 27);
            txtBoxPrecioCompraConIVA.TabIndex = 49;
            // 
            // lblPrecioCompraConIVA
            // 
            lblPrecioCompraConIVA.AutoSize = true;
            lblPrecioCompraConIVA.Location = new Point(163, 324);
            lblPrecioCompraConIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCompraConIVA.Name = "lblPrecioCompraConIVA";
            lblPrecioCompraConIVA.Size = new Size(161, 20);
            lblPrecioCompraConIVA.TabIndex = 48;
            lblPrecioCompraConIVA.Text = "Precio Compra con IVA";
            // 
            // txtBoxPrecioVentaConIVA
            // 
            txtBoxPrecioVentaConIVA.Location = new Point(680, 324);
            txtBoxPrecioVentaConIVA.Margin = new Padding(4, 5, 4, 5);
            txtBoxPrecioVentaConIVA.Name = "txtBoxPrecioVentaConIVA";
            txtBoxPrecioVentaConIVA.Size = new Size(185, 27);
            txtBoxPrecioVentaConIVA.TabIndex = 51;
            // 
            // lblPrecioVentaConIVA
            // 
            lblPrecioVentaConIVA.AutoSize = true;
            lblPrecioVentaConIVA.Location = new Point(527, 324);
            lblPrecioVentaConIVA.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVentaConIVA.Name = "lblPrecioVentaConIVA";
            lblPrecioVentaConIVA.Size = new Size(145, 20);
            lblPrecioVentaConIVA.TabIndex = 50;
            lblPrecioVentaConIVA.Text = "Precio Venta con IVA";
            // 
            // InventarioProductos
            // 
            ClientSize = new Size(1175, 491);
            Controls.Add(panelSuperior);
            Controls.Add(panelInferior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventarioProductos";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtBoxCodigoBarras;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonActualizar;
        private TextBox txtBoxPrecioVentaConIVA;
        private Label lblPrecioVentaConIVA;
        private TextBox txtBoxPrecioCompraConIVA;
        private Label lblPrecioCompraConIVA;
        private TextBox txtBoxUnidad;
        private Label lblUnidad;
        private TextBox txtBoxPrecioVentaSinIVA;
        private Label lblPrecioVentaSinIVA;
        private TextBox txtBoxPrecioCompraSinIVA;
        private Label lblPrecioCompraSinIVA;
        private TextBox txtBoxDescripcion;
        private Label lblDescripcion;
        private TextBox txtBoxClave;
        private Label lblClave;
        private TextBox txtBoxCodigo;
        private Label lblCodigo;
        private TextBox txtBoxStock;
        private Label lblStock;
        private TextBox txtBoxStockCritico;
        private Label lblStockCritico;
        private TextBox txtBoxMarca;
        private Label lblMarca;
        private TextBox txtBoxTipoProducto;
        private Label lblTipoProducto;
        private TextBox txtBoxCategoria;
        private Label lblCategoria;
    }
}