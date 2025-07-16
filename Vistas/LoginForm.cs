using System;
using System.Windows.Forms;
using Eventum.Controladores;

namespace Eventum.Vistas
{
    public partial class LoginForm : Form
    {
        private UsuarioController _controller;

        public LoginForm()
        {
            InitializeComponent();
            _controller = new UsuarioController();
        }

        // Evento que se dispara al cargar el formulario (mostrar el mensaje de bienvenida)
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Mensaje de bienvenida al iniciar la aplicación
            MessageBox.Show("¡Bienvenido a Eventum! Inicia sesión para continuar.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;

            try
            {
                // Validación del usuario
                if (_controller.ValidarUsuario(correo, contrasena))
                {
                    // Mensaje de bienvenida al iniciar sesión correctamente
                    MessageBox.Show("Bienvenido a Eventum, " + correo, "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirigir al panel principal
                    PanelPrincipalForm panel = new PanelPrincipalForm();
                    panel.Show();
                    this.Hide(); // Ocultar el formulario de login
                }
                else
                {
                    // Mensaje de error si las credenciales son incorrectas
                    MessageBox.Show("Correo o contraseña incorrectos. Intenta de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier otro error
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de registro
            RegistroForm registro = new RegistroForm();
            this.Hide();
            registro.ShowDialog();
            this.Show();
        }
    }
}
