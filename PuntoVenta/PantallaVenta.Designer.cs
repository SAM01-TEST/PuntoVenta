namespace PuntoVenta
{
    partial class PantallaVenta
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBuscar = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            dgvDetalleVenta = new DataGridView();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnGuardarVenta = new Button();
            cbTipoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(10, 10);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(120, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar producto:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(154, 7);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(200, 27);
            txtBuscarProducto.TabIndex = 1;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(441, 10);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(100, 27);
            btnBuscarProducto.TabIndex = 2;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.ColumnHeadersHeight = 29;
            dgvDetalleVenta.Location = new Point(10, 50);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersWidth = 51;
            dgvDetalleVenta.Size = new Size(760, 250);
            dgvDetalleVenta.TabIndex = 3;
            // Definimos las columnas del DataGridView
            dgvDetalleVenta.Columns.Add("idProducto", "ID");
            dgvDetalleVenta.Columns["idProducto"].Visible = false;
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("Descripcion", "Descripción");
            dgvDetalleVenta.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalleVenta.Columns.Add("Importe", "Importe");
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(600, 320);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 27);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(650, 320);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(120, 27);
            txtTotal.TabIndex = 5;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.Location = new Point(600, 360);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(150, 30);
            btnGuardarVenta.TabIndex = 6;
            btnGuardarVenta.Text = "Guardar Venta";
            btnGuardarVenta.UseVisualStyleBackColor = true;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // cbTipoPago
            // 
            cbTipoPago.FormattingEnabled = true;
            cbTipoPago.Location = new Point(390, 317);
            cbTipoPago.Name = "cbTipoPago";
            cbTipoPago.Size = new Size(151, 28);
            cbTipoPago.TabIndex = 7;
            // 
            // PantallaVenta
            // 
            ClientSize = new Size(875, 428);
            Controls.Add(cbTipoPago);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnGuardarVenta);
            Name = "PantallaVenta";
            Text = "Pantalla de Venta";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
        private DataGridView dgvDetalleVenta;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnGuardarVenta;
        private ComboBox cbTipoPago;
    }
}
