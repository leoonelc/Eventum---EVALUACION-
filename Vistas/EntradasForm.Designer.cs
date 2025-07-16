namespace Eventum.Vistas
{
    partial class EntradasForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.ComboBox cmbParticipante;
        private System.Windows.Forms.TextBox txtCodigoEntrada;
        private System.Windows.Forms.Button btnRegistrarEntrada;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.Label lblCodigoEntrada;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.cmbParticipante = new System.Windows.Forms.ComboBox();
            this.txtCodigoEntrada = new System.Windows.Forms.TextBox();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.lblCodigoEntrada = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(150, 30);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(200, 21);
            // 
            // cmbParticipante
            // 
            this.cmbParticipante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParticipante.FormattingEnabled = true;
            this.cmbParticipante.Location = new System.Drawing.Point(150, 70);
            this.cmbParticipante.Name = "cmbParticipante";
            this.cmbParticipante.Size = new System.Drawing.Size(200, 21);
            // 
            // txtCodigoEntrada
            // 
            this.txtCodigoEntrada.Location = new System.Drawing.Point(150, 110);
            this.txtCodigoEntrada.Name = "txtCodigoEntrada";
            this.txtCodigoEntrada.ReadOnly = true;
            this.txtCodigoEntrada.Size = new System.Drawing.Size(200, 20);
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(150, 150);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(200, 30);
            this.btnRegistrarEntrada.Text = "Registrar Entrada";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(20, 150);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 30);
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(50, 30);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Text = "Evento:";
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Location = new System.Drawing.Point(50, 70);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Text = "Participante:";
            // 
            // lblCodigoEntrada
            // 
            this.lblCodigoEntrada.AutoSize = true;
            this.lblCodigoEntrada.Location = new System.Drawing.Point(50, 110);
            this.lblCodigoEntrada.Name = "lblCodigoEntrada";
            this.lblCodigoEntrada.Text = "Código de Entrada:";
            // 
            // EntradasForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.lblCodigoEntrada);
            this.Controls.Add(this.lblParticipante);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.btnRegistrarEntrada);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtCodigoEntrada);
            this.Controls.Add(this.cmbParticipante);
            this.Controls.Add(this.cmbEvento);
            this.Name = "EntradasForm";
            this.Text = "Gestionar Entradas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
