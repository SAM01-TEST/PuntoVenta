using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text.Trim();
            string contrasena = textBoxContrasena.Text.Trim();

            string connectionString = $"Server=localhost;Database=puntoventa;User ID={usuario};Password={contrasena};";

            try
            {
                // Crear la conexión
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consultar el rol del usuario conectado
                    string queryRol = "SELECT CURRENT_ROLE();"; // Cambiar a CURRENT_ROLE() para obtener el rol
                    MySqlCommand cmd = new MySqlCommand(queryRol, connection);

                    string rol = cmd.ExecuteScalar()?.ToString() ?? "SinRol";

                    // Mostrar mensaje de bienvenida
                    MessageBox.Show($"¡Bienvenido, {usuario}! Tu rol es: {rol}.", "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Guardar conexión y rol activo
                    UsuarioActivo.Usuario = usuario;
                    UsuarioActivo.Conexion = connection; // Guardar la cadena de conexión, no la conexión abierta
                    UsuarioActivo.Rol = rol;

                    // Redirigir al formulario principal
                    PantallaPrincipal formPrincipal = new PantallaPrincipal(connectionString);
                    this.Hide();
                    formPrincipal.Show();
                } // La conexión se cierra automáticamente aquí
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    // Clase para gestionar el usuario activo
    public static class UsuarioActivo
    {
        public static string Usuario { get; set; }
        public static MySqlConnection Conexion { get; set; }
        public static string Rol { get; set; }

        public static void CerrarSesion()
        {
            if (Conexion != null && Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
            Usuario = null;
            Rol = null;
        }
    }
}
