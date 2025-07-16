using System;
using System.Windows.Forms;
using Eventum.Modelos;
using Eventum.Controladores;

namespace Eventum.Vistas
{
    public partial class EventosForm : Form
    {
        private readonly EventoController _eventoController;

        public EventosForm()
        {
            InitializeComponent();
            _eventoController = new EventoController();
        }

        private void EventosForm_Load(object sender, EventArgs e)
        {
            // Cargar eventos existentes en el DataGrid
            CargarEventos();
        }

        private void CargarEventos()
        {
            dgvEventos.DataSource = _eventoController.ListarEventos();
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            // Crear un nuevo evento con los datos ingresados
            Evento nuevoEvento = new Evento
            {
                Nombre = txtNombreEvento.Text,
                Descripcion = txtDescripcionEvento.Text,
                Fecha = dtpFechaEvento.Value,
                Lugar = txtLugarEvento.Text,
                Capacidad = (int)txtCapacidadEvento.Value,
                Precio = txtPrecioEvento.Value
            };

            // Agregar el evento a la base de datos
            bool exito = _eventoController.AgregarEvento(nuevoEvento);

            if (exito)
            {
                MessageBox.Show("Evento agregado con éxito.");
                CargarEventos();  // Recargar la lista de eventos
            }
            else
            {
                MessageBox.Show("Hubo un error al agregar el evento.");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario y regresar al formulario anterior
            this.Close();
        }
    }
}
