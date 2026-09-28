namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio05
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEleccion = new System.Windows.Forms.Label();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.btnSiguienteRonda = new System.Windows.Forms.Button();
            this.gbxRondas = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gbxVictorias = new System.Windows.Forms.GroupBox();
            this.dgvVictorias = new System.Windows.Forms.DataGridView();
            this.lblCompu = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.Ronda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Computadora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResultadoFinal = new System.Windows.Forms.TextBox();
            this.pcbUsuario = new System.Windows.Forms.PictureBox();
            this.pcbComputadora = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxRondas.SuspendLayout();
            this.gbxVictorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputadora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(212, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(410, 32);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Juego: Piedra, Papel o Tijera";
            // 
            // lblEleccion
            // 
            this.lblEleccion.AutoSize = true;
            this.lblEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleccion.Location = new System.Drawing.Point(43, 115);
            this.lblEleccion.Name = "lblEleccion";
            this.lblEleccion.Size = new System.Drawing.Size(217, 18);
            this.lblEleccion.TabIndex = 15;
            this.lblEleccion.Text = "Elige: Piedra, Papel o Tijera";
            // 
            // btnPiedra
            // 
            this.btnPiedra.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.puno;
            this.btnPiedra.Location = new System.Drawing.Point(46, 144);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(96, 87);
            this.btnPiedra.TabIndex = 16;
            this.btnPiedra.Text = "Piedra";
            this.btnPiedra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.mano;
            this.btnPapel.Location = new System.Drawing.Point(167, 144);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(96, 87);
            this.btnPapel.TabIndex = 17;
            this.btnPapel.Text = "Papel";
            this.btnPapel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.tijeras;
            this.btnTijera.Location = new System.Drawing.Point(286, 144);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(96, 87);
            this.btnTijera.TabIndex = 18;
            this.btnTijera.Text = "Tijera";
            this.btnTijera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnSiguienteRonda
            // 
            this.btnSiguienteRonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteRonda.Location = new System.Drawing.Point(46, 461);
            this.btnSiguienteRonda.Name = "btnSiguienteRonda";
            this.btnSiguienteRonda.Size = new System.Drawing.Size(183, 42);
            this.btnSiguienteRonda.TabIndex = 19;
            this.btnSiguienteRonda.Text = "Siguiente Ronda";
            this.btnSiguienteRonda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguienteRonda.UseVisualStyleBackColor = true;
            this.btnSiguienteRonda.Click += new System.EventHandler(this.btnSiguienteRonda_Click);
            // 
            // gbxRondas
            // 
            this.gbxRondas.Controls.Add(this.pcbComputadora);
            this.gbxRondas.Controls.Add(this.pcbUsuario);
            this.gbxRondas.Controls.Add(this.lblVs);
            this.gbxRondas.Controls.Add(this.lblCompu);
            this.gbxRondas.Controls.Add(this.txtResultado);
            this.gbxRondas.Controls.Add(this.lblResultado);
            this.gbxRondas.Controls.Add(this.lblUsuario);
            this.gbxRondas.Location = new System.Drawing.Point(46, 258);
            this.gbxRondas.Name = "gbxRondas";
            this.gbxRondas.Size = new System.Drawing.Size(336, 188);
            this.gbxRondas.TabIndex = 20;
            this.gbxRondas.TabStop = false;
            this.gbxRondas.Text = "Ronda 1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Navy;
            this.lblUsuario.Location = new System.Drawing.Point(50, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(6, 156);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 16);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(84, 153);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(246, 22);
            this.txtResultado.TabIndex = 2;
            // 
            // gbxVictorias
            // 
            this.gbxVictorias.Controls.Add(this.dgvVictorias);
            this.gbxVictorias.Location = new System.Drawing.Point(426, 115);
            this.gbxVictorias.Name = "gbxVictorias";
            this.gbxVictorias.Size = new System.Drawing.Size(333, 250);
            this.gbxVictorias.TabIndex = 21;
            this.gbxVictorias.TabStop = false;
            this.gbxVictorias.Text = "Victorias";
            // 
            // dgvVictorias
            // 
            this.dgvVictorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVictorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ronda,
            this.Usuario,
            this.Computadora});
            this.dgvVictorias.Location = new System.Drawing.Point(6, 21);
            this.dgvVictorias.Name = "dgvVictorias";
            this.dgvVictorias.RowHeadersWidth = 51;
            this.dgvVictorias.RowTemplate.Height = 24;
            this.dgvVictorias.Size = new System.Drawing.Size(321, 223);
            this.dgvVictorias.TabIndex = 0;
            // 
            // lblCompu
            // 
            this.lblCompu.AutoSize = true;
            this.lblCompu.BackColor = System.Drawing.SystemColors.Control;
            this.lblCompu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompu.ForeColor = System.Drawing.Color.Green;
            this.lblCompu.Location = new System.Drawing.Point(200, 25);
            this.lblCompu.Name = "lblCompu";
            this.lblCompu.Size = new System.Drawing.Size(110, 18);
            this.lblCompu.TabIndex = 3;
            this.lblCompu.Text = "Computadora";
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.BackColor = System.Drawing.SystemColors.Control;
            this.lblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVs.Location = new System.Drawing.Point(156, 74);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(27, 18);
            this.lblVs.TabIndex = 4;
            this.lblVs.Text = "Vs";
            // 
            // Ronda
            // 
            this.Ronda.HeaderText = "Ronda";
            this.Ronda.MinimumWidth = 6;
            this.Ronda.Name = "Ronda";
            this.Ronda.Width = 60;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            // 
            // Computadora
            // 
            this.Computadora.HeaderText = "Computadora";
            this.Computadora.MinimumWidth = 6;
            this.Computadora.Name = "Computadora";
            // 
            // txtResultadoFinal
            // 
            this.txtResultadoFinal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtResultadoFinal.Location = new System.Drawing.Point(426, 395);
            this.txtResultadoFinal.Name = "txtResultadoFinal";
            this.txtResultadoFinal.ReadOnly = true;
            this.txtResultadoFinal.Size = new System.Drawing.Size(327, 22);
            this.txtResultadoFinal.TabIndex = 22;
            // 
            // pcbUsuario
            // 
            this.pcbUsuario.Location = new System.Drawing.Point(32, 48);
            this.pcbUsuario.Name = "pcbUsuario";
            this.pcbUsuario.Size = new System.Drawing.Size(100, 90);
            this.pcbUsuario.TabIndex = 5;
            this.pcbUsuario.TabStop = false;
            // 
            // pcbComputadora
            // 
            this.pcbComputadora.Location = new System.Drawing.Point(203, 48);
            this.pcbComputadora.Name = "pcbComputadora";
            this.pcbComputadora.Size = new System.Drawing.Size(100, 90);
            this.pcbComputadora.TabIndex = 6;
            this.pcbComputadora.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(548, 460);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 43);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(376, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 42);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseMnemonic = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmEjercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 563);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtResultadoFinal);
            this.Controls.Add(this.gbxVictorias);
            this.Controls.Add(this.gbxRondas);
            this.Controls.Add(this.btnSiguienteRonda);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Controls.Add(this.lblEleccion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio05";
            this.Text = "FrmEjercicio05";
            this.Load += new System.EventHandler(this.FrmEjercicio05_Load);
            this.gbxRondas.ResumeLayout(false);
            this.gbxRondas.PerformLayout();
            this.gbxVictorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVictorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComputadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEleccion;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Button btnSiguienteRonda;
        private System.Windows.Forms.GroupBox gbxRondas;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbxVictorias;
        private System.Windows.Forms.DataGridView dgvVictorias;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblCompu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ronda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Computadora;
        private System.Windows.Forms.TextBox txtResultadoFinal;
        private System.Windows.Forms.PictureBox pcbUsuario;
        private System.Windows.Forms.PictureBox pcbComputadora;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}