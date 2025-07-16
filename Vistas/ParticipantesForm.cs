using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eventum.Controladores;
using Eventum.Modelos;

namespace Eventum.Vistas
{
    public partial class ParticipantesForm : Form
    {
        private ParticipanteController _participanteController;
        private int participanteSeleccionadoId = -1;

        public ParticipantesForm()
        {
            InitializeComponent();
            _participanteController = new ParticipanteController();
        }

        private void ParticipantesForm_Load(object sender, EventArgs e)
        {
            CargarParticipantes(); // Cargar todos los participantes al cargar el formulario
        }

        private void CargarParticipantes()
        {
            var lista = _participanteController.ListarParticipantes();
            dgvUsuarios.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            var lista = _participanteController.BuscarParticipantes(filtro);
            dgvUsuarios.DataSource = lista;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar formulario actual
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var fila = dgvUsuarios.SelectedRows[0];
                participanteSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDocumentodeIdentidad.Text = fila.Cells["DocumentoIdentidad"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un participante para editar.", "Aviso");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (participanteSeleccionadoId == -1)
            {
                MessageBox.Show("No hay participante seleccionado.", "Error");
                return;
            }

            var participante = new Participante
            {
                Id = participanteSeleccionadoId,
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                DocumentoIdentidad = txtDocumentodeIdentidad.Text.Trim()
            };

            if (_participanteController.ActualizarParticipante(participante))
            {
                MessageBox.Show("Participante actualizado correctamente.");
                CargarParticipantes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el participante.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoParticipante = new Participante
            {
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                DocumentoIdentidad = txtDocumentodeIdentidad.Text.Trim()
            };

            bool exito = _participanteController.AgregarParticipante(nuevoParticipante);

            if (exito)
            {
                MessageBox.Show("Participante agregado correctamente.");
                CargarParticipantes();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el participante.");
            }
        }

        private void LimpiarCampos()
        {
            participanteSeleccionadoId = -1;
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDocumentodeIdentidad.Clear();
        }
    }
}
