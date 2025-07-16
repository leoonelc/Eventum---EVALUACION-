using System;
using System.Windows.Forms;
using Eventum.Vistas; // Asegúrate de que estas clases existan y estén en este namespace

namespace Eventum
{
    public partial class PanelPrincipalForm : Form
    {
        public PanelPrincipalForm()
        {
            InitializeComponent();
        }

        private void PanelPrincipalForm_Load(object sender, EventArgs e)
        {
            // Este evento se ejecutará cuando se cargue el formulario
            // Puedes personalizarlo si necesitas mostrar datos o usuario logueado, etc.
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            EventosForm eventosForm = new EventosForm();
            this.Hide();
            eventosForm.ShowDialog();
            this.Show();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            ParticipantesForm participantesForm = new ParticipantesForm();
            this.Hide();
            participantesForm.ShowDialog();
            this.Show();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            EntradasForm entradasForm = new EntradasForm();
            this.Hide();
            entradasForm.ShowDialog();
            this.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            PagosForm pagosForm = new PagosForm();
            this.Hide();
            pagosForm.ShowDialog();
            this.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            this.Hide();
            productosForm.ShowDialog();
            this.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e) // <-- NUEVO MÉTODO
        {
            ReportesForm reportesForm = new ReportesForm();
            this.Hide();
            reportesForm.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
