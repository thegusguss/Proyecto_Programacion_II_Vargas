namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio06));
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtSaldoRestante = new System.Windows.Forms.TextBox();
            this.txtCantidadBilletes = new System.Windows.Forms.TextBox();
            this.txtRetirado = new System.Windows.Forms.TextBox();
            this.txtSaldoAnterior = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvBilletes = new System.Windows.Forms.DataGridView();
            this.Denominación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilletes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(316, 179);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 22);
            this.txtMonto.TabIndex = 53;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(159, 182);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(95, 16);
            this.lblMonto.TabIndex = 52;
            this.lblMonto.Text = "Monto a retirar:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(543, 306);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(159, 63);
            this.btnCerrar.TabIndex = 51;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtSaldoRestante
            // 
            this.txtSaldoRestante.Location = new System.Drawing.Point(301, 570);
            this.txtSaldoRestante.Name = "txtSaldoRestante";
            this.txtSaldoRestante.Size = new System.Drawing.Size(170, 22);
            this.txtSaldoRestante.TabIndex = 49;
            // 
            // txtCantidadBilletes
            // 
            this.txtCantidadBilletes.Location = new System.Drawing.Point(301, 530);
            this.txtCantidadBilletes.Name = "txtCantidadBilletes";
            this.txtCantidadBilletes.Size = new System.Drawing.Size(170, 22);
            this.txtCantidadBilletes.TabIndex = 48;
            // 
            // txtRetirado
            // 
            this.txtRetirado.Location = new System.Drawing.Point(301, 495);
            this.txtRetirado.Name = "txtRetirado";
            this.txtRetirado.Size = new System.Drawing.Size(170, 22);
            this.txtRetirado.TabIndex = 47;
            // 
            // txtSaldoAnterior
            // 
            this.txtSaldoAnterior.Location = new System.Drawing.Point(301, 452);
            this.txtSaldoAnterior.Name = "txtSaldoAnterior";
            this.txtSaldoAnterior.Size = new System.Drawing.Size(170, 22);
            this.txtSaldoAnterior.TabIndex = 46;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(144, 567);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(97, 16);
            this.lblPromedio.TabIndex = 45;
            this.lblPromedio.Text = "Saldo restante:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(144, 530);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(110, 16);
            this.lblMenor.TabIndex = 44;
            this.lblMenor.Text = "Cantidad billetes:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(144, 492);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(96, 16);
            this.lblMayor.TabIndex = 43;
            this.lblMayor.Text = "Monto retirado:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(144, 455);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 16);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Saldo anterior:";
            // 
            // dgvBilletes
            // 
            this.dgvBilletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denominación,
            this.Cantidad});
            this.dgvBilletes.Location = new System.Drawing.Point(122, 233);
            this.dgvBilletes.Name = "dgvBilletes";
            this.dgvBilletes.RowHeadersWidth = 51;
            this.dgvBilletes.RowTemplate.Height = 24;
            this.dgvBilletes.Size = new System.Drawing.Size(368, 184);
            this.dgvBilletes.TabIndex = 41;
            // 
            // Denominación
            // 
            this.Denominación.HeaderText = "Denominación";
            this.Denominación.MinimumWidth = 6;
            this.Denominación.Name = "Denominación";
            this.Denominación.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(316, 146);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(150, 22);
            this.txtSaldo.TabIndex = 39;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(159, 149);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(112, 16);
            this.lblSaldo.TabIndex = 38;
            this.lblSaldo.Text = "Saldo disponible:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(157, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(292, 29);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "CAJERO AUTOMÁTICO";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(543, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 63);
            this.btnLimpiar.TabIndex = 50;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetirar.Image")));
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirar.Location = new System.Drawing.Point(543, 146);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(159, 63);
            this.btnRetirar.TabIndex = 40;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // FrmEjercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSaldoRestante);
            this.Controls.Add(this.txtCantidadBilletes);
            this.Controls.Add(this.txtRetirado);
            this.Controls.Add(this.txtSaldoAnterior);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvBilletes);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio06";
            this.Text = "FrmEjercicio06";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilletes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtSaldoRestante;
        private System.Windows.Forms.TextBox txtCantidadBilletes;
        private System.Windows.Forms.TextBox txtRetirado;
        private System.Windows.Forms.TextBox txtSaldoAnterior;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvBilletes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTitulo;
    }
}