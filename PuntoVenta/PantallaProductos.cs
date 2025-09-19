using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class PantallaProductos : Form
    {
        private string connectionString;
        private int idProductoActual = -1; // Variable para almacenar el ID interno del producto

        public PantallaProductos(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void PantallaProductos_Load(object sender, EventArgs e)
        {
            CargarComboBox();

            // Configurar ComboBox para mostrar el nombre y almacenar el ID
            comboBoxCategoria.DisplayMember = "Value"; // Muestra el nombre
            comboBoxCategoria.ValueMember = "Key";     // Almacena el ID

            comboBoxTipoProducto.DisplayMember = "Value";
            comboBoxTipoProducto.ValueMember = "Key";

            comboBoxUnidad.DisplayMember = "Value";
            comboBoxUnidad.ValueMember = "Key";
        }

        private void CargarComboBox()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Cargar categorías
                    string queryCategorias = "SELECT idCategoria, Nombre FROM categoria";
                    MySqlCommand cmdCategorias = new MySqlCommand(queryCategorias, connection);
                    MySqlDataReader readerCategorias = cmdCategorias.ExecuteReader();
                    while (readerCategorias.Read())
                    {
                        comboBoxCategoria.Items.Add(new KeyValuePair<int, string>(readerCategorias.GetInt32("idCategoria"), readerCategorias.GetString("Nombre")));
                    }
                    readerCategorias.Close();

                    // Cargar tipos de producto
                    string queryTiposProducto = "SELECT idTipoProducto, Nombre FROM tipoProducto";
                    MySqlCommand cmdTiposProducto = new MySqlCommand(queryTiposProducto, connection);
                    MySqlDataReader readerTiposProducto = cmdTiposProducto.ExecuteReader();
                    while (readerTiposProducto.Read())
                    {
                        comboBoxTipoProducto.Items.Add(new KeyValuePair<int, string>(readerTiposProducto.GetInt32("idTipoProducto"), readerTiposProducto.GetString("Nombre")));
                    }
                    readerTiposProducto.Close();

                    // Cargar unidades
                    string queryUnidades = "SELECT idUnidad, Nombre FROM unidad";
                    MySqlCommand cmdUnidades = new MySqlCommand(queryUnidades, connection);
                    MySqlDataReader readerUnidades = cmdUnidades.ExecuteReader();
                    while (readerUnidades.Read())
                    {
                        comboBoxUnidad.Items.Add(new KeyValuePair<int, string>(readerUnidades.GetInt32("idUnidad"), readerUnidades.GetString("Nombre")));
                    }
                    readerUnidades.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }


        private int ObtenerIdSeleccionado(ComboBox listBox)
        {
            if (listBox.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)listBox.SelectedItem;
                return selectedItem.Key;
            }
            return -1; // Si no hay nada seleccionado
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBoxBusqueda.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese un término de búsqueda.");
                return;
            }

            string query = @"
                SELECT idProducto, CodigoBarras, Codigo, Clave, Descripcion 
                FROM producto
                WHERE CodigoBarras LIKE @busqueda 
                   OR Codigo LIKE @busqueda 
                   OR Clave LIKE @busqueda 
                   OR Descripcion LIKE @busqueda";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", $"%{busqueda}%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            List<string> resultados = new List<string>();

                            while (reader.Read())
                            {
                                string resultado = $"ID: {reader["idProducto"]}, Código: {reader["Codigo"]}, Clave: {reader["Clave"]}, Descripción: {reader["Descripcion"]}";
                                resultados.Add(resultado);
                            }

                            if (resultados.Count == 1)
                            {
                                // Si hay un solo resultado, llenar los campos directamente
                                idProductoActual = Convert.ToInt32(resultados[0].Split(',')[0].Split(':')[1].Trim());
                                LlenarCamposConProducto(idProductoActual);
                            }
                            else if (resultados.Count > 1)
                            {
                                // Si hay múltiples resultados, mostrarlos en un ListBox
                                listBoxResultados.DataSource = resultados;
                                listBoxResultados.Visible = true;
                                txtBoxBusqueda.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron resultados.");
                            }
                        } // El DataReader se cierra automáticamente aquí
                    }
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void LlenarCamposConProducto(int idProducto)
        {
            string query = "SELECT * FROM producto WHERE idProducto = @idProducto";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtBoxCodigoBarras.Text = reader["CodigoBarras"].ToString();
                                SeleccionarItemEnComboBox(comboBoxCategoria, Convert.ToInt32(reader["idCategoria"]));
                                SeleccionarItemEnComboBox(comboBoxTipoProducto, Convert.ToInt32(reader["idTipoProducto"]));
                                txtBoxMarca.Text = reader["Marca"].ToString();
                                txtBoxStockCritico.Text = reader["StockCritico"].ToString();
                                txtBoxStock.Text = reader["Stock"].ToString();
                                txtBoxCodigo.Text = reader["Codigo"].ToString();
                                txtBoxClave.Text = reader["Clave"].ToString();
                                txtBoxDescripcion.Text = reader["Descripcion"].ToString();
                                txtBoxPrecioCompraSinIVA.Text = reader["PrecioCompraSinIVA"].ToString();
                                txtBoxPrecioVentaSinIVA.Text = reader["PrecioVentaSinIVA"].ToString();
                                SeleccionarItemEnComboBox(comboBoxUnidad, Convert.ToInt32(reader["idUnidad"]));
                                txtBoxPrecioCompraConIVA.Text = reader["PrecioCompraConIVA"].ToString();
                                txtBoxPrecioVentaConIVA.Text = reader["PrecioVentaConIVA"].ToString();
                            }
                        } // El DataReader se cierra automáticamente aquí
                    }
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto: " + ex.Message);
            }
        }

        private void SeleccionarItemEnComboBox(ComboBox comboBox, int id)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                KeyValuePair<int, string> item = (KeyValuePair<int, string>)comboBox.Items[i];
                if (item.Key == id)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrEmpty(txtBoxDescripcion.Text) || string.IsNullOrEmpty(txtBoxPrecioVentaSinIVA.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.");
                return;
            }

            // Obtener IDs seleccionados
            int idCategoria = ObtenerIdSeleccionado(comboBoxCategoria);
            int idTipoProducto = ObtenerIdSeleccionado(comboBoxTipoProducto);
            int idUnidad = ObtenerIdSeleccionado(comboBoxUnidad);

            if (idCategoria == -1 || idTipoProducto == -1 || idUnidad == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría, tipo de producto y unidad.");
                return;
            }

            // Calcular precios si es necesario
            decimal precioVentaSinIVA = Convert.ToDecimal(txtBoxPrecioVentaSinIVA.Text);
            decimal precioVentaConIVA = precioVentaSinIVA * 1.16m; // Suponiendo un IVA del 16%

            string query = @"
        INSERT INTO producto (CodigoBarras, idCategoria, idTipoProducto, Marca, StockCritico, Stock, Codigo, Clave, Descripcion, PrecioCompraSinIVA, PrecioVentaSinIVA, idUnidad)
        VALUES (@CodigoBarras, @idCategoria, @idTipoProducto, @Marca, @StockCritico, @Stock, @Codigo, @Clave, @Descripcion, @PrecioCompraSinIVA, @PrecioVentaSinIVA, @idUnidad)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodigoBarras", txtBoxCodigoBarras.Text);
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                        cmd.Parameters.AddWithValue("@Marca", txtBoxMarca.Text);
                        cmd.Parameters.AddWithValue("@StockCritico", Convert.ToInt32(txtBoxStockCritico.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtBoxStock.Text));
                        cmd.Parameters.AddWithValue("@Codigo", txtBoxCodigo.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtBoxClave.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtBoxDescripcion.Text);
                        cmd.Parameters.AddWithValue("@PrecioCompraSinIVA", Convert.ToDecimal(txtBoxPrecioCompraSinIVA.Text));
                        cmd.Parameters.AddWithValue("@PrecioVentaSinIVA", precioVentaSinIVA);
                        cmd.Parameters.AddWithValue("@idUnidad", idUnidad);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto insertado correctamente.");
                    } // El comando se libera automáticamente aquí
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (idProductoActual == -1)
            {
                MessageBox.Show("Por favor, busque un producto antes de actualizarlo.");
                return;
            }

            // Obtener IDs seleccionados
            int idCategoria = ObtenerIdSeleccionado(comboBoxCategoria);
            int idTipoProducto = ObtenerIdSeleccionado(comboBoxTipoProducto);
            int idUnidad = ObtenerIdSeleccionado(comboBoxUnidad);

            if (idCategoria == -1 || idTipoProducto == -1 || idUnidad == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría, tipo de producto y unidad.");
                return;
            }

            string query = @"
        UPDATE producto 
        SET CodigoBarras = @CodigoBarras, idCategoria = @idCategoria, idTipoProducto = @idTipoProducto, Marca = @Marca, StockCritico = @StockCritico, Stock = @Stock, Codigo = @Codigo, Clave = @Clave, Descripcion = @Descripcion, PrecioCompraSinIVA = @PrecioCompraSinIVA, PrecioVentaSinIVA = @PrecioVentaSinIVA, idUnidad = @idUnidad
        WHERE idProducto = @idProducto";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CodigoBarras", txtBoxCodigoBarras.Text);
                        cmd.Parameters.AddWithValue("@idCategoria", idCategoria);
                        cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto);
                        cmd.Parameters.AddWithValue("@Marca", txtBoxMarca.Text);
                        cmd.Parameters.AddWithValue("@StockCritico", Convert.ToInt32(txtBoxStockCritico.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtBoxStock.Text));
                        cmd.Parameters.AddWithValue("@Codigo", txtBoxCodigo.Text);
                        cmd.Parameters.AddWithValue("@Clave", txtBoxClave.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtBoxDescripcion.Text);
                        cmd.Parameters.AddWithValue("@PrecioCompraSinIVA", Convert.ToDecimal(txtBoxPrecioCompraSinIVA.Text));
                        cmd.Parameters.AddWithValue("@PrecioVentaSinIVA", Convert.ToDecimal(txtBoxPrecioVentaSinIVA.Text));
                        cmd.Parameters.AddWithValue("@idUnidad", idUnidad);
                        cmd.Parameters.AddWithValue("@idProducto", idProductoActual);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto actualizado correctamente.");
                    } // El comando se libera automáticamente aquí
                } // La conexión se cierra automáticamente aquí
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoActual == -1)
            {
                MessageBox.Show("Por favor, busque un producto antes de eliminarlo.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM producto WHERE idProducto = @idProducto";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@idProducto", idProductoActual);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Producto eliminado correctamente.");
                            LimpiarCampos();
                        } // El comando se libera automáticamente aquí
                    } // La conexión se cierra automáticamente aquí
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtBoxCodigoBarras.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxTipoProducto.SelectedIndex = -1;
            txtBoxMarca.Clear();
            txtBoxStockCritico.Clear();
            txtBoxStock.Clear();
            txtBoxCodigo.Clear();
            txtBoxClave.Clear();
            txtBoxDescripcion.Clear();
            txtBoxPrecioCompraSinIVA.Clear();
            txtBoxPrecioVentaSinIVA.Clear();
            comboBoxUnidad.SelectedIndex = -1;
            txtBoxPrecioCompraConIVA.Clear();
            txtBoxPrecioVentaConIVA.Clear();
            idProductoActual = -1;
        }

        private void txtBoxPrecioVentaSinIVA_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxPrecioVentaSinIVA.Text, out decimal precioSinIVA))
            {
                decimal precioConIVA = precioSinIVA * 1.16m; // Suponiendo un IVA del 16%
                txtBoxPrecioVentaConIVA.Text = precioConIVA.ToString("0.00");
            }
        }

        private void txtBoxPrecioVentaConIVA_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBoxPrecioVentaConIVA.Text, out decimal precioConIVA))
            {
                decimal precioSinIVA = precioConIVA / 1.16m; // Suponiendo un IVA del 16%
                txtBoxPrecioVentaSinIVA.Text = precioSinIVA.ToString("0.00");
            }
        }
        private void listBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedItem != null)
            {
                string selectedItem = listBoxResultados.SelectedItem.ToString();
                int idProducto = int.Parse(selectedItem.Split(',')[0].Split(':')[1].Trim());
                idProductoActual = idProducto;
                LlenarCamposConProducto(idProductoActual);
                listBoxResultados.Visible = false;
                txtBoxBusqueda.Visible = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
