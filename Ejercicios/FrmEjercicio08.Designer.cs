namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio08
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
            this.lblCantEstudiantes = new System.Windows.Forms.Label();
            this.txtCantEstudiantes = new System.Windows.Forms.TextBox();
            this.lblAprobados = new System.Windows.Forms.Label();
            this.lblDesaprobados = new System.Windows.Forms.Label();
            this.txtAprobados = new System.Windows.Forms.TextBox();
            this.txtDesaprobados = new System.Windows.Forms.TextBox();
            this.gbxEstudiantes = new System.Windows.Forms.GroupBox();
            this.gbxCursos = new System.Windows.Forms.GroupBox();
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromedioCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxEstudiantes.SuspendLayout();
            this.gbxCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(321, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 32);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Matriz de Calificaciones";
            // 
            // lblCantEstudiantes
            // 
            this.lblCantEstudiantes.AutoSize = true;
            this.lblCantEstudiantes.Location = new System.Drawing.Point(46, 146);
            this.lblCantEstudiantes.Name = "lblCantEstudiantes";
            this.lblCantEstudiantes.Size = new System.Drawing.Size(153, 16);
            this.lblCantEstudiantes.TabIndex = 15;
            this.lblCantEstudiantes.Text = "Cantidad de Estudiantes";
            // 
            // txtCantEstudiantes
            // 
            this.txtCantEstudiantes.Location = new System.Drawing.Point(205, 143);
            this.txtCantEstudiantes.Name = "txtCantEstudiantes";
            this.txtCantEstudiantes.Size = new System.Drawing.Size(93, 22);
            this.txtCantEstudiantes.TabIndex = 16;
            // 
            // lblAprobados
            // 
            this.lblAprobados.AutoSize = true;
            this.lblAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprobados.Location = new System.Drawing.Point(35, 37);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(84, 16);
            this.lblAprobados.TabIndex = 17;
            this.lblAprobados.Text = "Aprobados";
            // 
            // lblDesaprobados
            // 
            this.lblDesaprobados.AutoSize = true;
            this.lblDesaprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesaprobados.ForeColor = System.Drawing.Color.Red;
            this.lblDesaprobados.Location = new System.Drawing.Point(12, 74);
            this.lblDesaprobados.Name = "lblDesaprobados";
            this.lblDesaprobados.Size = new System.Drawing.Size(111, 16);
            this.lblDesaprobados.TabIndex = 18;
            this.lblDesaprobados.Text = "Desaprobados";
            // 
            // txtAprobados
            // 
            this.txtAprobados.Location = new System.Drawing.Point(125, 34);
            this.txtAprobados.Name = "txtAprobados";
            this.txtAprobados.ReadOnly = true;
            this.txtAprobados.Size = new System.Drawing.Size(100, 22);
            this.txtAprobados.TabIndex = 19;
            // 
            // txtDesaprobados
            // 
            this.txtDesaprobados.Location = new System.Drawing.Point(125, 71);
            this.txtDesaprobados.Name = "txtDesaprobados";
            this.txtDesaprobados.ReadOnly = true;
            this.txtDesaprobados.Size = new System.Drawing.Size(100, 22);
            this.txtDesaprobados.TabIndex = 20;
            // 
            // gbxEstudiantes
            // 
            this.gbxEstudiantes.Controls.Add(this.dgvEstudiante);
            this.gbxEstudiantes.Location = new System.Drawing.Point(348, 102);
            this.gbxEstudiantes.Name = "gbxEstudiantes";
            this.gbxEstudiantes.Size = new System.Drawing.Size(289, 318);
            this.gbxEstudiantes.TabIndex = 21;
            this.gbxEstudiantes.TabStop = false;
            this.gbxEstudiantes.Text = "Promedio por Estudiante";
            // 
            // gbxCursos
            // 
            this.gbxCursos.Controls.Add(this.dgvCursos);
            this.gbxCursos.Location = new System.Drawing.Point(663, 108);
            this.gbxCursos.Name = "gbxCursos";
            this.gbxCursos.Size = new System.Drawing.Size(321, 301);
            this.gbxCursos.TabIndex = 22;
            this.gbxCursos.TabStop = false;
            this.gbxCursos.Text = "Promedio por Curso";
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estudiante,
            this.Promedio});
            this.dgvEstudiante.Location = new System.Drawing.Point(6, 22);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.RowHeadersWidth = 51;
            this.dgvEstudiante.RowTemplate.Height = 24;
            this.dgvEstudiante.Size = new System.Drawing.Size(275, 285);
            this.dgvEstudiante.TabIndex = 0;
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Curso,
            this.PromedioCurso});
            this.dgvCursos.Location = new System.Drawing.Point(6, 21);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.Size = new System.Drawing.Size(301, 222);
            this.dgvCursos.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnIngresar.Location = new System.Drawing.Point(116, 193);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(127, 54);
            this.btnIngresar.TabIndex = 26;
            this.btnIngresar.Text = "Ingresar Notas";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(49, 375);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 54);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(205, 375);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 54);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.txtDesaprobados);
            this.gbxEstado.Controls.Add(this.lblAprobados);
            this.gbxEstado.Controls.Add(this.lblDesaprobados);
            this.gbxEstado.Controls.Add(this.txtAprobados);
            this.gbxEstado.Location = new System.Drawing.Point(54, 253);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(244, 113);
            this.gbxEstado.TabIndex = 27;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Estado";
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 8;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Width = 90;
            // 
            // Promedio
            // 
            this.Promedio.HeaderText = "Promedio";
            this.Promedio.MinimumWidth = 6;
            this.Promedio.Name = "Promedio";
            this.Promedio.Width = 90;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 8;
            this.Curso.Name = "Curso";
            // 
            // PromedioCurso
            // 
            this.PromedioCurso.HeaderText = "Promedio";
            this.PromedioCurso.MinimumWidth = 6;
            this.PromedioCurso.Name = "PromedioCurso";
            this.PromedioCurso.Width = 90;
            // 
            // FrmEjercicio08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 540);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxCursos);
            this.Controls.Add(this.gbxEstudiantes);
            this.Controls.Add(this.txtCantEstudiantes);
            this.Controls.Add(this.lblCantEstudiantes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio08";
            this.Text = "FrmEjercicio08";
            this.gbxEstudiantes.ResumeLayout(false);
            this.gbxCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantEstudiantes;
        private System.Windows.Forms.TextBox txtCantEstudiantes;
        private System.Windows.Forms.Label lblAprobados;
        private System.Windows.Forms.Label lblDesaprobados;
        private System.Windows.Forms.TextBox txtAprobados;
        private System.Windows.Forms.TextBox txtDesaprobados;
        private System.Windows.Forms.GroupBox gbxEstudiantes;
        private System.Windows.Forms.GroupBox gbxCursos;
        private System.Windows.Forms.DataGridView dgvEstudiante;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromedioCurso;
    }
}