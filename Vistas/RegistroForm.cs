using Eventum.Controladores;
using System;
using System.Windows.Forms;

namespace Eventum.Vistas
{
    public partial class RegistroForm : Form
    {
        private UsuarioController _controller;

        public RegistroForm()
        {
            InitializeComponent();
            _controller = new UsuarioController();
        }

        // Evento de clic en el botón de registro
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores del formulario
            string nombre = txtNombre.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Verifica si los campos no están vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            // Llama al controlador para registrar al usuario
            bool registrado = _controller.RegistrarUsuario(nombre, apellidos, correo, telefono, contrasena);

            // Muestra mensaje de éxito o error
            if (registrado)
            {
                MessageBox.Show("Usuario registrado correctamente.");
                this.Close();  // Cierra el formulario de registro
            }
            else
            {
                MessageBox.Show("El correo ya está en uso.");
            }
        }

        // Evento de clic en el botón de atrás
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario de registro y regresa al formulario anterior
        }

        // Métodos para manejar el comportamiento de "placeholder"
        private void TxtEnter(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;

            if (txtBox.Text == txtBox.Name.Replace("txt", ""))
            {
                txtBox.Text = "";
                txtBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtLeave(object sender, EventArgs e)
        {
            var txtBox = sender as TextBox;

            if (string.IsNullOrEmpty(txtBox.Text))
            {
                txtBox.Text = txtBox.Name.Replace("txt", ""); // Placeholder text
                txtBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
