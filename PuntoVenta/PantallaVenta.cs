using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class PantallaVenta : Form
    {
        private string connectionString;

        public PantallaVenta(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscarProducto.Text.Trim();

            if (string.IsNullOrEmpty(buscar)) return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT idProducto, Codigo, Descripcion, PrecioVentaConIVA
                         FROM producto
                         WHERE Codigo = @codigo OR Clave = @codigo OR CodigoBarras = @codigo
                         LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", buscar);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idProducto = reader.GetInt32("idProducto");
                            string codigo = reader.GetString("Codigo");
                            string descripcion = reader.GetString("Descripcion");
                            decimal precio = reader.GetDecimal("PrecioVentaConIVA");

                            AgregarProductoDetalle(idProducto, codigo, descripcion, 1, precio);
                            txtBuscarProducto.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado");
                        }
                    }
                }
            }
        }
        private void AgregarProductoDetalle(int idProducto, string codigo, string descripcion, int cantidad, decimal precio)
        {
            decimal importe = cantidad * precio;

            dgvDetalleVenta.Rows.Add(codigo, descripcion, cantidad, precio.ToString("0.00"), importe.ToString("0.00"));
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                if (row.Cells["Importe"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Importe"].Value);
                }
            }

            txtTotal.Text = total.ToString("0.00");
        }
        private void AgregarProductoAVenta(Producto producto, int cantidad = 1)
        {
            // Verificar si ya existe el producto en el DataGridView
            foreach (DataGridViewRow fila in dgvDetalleVenta.Rows)
            {
                if (fila.Cells["idProducto"].Value != null && (int)fila.Cells["idProducto"].Value == producto.idProducto)
                {
                    // Si ya está, solo incrementamos la cantidad
                    int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    fila.Cells["Cantidad"].Value = cantidadActual + cantidad;

                    // Recalculamos el importe
                    fila.Cells["Importe"].Value = (cantidadActual + cantidad) * producto.Precio;
                    return;
                }
            }

            // Si no está, lo agregamos como nueva fila
            dgvDetalleVenta.Rows.Add(producto.idProducto, cantidad, producto.Descripcion, producto.Precio, cantidad * producto.Precio);
        }


        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (dgvDetalleVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            if (string.IsNullOrEmpty(cbTipoPago.Text))
            {
                MessageBox.Show("Seleccione un tipo de pago.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertar en venta
                        string insertVentaQuery = @"INSERT INTO venta (Fecha, Monto, tipoPago)
                                            VALUES (@Fecha, @Monto, @TipoPago)";
                        MySqlCommand cmdVenta = new MySqlCommand(insertVentaQuery, conn, transaction);
                        cmdVenta.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);
                        cmdVenta.Parameters.AddWithValue("@Monto", Convert.ToDecimal(txtTotal.Text));
                        cmdVenta.Parameters.AddWithValue("@TipoPago", cbTipoPago.Text);
                        cmdVenta.ExecuteNonQuery();

                        int idVenta = (int)cmdVenta.LastInsertedId;

                        // 2. Insertar en detalleventa
                        foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                        {
                            if (row.IsNewRow) continue;

                            int idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);

                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);


                            string insertDetalleQuery = @"INSERT INTO detalleventa 
                        (idVenta, idProducto, Cantidad, PrecioVenta)
                        VALUES (@idVenta, @idProducto, @Cantidad, @PrecioVenta)";

                            MySqlCommand cmdDetalle = new MySqlCommand(insertDetalleQuery, conn, transaction);
                            cmdDetalle.Parameters.AddWithValue("@idVenta", idVenta);
                            cmdDetalle.Parameters.AddWithValue("@idProducto", idProducto);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdDetalle.Parameters.AddWithValue("@PrecioVenta", precio);
                            cmdDetalle.ExecuteNonQuery();

                            // 3. Actualizar stock
                            ActualizarStock(conn, transaction, idProducto, cantidad);
                        }

                        transaction.Commit();
                        MessageBox.Show("Venta guardada correctamente.");
                        dgvDetalleVenta.Rows.Clear();
                        txtTotal.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error al guardar la venta: " + ex.Message);
                    }
                }
            }
        }
        private List<Producto> BuscarProductos(string textoBusqueda)
        {
            List<Producto> resultados = new List<Producto>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT idProducto, Descripcion, PrecioVentaConIVA, CodigoBarras, Clave, Codigo 
            FROM producto
            WHERE CodigoBarras = @texto OR Clave = @texto OR Codigo = @texto";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@texto", textoBusqueda);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultados.Add(new Producto
                            {
                                idProducto = reader.GetInt32("idProducto"),
                                Descripcion = reader.GetString("Descripcion"),
                                Precio = reader.GetDecimal("PrecioVentaConIVA"),
                                CodigoBarras = reader["CodigoBarras"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                Codigo = reader["Codigo"].ToString()
                            });
                        }
                    }
                }
            }

            return resultados;
        }


        private void ActualizarStock(MySqlConnection conn, MySqlTransaction transaction, int idProducto, int cantidadVendida)
        {
            string updateQuery = "UPDATE producto SET Stock = Stock - @cantidad WHERE idProducto = @idProducto";
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn, transaction);
            cmd.Parameters.AddWithValue("@cantidad", cantidadVendida);
            cmd.Parameters.AddWithValue("@idProducto", idProducto);
            cmd.ExecuteNonQuery();
        }


    }
}
