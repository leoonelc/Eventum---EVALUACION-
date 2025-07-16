using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eventum.Controladores;
using Eventum.Modelos;

namespace Eventum.Vistas
{
    public partial class PagosForm : Form
    {
        private PagoController _pagoController;
        private ProductoController _productoController;
        private EventoController _eventoController;  // Controlador para los eventos
        private ParticipanteController _participanteController;  // Controlador para los participantes
        private List<Producto> _productos;
        private List<Evento> _eventos;  // Lista de eventos
        private List<Entrada> _entradas;  // Lista de entradas
        private List<Participante> _participantes;  // Lista de participantes

        public PagosForm()
        {
            InitializeComponent();
            _pagoController = new PagoController();
            _productoController = new ProductoController();
            _eventoController = new EventoController();  // Inicializar controlador de eventos
            _participanteController = new ParticipanteController();  // Inicializar controlador de participantes
        }

        private void PagosForm_Load(object sender, EventArgs e)
        {
            // Cargar productos disponibles (aunque no los mostremos en un DataGridView ahora)
            CargarProductos();

            // Cargar eventos en el ComboBox
            CargarEventos();

            // Cargar participantes en el ComboBox
            CargarParticipantes();

            // Cargar entradas disponibles en el ComboBox
            CargarEntradas();

            // Agregar métodos de pago al ComboBox
            cmbMetodoPago.Items.Add("Tarjeta de Crédito");
            cmbMetodoPago.Items.Add("Transferencia Bancaria");
            cmbMetodoPago.Items.Add("Efectivo");
        }

        private void CargarProductos()
        {
            // Cargar la lista de productos disponibles desde la base de datos
            _productos = _productoController.ListarProductos();
        }

        private void CargarEventos()
        {
            // Cargar los eventos disponibles desde la base de datos
            _eventos = _eventoController.ListarEventos();

            // Mostrar los eventos en el ComboBox
            cmbEvento.DataSource = _eventos;
            cmbEvento.DisplayMember = "Nombre";  // Mostrar el nombre del evento
            cmbEvento.ValueMember = "Id";  // Al seleccionar, usar el ID del evento
        }

        private void CargarEntradas()
        {
            // Cargar las entradas desde la base de datos
            _entradas = _pagoController.ListarEntradas();  // Método para obtener las entradas

            // Mostrar las entradas en el ComboBox
            cmbEntrada.DataSource = _entradas;
            cmbEntrada.DisplayMember = "CodigoEntrada";  // Mostrar el código de la entrada
            cmbEntrada.ValueMember = "Id";  // Al seleccionar, usar el ID de la entrada
        }

        private void CargarParticipantes()
        {
            // Cargar los participantes desde la base de datos
            _participantes = _participanteController.ListarParticipantes();

            // Mostrar los participantes en el ComboBox
            cmbParticipante.DataSource = _participantes;
            cmbParticipante.DisplayMember = "Nombre";  // Mostrar el nombre del participante
            cmbParticipante.ValueMember = "Id";  // Al seleccionar, usar el ID del participante
        }

        private void btnGenerarPago_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una entrada
            if (cmbEntrada.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una entrada.");
                return;
            }

            // Validar monto
            if (string.IsNullOrWhiteSpace(txtMonto.Text) || !decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Monto inválido. Ingrese un monto correcto.");
                return;
            }

            // Validar que se haya seleccionado un método de pago
            if (cmbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un método de pago.");
                return;
            }

            // Confirmar si el usuario está seguro de proceder
            var result = MessageBox.Show("¿Está seguro de proceder con el pago?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtener datos ingresados por el usuario
            int entradaId = (int)cmbEntrada.SelectedValue;  // Obtener ID de la entrada seleccionada
            int eventoId = (int)cmbEvento.SelectedValue;  // Obtener ID del evento seleccionado
            int participanteId = (int)cmbParticipante.SelectedValue;  // Obtener ID del participante seleccionado
            string metodoPago = cmbMetodoPago.SelectedItem.ToString();
            string estadoPago = "Pendiente";  // Estado por defecto
            DateTime fechaPago = DateTime.Now;

            // Crear objeto de pago
            Pago nuevoPago = new Pago
            {
                EntradaId = entradaId,
                EventoId = eventoId,
                ParticipanteId = participanteId,
                Monto = monto,
                MetodoPago = metodoPago,
                EstadoPago = estadoPago,
                FechaPago = fechaPago
            };

            // Guardar el pago en la base de datos
            bool exito = _pagoController.GenerarPago(nuevoPago);

            if (exito)
            {
                // No estamos agregando productos en un DataGridView, pero podemos registrar los productos asociados al pago
                foreach (var producto in _productos)  // Suponiendo que el producto se ha seleccionado de alguna manera
                {
                    int productoId = producto.Id;
                    int cantidad = 1;  // Aquí deberías definir cómo manejar la cantidad seleccionada
                    decimal precioTotal = cantidad * producto.Precio;  // Aquí calculamos el precio total de ese producto

                    // Asociar el producto con el pago
                    _pagoController.AsociarProductoConPago(nuevoPago.Id, productoId, cantidad);
                }

                // Mostrar mensaje de éxito
                MessageBox.Show("Pago generado con éxito. ¡Gracias por su compra!");
            }
            else
            {
                MessageBox.Show("Hubo un error al generar el pago.");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
        }
    }
}
