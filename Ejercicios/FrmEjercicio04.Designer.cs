namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio04
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
            this.gbxMensaje = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.gbxReglas = new System.Windows.Forms.GroupBox();
            this.txtReglas = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.txtNumeroSecreto = new System.Windows.Forms.TextBox();
            this.btnAdivinar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.gbxMensaje.SuspendLayout();
            this.gbxReglas.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMensaje
            // 
            this.gbxMensaje.Controls.Add(this.txtMensaje);
            this.gbxMensaje.Location = new System.Drawing.Point(60, 247);
            this.gbxMensaje.Name = "gbxMensaje";
            this.gbxMensaje.Size = new System.Drawing.Size(315, 81);
            this.gbxMensaje.TabIndex = 23;
            this.gbxMensaje.TabStop = false;
            this.gbxMensaje.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMensaje.Location = new System.Drawing.Point(27, 31);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(266, 27);
            this.txtMensaje.TabIndex = 0;
            // 
            // gbxReglas
            // 
            this.gbxReglas.Controls.Add(this.txtReglas);
            this.gbxReglas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxReglas.Location = new System.Drawing.Point(423, 177);
            this.gbxReglas.Name = "gbxReglas";
            this.gbxReglas.Size = new System.Drawing.Size(269, 146);
            this.gbxReglas.TabIndex = 22;
            this.gbxReglas.TabStop = false;
            this.gbxReglas.Text = "Reglas";
            // 
            // txtReglas
            // 
            this.txtReglas.Location = new System.Drawing.Point(6, 23);
            this.txtReglas.Multiline = true;
            this.txtReglas.Name = "txtReglas";
            this.txtReglas.Size = new System.Drawing.Size(257, 119);
            this.txtReglas.TabIndex = 10;
            this.txtReglas.Text = "• Máximo 10 intentos.\r\n• 100 puntos si acierta en el primer\r\n   intento.\r\n• La pu" +
    "ntuación disminuye conforme \r\n   aumentan los intentos. ";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(161, 207);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 34);
            this.txtNumero.TabIndex = 20;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtPuntuacion);
            this.gbxDatos.Controls.Add(this.txtIntentos);
            this.gbxDatos.Controls.Add(this.lblIntentos);
            this.gbxDatos.Controls.Add(this.lblPuntuacion);
            this.gbxDatos.Location = new System.Drawing.Point(60, 345);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(315, 118);
            this.gbxDatos.TabIndex = 19;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntuacion.Location = new System.Drawing.Point(144, 73);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.ReadOnly = true;
            this.txtPuntuacion.Size = new System.Drawing.Size(132, 30);
            this.txtPuntuacion.TabIndex = 8;
            // 
            // txtIntentos
            // 
            this.txtIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntentos.Location = new System.Drawing.Point(144, 36);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.ReadOnly = true;
            this.txtIntentos.Size = new System.Drawing.Size(132, 30);
            this.txtIntentos.TabIndex = 7;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(24, 39);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(114, 16);
            this.lblIntentos.TabIndex = 5;
            this.lblIntentos.Text = "Intentos restantes:";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(62, 73);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(76, 16);
            this.lblPuntuacion.TabIndex = 6;
            this.lblPuntuacion.Text = "Puntuación:";
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Location = new System.Drawing.Point(57, 177);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(204, 16);
            this.lblIndicacion.TabIndex = 18;
            this.lblIndicacion.Text = "Introduce un número entre 1 y 100";
            // 
            // txtNumeroSecreto
            // 
            this.txtNumeroSecreto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumeroSecreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSecreto.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNumeroSecreto.Location = new System.Drawing.Point(309, 103);
            this.txtNumeroSecreto.Name = "txtNumeroSecreto";
            this.txtNumeroSecreto.ReadOnly = true;
            this.txtNumeroSecreto.Size = new System.Drawing.Size(150, 45);
            this.txtNumeroSecreto.TabIndex = 14;
            this.txtNumeroSecreto.Text = "?";
            this.txtNumeroSecreto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdivinar
            // 
            this.btnAdivinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdivinar.Location = new System.Drawing.Point(125, 482);
            this.btnAdivinar.Name = "btnAdivinar";
            this.btnAdivinar.Size = new System.Drawing.Size(127, 54);
            this.btnAdivinar.TabIndex = 17;
            this.btnAdivinar.Text = "Adivinar";
            this.btnAdivinar.UseVisualStyleBackColor = true;
            this.btnAdivinar.Click += new System.EventHandler(this.btnAdivinar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(309, 482);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 54);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(492, 482);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 54);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(201, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(359, 32);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Juego: Adivina el número";
            // 
            // pcbImagen
            // 
            this.pcbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbImagen.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.adivina;
            this.pcbImagen.Location = new System.Drawing.Point(423, 329);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(269, 147);
            this.pcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImagen.TabIndex = 21;
            this.pcbImagen.TabStop = false;
            // 
            // FrmEjercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 559);
            this.Controls.Add(this.gbxMensaje);
            this.Controls.Add(this.gbxReglas);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.txtNumeroSecreto);
            this.Controls.Add(this.btnAdivinar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio04";
            this.Text = "FrmEjercicio04";
            this.Load += new System.EventHandler(this.FrmEjercicio04_Load);
            this.gbxMensaje.ResumeLayout(false);
            this.gbxMensaje.PerformLayout();
            this.gbxReglas.ResumeLayout(false);
            this.gbxReglas.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMensaje;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.GroupBox gbxReglas;
        private System.Windows.Forms.TextBox txtReglas;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.TextBox txtNumeroSecreto;
        private System.Windows.Forms.Button btnAdivinar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
    }
}