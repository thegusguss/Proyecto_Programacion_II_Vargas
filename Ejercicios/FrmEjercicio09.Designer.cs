namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio09
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxEstudiantes = new System.Windows.Forms.GroupBox();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoNotas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxEstudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(23, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 54);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(179, 372);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 54);
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxEstudiantes
            // 
            this.gbxEstudiantes.Controls.Add(this.dgvEstudiante);
            this.gbxEstudiantes.Location = new System.Drawing.Point(23, 65);
            this.gbxEstudiantes.Name = "gbxEstudiantes";
            this.gbxEstudiantes.Size = new System.Drawing.Size(939, 301);
            this.gbxEstudiantes.TabIndex = 31;
            this.gbxEstudiantes.TabStop = false;
            this.gbxEstudiantes.Text = "Tabla de Notas";
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estudiante,
            this.IngresoNotas,
            this.Practica,
            this.Trabajo,
            this.Examen,
            this.NotaFinal,
            this.Estado});
            this.dgvEstudiante.Location = new System.Drawing.Point(6, 21);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.RowHeadersWidth = 51;
            this.dgvEstudiante.RowTemplate.Height = 35;
            this.dgvEstudiante.Size = new System.Drawing.Size(927, 274);
            this.dgvEstudiante.TabIndex = 0;
            this.dgvEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiante_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(255, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(457, 32);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = " Calificación final de estudiantes";
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 8;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ToolTipText = "hola";
            this.Estudiante.Width = 80;
            // 
            // IngresoNotas
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            this.IngresoNotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.IngresoNotas.HeaderText = "Notas";
            this.IngresoNotas.MinimumWidth = 6;
            this.IngresoNotas.Name = "IngresoNotas";
            this.IngresoNotas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IngresoNotas.Text = "Ingresar";
            this.IngresoNotas.UseColumnTextForButtonValue = true;
            this.IngresoNotas.Width = 95;
            // 
            // Practica
            // 
            this.Practica.HeaderText = "Práctica (30%)";
            this.Practica.MinimumWidth = 6;
            this.Practica.Name = "Practica";
            this.Practica.Width = 95;
            // 
            // Trabajo
            // 
            this.Trabajo.HeaderText = "Trabajos (30%)";
            this.Trabajo.MinimumWidth = 6;
            this.Trabajo.Name = "Trabajo";
            this.Trabajo.Width = 95;
            // 
            // Examen
            // 
            this.Examen.HeaderText = "Examen Final (40%)";
            this.Examen.MinimumWidth = 6;
            this.Examen.Name = "Examen";
            this.Examen.Width = 95;
            // 
            // NotaFinal
            // 
            this.NotaFinal.HeaderText = "Nota Final";
            this.NotaFinal.MinimumWidth = 6;
            this.NotaFinal.Name = "NotaFinal";
            this.NotaFinal.Width = 95;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 120;
            // 
            // FrmEjercicio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxEstudiantes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio09";
            this.Text = "FrmEjercicio09";
            this.Load += new System.EventHandler(this.FrmEjercicio09_Load);
            this.gbxEstudiantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxEstudiantes;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewButtonColumn IngresoNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}