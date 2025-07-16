namespace Eventum.Vistas
{
    partial class EventosForm
    {
        /// <summary>
        /// Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos en uso.
        /// </summary>
        /// <param name="disposing">true si los recursos gestionados deben ser eliminados; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador de Windows Forms. No modifique el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.lblEventos = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.txtLugarEvento = new System.Windows.Forms.TextBox();
            this.txtCapacidadEvento = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioEvento = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.Location = new System.Drawing.Point(120, 320);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(200, 30);
            this.btnAgregarEvento.TabIndex = 0;
            this.btnAgregarEvento.Text = "Agregar Evento";
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(400, 50);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(380, 300);
            this.dgvEventos.TabIndex = 1;
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblEventos.Location = new System.Drawing.Point(50, 20);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(157, 24);
            this.lblEventos.TabIndex = 2;
            this.lblEventos.Text = "Gestión de Eventos";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(120, 60);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEvento.TabIndex = 3;
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(120, 100);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(200, 20);
            this.txtDescripcionEvento.TabIndex = 4;
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.Location = new System.Drawing.Point(120, 140);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEvento.TabIndex = 5;
            // 
            // txtLugarEvento
            // 
            this.txtLugarEvento.Location = new System.Drawing.Point(120, 180);
            this.txtLugarEvento.Name = "txtLugarEvento";
            this.txtLugarEvento.Size = new System.Drawing.Size(200, 20);
            this.txtLugarEvento.TabIndex = 6;
            // 
            // txtCapacidadEvento
            // 
            this.txtCapacidadEvento.Location = new System.Drawing.Point(120, 220);
            this.txtCapacidadEvento.Name = "txtCapacidadEvento";
            this.txtCapacidadEvento.Size = new System.Drawing.Size(200, 20);
            this.txtCapacidadEvento.TabIndex = 7;
            // 
            // txtPrecioEvento
            // 
            this.txtPrecioEvento.Location = new System.Drawing.Point(120, 260);
            this.txtPrecioEvento.Name = "txtPrecioEvento";
            this.txtPrecioEvento.Size = new System.Drawing.Size(200, 20);
            this.txtPrecioEvento.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(50, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(50, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(50, 180);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(39, 13);
            this.lblLugar.TabIndex = 12;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(50, 220);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(62, 13);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(50, 260);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 13);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(20, 320);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 30);
            this.btnAtras.TabIndex = 15;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // EventosForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPrecioEvento);
            this.Controls.Add(this.txtCapacidadEvento);
            this.Controls.Add(this.txtLugarEvento);
            this.Controls.Add(this.dtpFechaEvento);
            this.Controls.Add(this.txtDescripcionEvento);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.btnAgregarEvento);
            this.Name = "EventosForm";
            this.Text = "EventosForm";
            this.Load += new System.EventHandler(this.EventosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapacidadEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.TextBox txtLugarEvento;
        private System.Windows.Forms.NumericUpDown txtCapacidadEvento;
        private System.Windows.Forms.NumericUpDown txtPrecioEvento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAtras;
    }
}
