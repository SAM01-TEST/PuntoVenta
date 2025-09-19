using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static PuntoVenta.PantallaVenta;

namespace PuntoVenta
{
    public partial class SeleccionarProductoForm : Form
    {
        public Producto ProductoSeleccionado { get; private set; }

        public SeleccionarProductoForm(List<Producto> productos)
        {
            InitializeComponent();

            dgvProductos.AutoGenerateColumns = false;

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "idProducto",
                Width = 50
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion",
                Width = 200
            });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Width = 80
            });

            dgvProductos.DataSource = productos;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                ProductoSeleccionado = dgvProductos.CurrentRow.DataBoundItem as Producto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecciona un producto.");
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccionar.PerformClick();
        }
    }
}
