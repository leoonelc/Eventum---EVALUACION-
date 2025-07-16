using System;
using System.Windows.Forms;
using Eventum.Modelos;
using Eventum.Controladores;
using System.Collections.Generic;

namespace Eventum.Vistas
{
    public partial class EntradasForm : Form
    {
        private readonly EventoController _eventoController;
        private readonly ParticipanteController _participanteController;
        private readonly EntradaController _entradaController;

        public EntradasForm()
        {
            InitializeComponent();
            _eventoController = new EventoController();
            _participanteController = new ParticipanteController();
            _entradaController = new EntradaController();

            this.Load += EntradasForm_Load; // Asegurarse de asignar el evento Load
        }

        private void EntradasForm_Load(object sender, EventArgs e)
        {
            // Cargar eventos
            var eventos = _eventoController.ListarEventos();
            cmbEvento.DataSource = eventos;
            cmbEvento.DisplayMember = "Nombre";
            cmbEvento.ValueMember = "Id";

            // Cargar participantes
            var participantes = _participanteController.ListarParticipantes();
            if (participantes == null || participantes.Count == 0)
            {
                MessageBox.Show("No hay participantes disponibles.", "Aviso");
            }
            else
            {
                cmbParticipante.DataSource = participantes;
                cmbParticipante.DisplayMember = "Nombre";
                cmbParticipante.ValueMember = "Id";
            }

            // Generar código de entrada
            txtCodigoEntrada.Text = GenerarCodigoEntrada();
        }

        private string GenerarCodigoEntrada()
        {
            return Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoEntrada.Text))
            {
                MessageBox.Show("El código de entrada no puede estar vacío.");
                return;
            }

            int eventoId = (int)cmbEvento.SelectedValue;
            int participanteId = (int)cmbParticipante.SelectedValue;
            string codigoEntrada = txtCodigoEntrada.Text;

            Entrada nuevaEntrada = new Entrada
            {
                EventoId = eventoId,
                ParticipanteId = participanteId,
                CodigoEntrada = codigoEntrada
            };

            bool exito = _entradaController.RegistrarEntrada(nuevaEntrada);

            if (exito)
            {
                MessageBox.Show("Entrada registrada con éxito.");
                txtCodigoEntrada.Text = GenerarCodigoEntrada(); // Generar nuevo código
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar la entrada.");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
