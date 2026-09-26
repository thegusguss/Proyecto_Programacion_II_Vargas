namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio11
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
            this.gbAnalisisInicial = new System.Windows.Forms.GroupBox();
            this.txtTipoCantidad = new System.Windows.Forms.TextBox();
            this.txtCantidadVocales = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.lblCantidadVocales = new System.Windows.Forms.Label();
            this.lblTipoCantidad = new System.Windows.Forms.Label();
            this.lblPalabraInicial = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbCasoPar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMayusculas = new System.Windows.Forms.TextBox();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.gbCasoImpar = new System.Windows.Forms.GroupBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNuevaPalabra = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbAnalisisInicial.SuspendLayout();
            this.gbCasoPar.SuspendLayout();
            this.gbCasoImpar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnalisisInicial
            // 
            this.gbAnalisisInicial.BackColor = System.Drawing.Color.AliceBlue;
            this.gbAnalisisInicial.Controls.Add(this.txtTipoCantidad);
            this.gbAnalisisInicial.Controls.Add(this.txtCantidadVocales);
            this.gbAnalisisInicial.Controls.Add(this.btnAnalizar);
            this.gbAnalisisInicial.Controls.Add(this.txtPalabra);
            this.gbAnalisisInicial.Controls.Add(this.lblCantidadVocales);
            this.gbAnalisisInicial.Controls.Add(this.lblTipoCantidad);
            this.gbAnalisisInicial.Controls.Add(this.lblPalabraInicial);
            this.gbAnalisisInicial.Location = new System.Drawing.Point(20, 99);
            this.gbAnalisisInicial.Name = "gbAnalisisInicial";
            this.gbAnalisisInicial.Size = new System.Drawing.Size(692, 169);
            this.gbAnalisisInicial.TabIndex = 0;
            this.gbAnalisisInicial.TabStop = false;
            this.gbAnalisisInicial.Text = "Análisis inicial";
            // 
            // txtTipoCantidad
            // 
            this.txtTipoCantidad.Location = new System.Drawing.Point(538, 135);
            this.txtTipoCantidad.Name = "txtTipoCantidad";
            this.txtTipoCantidad.ReadOnly = true;
            this.txtTipoCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtTipoCantidad.TabIndex = 7;
            // 
            // txtCantidadVocales
            // 
            this.txtCantidadVocales.Location = new System.Drawing.Point(152, 132);
            this.txtCantidadVocales.Name = "txtCantidadVocales";
            this.txtCantidadVocales.ReadOnly = true;
            this.txtCantidadVocales.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadVocales.TabIndex = 6;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnAnalizar.FlatAppearance.BorderSize = 0;
            this.btnAnalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.btnAnalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(85)))), ((int)(((byte)(215)))));
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.ForeColor = System.Drawing.Color.White;
            this.btnAnalizar.Location = new System.Drawing.Point(284, 81);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(154, 38);
            this.btnAnalizar.TabIndex = 5;
            this.btnAnalizar.Text = "Analizar palabra";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(126, 46);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(474, 20);
            this.txtPalabra.TabIndex = 4;
            // 
            // lblCantidadVocales
            // 
            this.lblCantidadVocales.AutoSize = true;
            this.lblCantidadVocales.Location = new System.Drawing.Point(39, 135);
            this.lblCantidadVocales.Name = "lblCantidadVocales";
            this.lblCantidadVocales.Size = new System.Drawing.Size(107, 13);
            this.lblCantidadVocales.TabIndex = 3;
            this.lblCantidadVocales.Text = "Cantidad de vocales:";
            // 
            // lblTipoCantidad
            // 
            this.lblTipoCantidad.AutoSize = true;
            this.lblTipoCantidad.Location = new System.Drawing.Point(442, 139);
            this.lblTipoCantidad.Name = "lblTipoCantidad";
            this.lblTipoCantidad.Size = new System.Drawing.Size(90, 13);
            this.lblTipoCantidad.TabIndex = 2;
            this.lblTipoCantidad.Text = "Tipo de cantidad:";
            // 
            // lblPalabraInicial
            // 
            this.lblPalabraInicial.AutoSize = true;
            this.lblPalabraInicial.Location = new System.Drawing.Point(39, 49);
            this.lblPalabraInicial.Name = "lblPalabraInicial";
            this.lblPalabraInicial.Size = new System.Drawing.Size(75, 13);
            this.lblPalabraInicial.TabIndex = 0;
            this.lblPalabraInicial.Text = "Palabra inicial:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(166, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(391, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ANÁLISIS DE PALABRAS";
            // 
            // gbCasoPar
            // 
            this.gbCasoPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gbCasoPar.Controls.Add(this.label6);
            this.gbCasoPar.Controls.Add(this.label3);
            this.gbCasoPar.Controls.Add(this.txtMayusculas);
            this.gbCasoPar.Controls.Add(this.txtFrase);
            this.gbCasoPar.Location = new System.Drawing.Point(20, 309);
            this.gbCasoPar.Name = "gbCasoPar";
            this.gbCasoPar.Size = new System.Drawing.Size(324, 244);
            this.gbCasoPar.TabIndex = 2;
            this.gbCasoPar.TabStop = false;
            this.gbCasoPar.Text = "Caso PAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Resultado en mayúsculas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frase:";
            // 
            // txtMayusculas
            // 
            this.txtMayusculas.BackColor = System.Drawing.SystemColors.Control;
            this.txtMayusculas.Location = new System.Drawing.Point(30, 156);
            this.txtMayusculas.Multiline = true;
            this.txtMayusculas.Name = "txtMayusculas";
            this.txtMayusculas.ReadOnly = true;
            this.txtMayusculas.Size = new System.Drawing.Size(234, 52);
            this.txtMayusculas.TabIndex = 1;
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(92, 54);
            this.txtFrase.Multiline = true;
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(172, 31);
            this.txtFrase.TabIndex = 0;
            // 
            // gbCasoImpar
            // 
            this.gbCasoImpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.gbCasoImpar.Controls.Add(this.txtLongitud);
            this.gbCasoImpar.Controls.Add(this.lblLongitud);
            this.gbCasoImpar.Controls.Add(this.label8);
            this.gbCasoImpar.Controls.Add(this.txtNuevaPalabra);
            this.gbCasoImpar.Location = new System.Drawing.Point(384, 312);
            this.gbCasoImpar.Name = "gbCasoImpar";
            this.gbCasoImpar.Size = new System.Drawing.Size(328, 241);
            this.gbCasoImpar.TabIndex = 3;
            this.gbCasoImpar.TabStop = false;
            this.gbCasoImpar.Text = "Caso IMPAR";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(26, 175);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.Size = new System.Drawing.Size(185, 20);
            this.txtLongitud.TabIndex = 8;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Location = new System.Drawing.Point(23, 130);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(51, 13);
            this.lblLongitud.TabIndex = 7;
            this.lblLongitud.Text = "Longitud:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nueva palabra:";
            // 
            // txtNuevaPalabra
            // 
            this.txtNuevaPalabra.Location = new System.Drawing.Point(26, 80);
            this.txtNuevaPalabra.Name = "txtNuevaPalabra";
            this.txtNuevaPalabra.Size = new System.Drawing.Size(185, 20);
            this.txtNuevaPalabra.TabIndex = 4;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(190)))));
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(85)))), ((int)(((byte)(215)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(112, 569);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(160, 46);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(243)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(95)))));
            this.btnNuevo.Location = new System.Drawing.Point(298, 569);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(160, 46);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(478, 569);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(160, 46);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmEjercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 627);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.gbCasoImpar);
            this.Controls.Add(this.gbCasoPar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbAnalisisInicial);
            this.Name = "FrmEjercicio11";
            this.Text = "FrmEjercicio11";
            this.gbAnalisisInicial.ResumeLayout(false);
            this.gbAnalisisInicial.PerformLayout();
            this.gbCasoPar.ResumeLayout(false);
            this.gbCasoPar.PerformLayout();
            this.gbCasoImpar.ResumeLayout(false);
            this.gbCasoImpar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnalisisInicial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label lblCantidadVocales;
        private System.Windows.Forms.Label lblTipoCantidad;
        private System.Windows.Forms.Label lblPalabraInicial;
        private System.Windows.Forms.TextBox txtTipoCantidad;
        private System.Windows.Forms.TextBox txtCantidadVocales;
        private System.Windows.Forms.GroupBox gbCasoPar;
        private System.Windows.Forms.GroupBox gbCasoImpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMayusculas;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNuevaPalabra;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
    }
}