using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoVenta
{
    public partial class PantallaPrincipal : Form
    {
        private Form currentForm = null; // Para mantener la referencia del formulario actual
        private string connectionString; // Almacena la cadena de conexión

        public PantallaPrincipal(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString; // Asigna la cadena de conexión
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            // Puedes inicializar algo aquí si es necesario
        }

        private void OpenFormInPanel(string formName)
        {
            // Cierra el formulario actual si hay uno abierto
            if (currentForm != null)
            {
                currentForm.Close();
            }

            try
            {
                // Usa reflexión para crear una instancia del formulario
                Type formType = Type.GetType($"PuntoVenta.{formName}");
                if (formType != null && typeof(Form).IsAssignableFrom(formType))
                {
                    // Crea una instancia del formulario pasando la cadena de conexión
                    Form form = (Form)Activator.CreateInstance(formType, connectionString);

                    // Configura el formulario para que se muestre dentro del Panel
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;

                    // Agrega el formulario al Panel
                    panel1.Controls.Add(form);
                    panel1.Tag = form;

                    // Muestra el formulario
                    form.Show();

                    // Actualiza la referencia al formulario actual
                    currentForm = form;
                }
                else
                {
                    MessageBox.Show($"No se encontró la pantalla: {formName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la pantalla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos de los botones
        private void buttonVentas_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaVenta");
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaCompra");
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaInicio");
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaClientes");
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaProveedores");
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaResumenes");
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaAdmin");
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("PantallaProductos");
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            // Lógica para cerrar sesión
            MessageBox.Show("Sesión cerrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            Login Inicio = new Login();
            Inicio.Show();
            this.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }
    }
}