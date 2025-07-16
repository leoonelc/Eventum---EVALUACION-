using System.Windows.Forms;

namespace Eventum.Vistas
{
    partial class ReportesForm
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbEvento;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Button btnGenerarReporte;
        private DataGridView dgvResumenVentas;
        private Label lblEvento;
        private Label lblFechaInicio;
        private Label lblFechaFin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbEvento = new ComboBox();
            this.dtpFechaInicio = new DateTimePicker();
            this.dtpFechaFin = new DateTimePicker();
            this.btnGenerarReporte = new Button();
            this.dgvResumenVentas = new DataGridView();
            this.lblEvento = new Label();
            this.lblFechaInicio = new Label();
            this.lblFechaFin = new Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVentas)).BeginInit();
            this.SuspendLayout();

            // 
            // lblEvento
            // 
            this.lblEvento.Location = new System.Drawing.Point(30, 20);
            this.lblEvento.Size = new System.Drawing.Size(100, 20);
            this.lblEvento.Text = "Evento:";

            // 
            // cmbEvento
            // 
            this.cmbEvento.Location = new System.Drawing.Point(130, 20);
            this.cmbEvento.Size = new System.Drawing.Size(200, 21);

            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Location = new System.Drawing.Point(30, 60);
            this.lblFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.lblFechaInicio.Text = "Desde:";

            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(130, 60);
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);

            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Location = new System.Drawing.Point(30, 100);
            this.lblFechaFin.Size = new System.Drawing.Size(100, 20);
            this.lblFechaFin.Text = "Hasta:";

            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(130, 100);
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);

            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(130, 140);
            this.btnGenerarReporte.Size = new System.Drawing.Size(200, 30);
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);

            // 
            // dgvResumenVentas
            // 
            this.dgvResumenVentas.Location = new System.Drawing.Point(30, 190);
            this.dgvResumenVentas.Size = new System.Drawing.Size(700, 250);
            this.dgvResumenVentas.AllowUserToAddRows = false;
            this.dgvResumenVentas.AllowUserToDeleteRows = false;
            this.dgvResumenVentas.ReadOnly = true;

            // 
            // ReportesForm
            // 
            this.ClientSize = new System.Drawing.Size(770, 470);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.dgvResumenVentas);
            this.Name = "ReportesForm";
            this.Text = "Reporte de Ventas por Evento";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumenVentas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
