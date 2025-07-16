using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eventum.Controladores;
using Eventum.Modelos;

namespace Eventum.Vistas
{
    public partial class ReportesForm : Form
    {
        private EventoController _eventoController;
        private ReporteController _reporteController;

        public ReportesForm()
        {
            InitializeComponent();
            _eventoController = new EventoController();
            _reporteController = new ReporteController();
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
            CargarEventos();

            // Configuración inicial de los DateTimePickers
            dtpFechaInicio.Value = DateTime.Today.AddDays(-7);
            dtpFechaFin.Value = DateTime.Today;

            dgvResumenVentas.AutoGenerateColumns = false;
            dgvResumenVentas.Columns.Clear();

            dgvResumenVentas.Columns.Add("NombreEvento", "Evento");
            dgvResumenVentas.Columns["NombreEvento"].DataPropertyName = "NombreEvento";

            dgvResumenVentas.Columns.Add("FechaInicio", "Fecha Inicio");
            dgvResumenVentas.Columns["FechaInicio"].DataPropertyName = "FechaInicio";

            dgvResumenVentas.Columns.Add("FechaFin", "Fecha Fin");
            dgvResumenVentas.Columns["FechaFin"].DataPropertyName = "FechaFin";

            dgvResumenVentas.Columns.Add("BoletosVendidos", "Boletos Vendidos");
            dgvResumenVentas.Columns["BoletosVendidos"].DataPropertyName = "BoletosVendidos";

            dgvResumenVentas.Columns.Add("TotalVendido", "Total Vendido");
            dgvResumenVentas.Columns["TotalVendido"].DataPropertyName = "TotalVendido";

            dgvResumenVentas.Columns.Add("FechaGeneracion", "Generado el");
            dgvResumenVentas.Columns["FechaGeneracion"].DataPropertyName = "FechaGeneracion";
        }

        private void CargarEventos()
        {
            var eventos = _eventoController.ListarEventos();
            cmbEvento.DataSource = eventos;
            cmbEvento.DisplayMember = "Nombre";
            cmbEvento.ValueMember = "Id";
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (cmbEvento.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un evento.");
                return;
            }

            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha final no puede ser menor a la fecha de inicio.");
                return;
            }

            int eventoId = (int)cmbEvento.SelectedValue;

            var reportes = _reporteController.ObtenerReportesPorEvento(eventoId, fechaInicio, fechaFin);

            if (reportes.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas para este rango de fechas.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvResumenVentas.DataSource = reportes;
        }
    }
}
