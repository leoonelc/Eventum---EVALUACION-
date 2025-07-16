namespace Eventum.Vistas
{
    partial class PagosForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Button btnGenerarPago;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.ComboBox cmbEntrada;
        private System.Windows.Forms.ComboBox cmbParticipante;

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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnGenerarPago = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.cmbEntrada = new System.Windows.Forms.ComboBox();
            this.cmbParticipante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(150, 160);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 1;

            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(150, 200);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(200, 21);
            this.cmbMetodoPago.TabIndex = 2;

            // 
            // btnGenerarPago
            // 
            this.btnGenerarPago.Location = new System.Drawing.Point(150, 260);
            this.btnGenerarPago.Name = "btnGenerarPago";
            this.btnGenerarPago.Size = new System.Drawing.Size(200, 30);
            this.btnGenerarPago.TabIndex = 4;
            this.btnGenerarPago.Text = "Generar Pago";
            this.btnGenerarPago.UseVisualStyleBackColor = true;
            this.btnGenerarPago.Click += new System.EventHandler(this.btnGenerarPago_Click);

            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(19, 260);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 30);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);

            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(50, 40);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(44, 13);
            this.lblEvento.TabIndex = 6;
            this.lblEvento.Text = "Evento:";

            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(50, 160);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 7;
            this.lblMonto.Text = "Monto:";

            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(50, 200);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(89, 13);
            this.lblMetodoPago.TabIndex = 8;
            this.lblMetodoPago.Text = "Método de Pago:";

            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Location = new System.Drawing.Point(50, 120);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(66, 13);
            this.lblParticipante.TabIndex = 10;
            this.lblParticipante.Text = "Participante:";

            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(150, 40);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(200, 21);
            this.cmbEvento.TabIndex = 11;

            // 
            // cmbEntrada
            // 
            this.cmbEntrada.FormattingEnabled = true;
            this.cmbEntrada.Location = new System.Drawing.Point(150, 80);
            this.cmbEntrada.Name = "cmbEntrada";
            this.cmbEntrada.Size = new System.Drawing.Size(200, 21);
            this.cmbEntrada.TabIndex = 12;

            // 
            // cmbParticipante
            // 
            this.cmbParticipante.FormattingEnabled = true;
            this.cmbParticipante.Location = new System.Drawing.Point(150, 120);
            this.cmbParticipante.Name = "cmbParticipante";
            this.cmbParticipante.Size = new System.Drawing.Size(200, 21);
            this.cmbParticipante.TabIndex = 13;

            // 
            // PagosForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 350);  // Ajusta el tamaño para que se vea todo
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.cmbEntrada);
            this.Controls.Add(this.cmbParticipante);
            this.Controls.Add(this.lblParticipante);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnGenerarPago);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.txtMonto);
            this.Name = "PagosForm";
            this.Text = "Generar Pago";
            this.Load += new System.EventHandler(this.PagosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
