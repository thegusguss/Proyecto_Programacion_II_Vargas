namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio15
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantidadVotantes = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVotosRegistrados = new System.Windows.Forms.Label();
            this.lblPorcentajeParticipacion = new System.Windows.Forms.Label();
            this.pbParticipacion = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTituloParticipacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextoParticipacion = new System.Windows.Forms.Label();
            this.lblVotosGanador = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.lblTextoGanador = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVotar = new System.Windows.Forms.Button();
            this.gbCandidatos = new System.Windows.Forms.GroupBox();
            this.rbtCandidatoC = new System.Windows.Forms.RadioButton();
            this.rbtCandidatoB = new System.Windows.Forms.RadioButton();
            this.rbtCandidatoA = new System.Windows.Forms.RadioButton();
            this.tabVotacion = new System.Windows.Forms.TabControl();
            this.tabPageVotacion = new System.Windows.Forms.TabPage();
            this.tabPageResultados = new System.Windows.Forms.TabPage();
            this.colCandidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVotosPendientes = new System.Windows.Forms.Label();
            this.picGanador = new System.Windows.Forms.PictureBox();
            this.lblVotosEmitidos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVotantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbCandidatos.SuspendLayout();
            this.tabVotacion.SuspendLayout();
            this.tabPageVotacion.SuspendLayout();
            this.tabPageResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(155, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Votación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVotosEmitidos);
            this.groupBox1.Controls.Add(this.lblVotosPendientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudCantidadVotantes);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion de la Votacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad de Votantes que participaran";
            // 
            // nudCantidadVotantes
            // 
            this.nudCantidadVotantes.Location = new System.Drawing.Point(25, 75);
            this.nudCantidadVotantes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadVotantes.Name = "nudCantidadVotantes";
            this.nudCantidadVotantes.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadVotantes.TabIndex = 0;
            this.nudCantidadVotantes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.dgvResultados);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 578);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de la Votacion ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVotosRegistrados);
            this.panel2.Controls.Add(this.lblPorcentajeParticipacion);
            this.panel2.Controls.Add(this.pbParticipacion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTituloParticipacion);
            this.panel2.Location = new System.Drawing.Point(7, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 107);
            this.panel2.TabIndex = 2;
            // 
            // lblVotosRegistrados
            // 
            this.lblVotosRegistrados.AutoSize = true;
            this.lblVotosRegistrados.Location = new System.Drawing.Point(112, 38);
            this.lblVotosRegistrados.Name = "lblVotosRegistrados";
            this.lblVotosRegistrados.Size = new System.Drawing.Size(13, 13);
            this.lblVotosRegistrados.TabIndex = 4;
            this.lblVotosRegistrados.Text = "0";
            // 
            // lblPorcentajeParticipacion
            // 
            this.lblPorcentajeParticipacion.AutoSize = true;
            this.lblPorcentajeParticipacion.Location = new System.Drawing.Point(432, 67);
            this.lblPorcentajeParticipacion.Name = "lblPorcentajeParticipacion";
            this.lblPorcentajeParticipacion.Size = new System.Drawing.Size(24, 13);
            this.lblPorcentajeParticipacion.TabIndex = 3;
            this.lblPorcentajeParticipacion.Text = "0 %";
            // 
            // pbParticipacion
            // 
            this.pbParticipacion.Location = new System.Drawing.Point(6, 67);
            this.pbParticipacion.Name = "pbParticipacion";
            this.pbParticipacion.Size = new System.Drawing.Size(402, 23);
            this.pbParticipacion.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Votos registrados:";
            // 
            // lblTituloParticipacion
            // 
            this.lblTituloParticipacion.AutoSize = true;
            this.lblTituloParticipacion.Location = new System.Drawing.Point(3, 11);
            this.lblTituloParticipacion.Name = "lblTituloParticipacion";
            this.lblTituloParticipacion.Size = new System.Drawing.Size(68, 13);
            this.lblTituloParticipacion.TabIndex = 0;
            this.lblTituloParticipacion.Text = "Participación";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTextoParticipacion);
            this.panel1.Controls.Add(this.lblVotosGanador);
            this.panel1.Controls.Add(this.lblGanador);
            this.panel1.Controls.Add(this.lblTextoGanador);
            this.panel1.Controls.Add(this.picGanador);
            this.panel1.Location = new System.Drawing.Point(7, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 117);
            this.panel1.TabIndex = 1;
            // 
            // lblTextoParticipacion
            // 
            this.lblTextoParticipacion.AutoSize = true;
            this.lblTextoParticipacion.Location = new System.Drawing.Point(381, 82);
            this.lblTextoParticipacion.Name = "lblTextoParticipacion";
            this.lblTextoParticipacion.Size = new System.Drawing.Size(139, 13);
            this.lblTextoParticipacion.TabIndex = 4;
            this.lblTextoParticipacion.Text = "Porcentaje de participación:";
            // 
            // lblVotosGanador
            // 
            this.lblVotosGanador.AutoSize = true;
            this.lblVotosGanador.Location = new System.Drawing.Point(396, 38);
            this.lblVotosGanador.Name = "lblVotosGanador";
            this.lblVotosGanador.Size = new System.Drawing.Size(35, 13);
            this.lblVotosGanador.TabIndex = 3;
            this.lblVotosGanador.Text = "label8";
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(132, 82);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(35, 13);
            this.lblGanador.TabIndex = 2;
            this.lblGanador.Text = "label7";
            // 
            // lblTextoGanador
            // 
            this.lblTextoGanador.AutoSize = true;
            this.lblTextoGanador.Location = new System.Drawing.Point(132, 38);
            this.lblTextoGanador.Name = "lblTextoGanador";
            this.lblTextoGanador.Size = new System.Drawing.Size(51, 13);
            this.lblTextoGanador.TabIndex = 1;
            this.lblTextoGanador.Text = "Ganador:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCandidato,
            this.colVotos,
            this.colPorcentaje});
            this.dgvResultados.Location = new System.Drawing.Point(3, 31);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(529, 261);
            this.dgvResultados.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCerrar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnVotar);
            this.groupBox3.Controls.Add(this.gbCandidatos);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(19, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 518);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Votacion";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(336, 434);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 45);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(178, 434);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 45);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(19, 434);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(109, 45);
            this.btnVotar.TabIndex = 3;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // gbCandidatos
            // 
            this.gbCandidatos.Controls.Add(this.rbtCandidatoC);
            this.gbCandidatos.Controls.Add(this.rbtCandidatoB);
            this.gbCandidatos.Controls.Add(this.rbtCandidatoA);
            this.gbCandidatos.Location = new System.Drawing.Point(6, 209);
            this.gbCandidatos.Name = "gbCandidatos";
            this.gbCandidatos.Size = new System.Drawing.Size(494, 199);
            this.gbCandidatos.TabIndex = 2;
            this.gbCandidatos.TabStop = false;
            this.gbCandidatos.Text = "Candidatos ";
            // 
            // rbtCandidatoC
            // 
            this.rbtCandidatoC.AutoSize = true;
            this.rbtCandidatoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCandidatoC.Location = new System.Drawing.Point(25, 147);
            this.rbtCandidatoC.Name = "rbtCandidatoC";
            this.rbtCandidatoC.Size = new System.Drawing.Size(182, 22);
            this.rbtCandidatoC.TabIndex = 3;
            this.rbtCandidatoC.TabStop = true;
            this.rbtCandidatoC.Text = "Candidato C - Eva Soto";
            this.rbtCandidatoC.UseVisualStyleBackColor = true;
            // 
            // rbtCandidatoB
            // 
            this.rbtCandidatoB.AutoSize = true;
            this.rbtCandidatoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCandidatoB.Location = new System.Drawing.Point(25, 97);
            this.rbtCandidatoB.Name = "rbtCandidatoB";
            this.rbtCandidatoB.Size = new System.Drawing.Size(177, 22);
            this.rbtCandidatoB.TabIndex = 2;
            this.rbtCandidatoB.TabStop = true;
            this.rbtCandidatoB.Text = "Candidato B - Luis Paz";
            this.rbtCandidatoB.UseVisualStyleBackColor = true;
            // 
            // rbtCandidatoA
            // 
            this.rbtCandidatoA.AutoSize = true;
            this.rbtCandidatoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCandidatoA.Location = new System.Drawing.Point(25, 47);
            this.rbtCandidatoA.Name = "rbtCandidatoA";
            this.rbtCandidatoA.Size = new System.Drawing.Size(178, 22);
            this.rbtCandidatoA.TabIndex = 1;
            this.rbtCandidatoA.TabStop = true;
            this.rbtCandidatoA.Text = "Candidato A - Ana Ruiz";
            this.rbtCandidatoA.UseVisualStyleBackColor = true;
            // 
            // tabVotacion
            // 
            this.tabVotacion.Controls.Add(this.tabPageVotacion);
            this.tabVotacion.Controls.Add(this.tabPageResultados);
            this.tabVotacion.Location = new System.Drawing.Point(12, 93);
            this.tabVotacion.Name = "tabVotacion";
            this.tabVotacion.SelectedIndex = 0;
            this.tabVotacion.Size = new System.Drawing.Size(570, 629);
            this.tabVotacion.TabIndex = 4;
            // 
            // tabPageVotacion
            // 
            this.tabPageVotacion.Controls.Add(this.groupBox3);
            this.tabPageVotacion.Location = new System.Drawing.Point(4, 22);
            this.tabPageVotacion.Name = "tabPageVotacion";
            this.tabPageVotacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVotacion.Size = new System.Drawing.Size(562, 603);
            this.tabPageVotacion.TabIndex = 0;
            this.tabPageVotacion.Text = "Votación";
            this.tabPageVotacion.UseVisualStyleBackColor = true;
            // 
            // tabPageResultados
            // 
            this.tabPageResultados.Controls.Add(this.groupBox2);
            this.tabPageResultados.Location = new System.Drawing.Point(4, 22);
            this.tabPageResultados.Name = "tabPageResultados";
            this.tabPageResultados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResultados.Size = new System.Drawing.Size(562, 603);
            this.tabPageResultados.TabIndex = 1;
            this.tabPageResultados.Text = "Resultados";
            this.tabPageResultados.UseVisualStyleBackColor = true;
            // 
            // colCandidato
            // 
            this.colCandidato.HeaderText = "Candidato";
            this.colCandidato.Name = "colCandidato";
            this.colCandidato.ReadOnly = true;
            // 
            // colVotos
            // 
            this.colVotos.HeaderText = "Votos";
            this.colVotos.Name = "colVotos";
            this.colVotos.ReadOnly = true;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.HeaderText = "% del total";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.ReadOnly = true;
            // 
            // lblVotosPendientes
            // 
            this.lblVotosPendientes.AutoSize = true;
            this.lblVotosPendientes.Location = new System.Drawing.Point(346, 77);
            this.lblVotosPendientes.Name = "lblVotosPendientes";
            this.lblVotosPendientes.Size = new System.Drawing.Size(83, 13);
            this.lblVotosPendientes.TabIndex = 5;
            this.lblVotosPendientes.Text = "Votos restantes:";
            // 
            // picGanador
            // 
            this.picGanador.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.taza;
            this.picGanador.Location = new System.Drawing.Point(36, 25);
            this.picGanador.Name = "picGanador";
            this.picGanador.Size = new System.Drawing.Size(70, 70);
            this.picGanador.TabIndex = 0;
            this.picGanador.TabStop = false;
            // 
            // lblVotosEmitidos
            // 
            this.lblVotosEmitidos.AutoSize = true;
            this.lblVotosEmitidos.Location = new System.Drawing.Point(233, 77);
            this.lblVotosEmitidos.Name = "lblVotosEmitidos";
            this.lblVotosEmitidos.Size = new System.Drawing.Size(91, 13);
            this.lblVotosEmitidos.TabIndex = 6;
            this.lblVotosEmitidos.Text = "Votos registrados:";
            // 
            // FrmEjercicio15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 767);
            this.Controls.Add(this.tabVotacion);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio15";
            this.Text = "FrmEjercicio15";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadVotantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbCandidatos.ResumeLayout(false);
            this.gbCandidatos.PerformLayout();
            this.tabVotacion.ResumeLayout(false);
            this.tabPageVotacion.ResumeLayout(false);
            this.tabPageResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidadVotantes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPorcentajeParticipacion;
        private System.Windows.Forms.ProgressBar pbParticipacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTituloParticipacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.GroupBox gbCandidatos;
        private System.Windows.Forms.RadioButton rbtCandidatoA;
        private System.Windows.Forms.RadioButton rbtCandidatoC;
        private System.Windows.Forms.RadioButton rbtCandidatoB;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblVotosRegistrados;
        private System.Windows.Forms.Label lblTextoParticipacion;
        private System.Windows.Forms.Label lblVotosGanador;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label lblTextoGanador;
        private System.Windows.Forms.PictureBox picGanador;
        private System.Windows.Forms.TabControl tabVotacion;
        private System.Windows.Forms.TabPage tabPageVotacion;
        private System.Windows.Forms.TabPage tabPageResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentaje;
        private System.Windows.Forms.Label lblVotosPendientes;
        private System.Windows.Forms.Label lblVotosEmitidos;
    }
}