namespace Eventum
{
    partial class PanelPrincipalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnParticipantes;
        private System.Windows.Forms.Button btnReportes; // NUEVO
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblBienvenido;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnParticipantes = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button(); // NUEVO
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btnEventos
            // 
            this.btnEventos.Location = new System.Drawing.Point(100, 100);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(200, 30);
            this.btnEventos.TabIndex = 0;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);

            // 
            // btnParticipantes
            // 
            this.btnParticipantes.Location = new System.Drawing.Point(100, 140);
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Size = new System.Drawing.Size(200, 30);
            this.btnParticipantes.TabIndex = 1;
            this.btnParticipantes.Text = "Participantes";
            this.btnParticipantes.UseVisualStyleBackColor = true;
            this.btnParticipantes.Click += new System.EventHandler(this.btnParticipantes_Click);

            // 
            // btnEntradas
            // 
            this.btnEntradas.Location = new System.Drawing.Point(100, 180);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(200, 30);
            this.btnEntradas.TabIndex = 2;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);

            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(100, 220);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(200, 30);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);

            // 
            // btnReportes (NUEVO)
            // 
            this.btnReportes.Location = new System.Drawing.Point(100, 260);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 30);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(100, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBienvenido.Location = new System.Drawing.Point(100, 40);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(200, 24);
            this.lblBienvenido.TabIndex = 6;
            this.lblBienvenido.Text = "Bienvenido a Eventum";

            // 
            // PanelPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes); // NUEVO
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnEntradas);
            this.Controls.Add(this.btnParticipantes);
            this.Controls.Add(this.btnEventos);
            this.Name = "PanelPrincipalForm";
            this.Text = "Panel Principal";
            this.Load += new System.EventHandler(this.PanelPrincipalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
