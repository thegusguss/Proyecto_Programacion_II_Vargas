namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio10
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEvaluaciones = new System.Windows.Forms.DataGridView();
            this.colTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPediatria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGinecologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInternista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeurologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAnalisisResultados = new System.Windows.Forms.GroupBox();
            this.txtTurnosAprobados = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPromedioNeurologia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPromedioInternista = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPromedioGinecologia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPromedioPediatria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPromedioGeneral = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMejorNota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMejorTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMejorEspecialidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.gbRegistroEvaluacion = new System.Windows.Forms.GroupBox();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).BeginInit();
            this.gbAnalisisResultados.SuspendLayout();
            this.gbRegistroEvaluacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(65)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EVALUACIÓN DE ESPECIALISTAS - EPS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEvaluaciones);
            this.groupBox1.Location = new System.Drawing.Point(18, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz de Evaluaciones";
            // 
            // dgvEvaluaciones
            // 
            this.dgvEvaluaciones.AllowUserToAddRows = false;
            this.dgvEvaluaciones.AllowUserToDeleteRows = false;
            this.dgvEvaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEvaluaciones.ColumnHeadersHeight = 40;
            this.dgvEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTurno,
            this.colPediatria,
            this.colGinecologia,
            this.colInternista,
            this.colNeurologia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(228)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvaluaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEvaluaciones.EnableHeadersVisualStyles = false;
            this.dgvEvaluaciones.Location = new System.Drawing.Point(12, 23);
            this.dgvEvaluaciones.Name = "dgvEvaluaciones";
            this.dgvEvaluaciones.ReadOnly = true;
            this.dgvEvaluaciones.RowTemplate.Height = 35;
            this.dgvEvaluaciones.Size = new System.Drawing.Size(794, 244);
            this.dgvEvaluaciones.TabIndex = 0;
            // 
            // colTurno
            // 
            this.colTurno.HeaderText = "Turno";
            this.colTurno.Name = "colTurno";
            this.colTurno.ReadOnly = true;
            // 
            // colPediatria
            // 
            this.colPediatria.HeaderText = "Pediatría";
            this.colPediatria.Name = "colPediatria";
            this.colPediatria.ReadOnly = true;
            // 
            // colGinecologia
            // 
            this.colGinecologia.HeaderText = "Ginecología";
            this.colGinecologia.Name = "colGinecologia";
            this.colGinecologia.ReadOnly = true;
            // 
            // colInternista
            // 
            this.colInternista.HeaderText = "Internista";
            this.colInternista.Name = "colInternista";
            this.colInternista.ReadOnly = true;
            // 
            // colNeurologia
            // 
            this.colNeurologia.HeaderText = "Neurología";
            this.colNeurologia.Name = "colNeurologia";
            this.colNeurologia.ReadOnly = true;
            // 
            // gbAnalisisResultados
            // 
            this.gbAnalisisResultados.Controls.Add(this.txtTurnosAprobados);
            this.gbAnalisisResultados.Controls.Add(this.label12);
            this.gbAnalisisResultados.Controls.Add(this.txtPromedioNeurologia);
            this.gbAnalisisResultados.Controls.Add(this.label11);
            this.gbAnalisisResultados.Controls.Add(this.txtPromedioInternista);
            this.gbAnalisisResultados.Controls.Add(this.label10);
            this.gbAnalisisResultados.Controls.Add(this.txtPromedioGinecologia);
            this.gbAnalisisResultados.Controls.Add(this.label9);
            this.gbAnalisisResultados.Controls.Add(this.txtPromedioPediatria);
            this.gbAnalisisResultados.Controls.Add(this.label8);
            this.gbAnalisisResultados.Controls.Add(this.txtPromedioGeneral);
            this.gbAnalisisResultados.Controls.Add(this.label7);
            this.gbAnalisisResultados.Controls.Add(this.txtMejorNota);
            this.gbAnalisisResultados.Controls.Add(this.label6);
            this.gbAnalisisResultados.Controls.Add(this.txtMejorTurno);
            this.gbAnalisisResultados.Controls.Add(this.label5);
            this.gbAnalisisResultados.Controls.Add(this.txtMejorEspecialidad);
            this.gbAnalisisResultados.Location = new System.Drawing.Point(18, 539);
            this.gbAnalisisResultados.Name = "gbAnalisisResultados";
            this.gbAnalisisResultados.Size = new System.Drawing.Size(814, 230);
            this.gbAnalisisResultados.TabIndex = 2;
            this.gbAnalisisResultados.TabStop = false;
            this.gbAnalisisResultados.Text = "Análisis de Resultados";
            // 
            // txtTurnosAprobados
            // 
            this.txtTurnosAprobados.Location = new System.Drawing.Point(216, 48);
            this.txtTurnosAprobados.Name = "txtTurnosAprobados";
            this.txtTurnosAprobados.ReadOnly = true;
            this.txtTurnosAprobados.Size = new System.Drawing.Size(100, 20);
            this.txtTurnosAprobados.TabIndex = 16;
            this.txtTurnosAprobados.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Promedio Neurología:";
            // 
            // txtPromedioNeurologia
            // 
            this.txtPromedioNeurologia.Location = new System.Drawing.Point(637, 191);
            this.txtPromedioNeurologia.Name = "txtPromedioNeurologia";
            this.txtPromedioNeurologia.ReadOnly = true;
            this.txtPromedioNeurologia.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioNeurologia.TabIndex = 14;
            this.txtPromedioNeurologia.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Promedio Internista:";
            // 
            // txtPromedioInternista
            // 
            this.txtPromedioInternista.Location = new System.Drawing.Point(637, 153);
            this.txtPromedioInternista.Name = "txtPromedioInternista";
            this.txtPromedioInternista.ReadOnly = true;
            this.txtPromedioInternista.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioInternista.TabIndex = 12;
            this.txtPromedioInternista.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Promedio Ginecología:";
            // 
            // txtPromedioGinecologia
            // 
            this.txtPromedioGinecologia.Location = new System.Drawing.Point(637, 118);
            this.txtPromedioGinecologia.Name = "txtPromedioGinecologia";
            this.txtPromedioGinecologia.ReadOnly = true;
            this.txtPromedioGinecologia.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioGinecologia.TabIndex = 10;
            this.txtPromedioGinecologia.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Promedio Pediatría:";
            // 
            // txtPromedioPediatria
            // 
            this.txtPromedioPediatria.Location = new System.Drawing.Point(637, 81);
            this.txtPromedioPediatria.Name = "txtPromedioPediatria";
            this.txtPromedioPediatria.ReadOnly = true;
            this.txtPromedioPediatria.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioPediatria.TabIndex = 8;
            this.txtPromedioPediatria.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Promedio general:";
            // 
            // txtPromedioGeneral
            // 
            this.txtPromedioGeneral.Location = new System.Drawing.Point(637, 47);
            this.txtPromedioGeneral.Name = "txtPromedioGeneral";
            this.txtPromedioGeneral.ReadOnly = true;
            this.txtPromedioGeneral.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioGeneral.TabIndex = 6;
            this.txtPromedioGeneral.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Turno de mejor nota:";
            // 
            // txtMejorNota
            // 
            this.txtMejorNota.Location = new System.Drawing.Point(216, 195);
            this.txtMejorNota.Name = "txtMejorNota";
            this.txtMejorNota.ReadOnly = true;
            this.txtMejorNota.Size = new System.Drawing.Size(100, 20);
            this.txtMejorNota.TabIndex = 4;
            this.txtMejorNota.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mejor especialidad:";
            // 
            // txtMejorTurno
            // 
            this.txtMejorTurno.Location = new System.Drawing.Point(216, 157);
            this.txtMejorTurno.Name = "txtMejorTurno";
            this.txtMejorTurno.ReadOnly = true;
            this.txtMejorTurno.Size = new System.Drawing.Size(100, 20);
            this.txtMejorTurno.TabIndex = 2;
            this.txtMejorTurno.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Turno(s) con todas las notas >= 4.0:";
            // 
            // txtMejorEspecialidad
            // 
            this.txtMejorEspecialidad.Location = new System.Drawing.Point(216, 102);
            this.txtMejorEspecialidad.Name = "txtMejorEspecialidad";
            this.txtMejorEspecialidad.ReadOnly = true;
            this.txtMejorEspecialidad.Size = new System.Drawing.Size(100, 20);
            this.txtMejorEspecialidad.TabIndex = 0;
            this.txtMejorEspecialidad.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(195)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(97, 482);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(191, 42);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular Resultados";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(547, 482);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 42);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(243)))));
            this.btnRestablecer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.btnRestablecer.Location = new System.Drawing.Point(340, 482);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(150, 42);
            this.btnRestablecer.TabIndex = 6;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // gbRegistroEvaluacion
            // 
            this.gbRegistroEvaluacion.Controls.Add(this.nudNota);
            this.gbRegistroEvaluacion.Controls.Add(this.label4);
            this.gbRegistroEvaluacion.Controls.Add(this.cboEspecialidad);
            this.gbRegistroEvaluacion.Controls.Add(this.cboTurno);
            this.gbRegistroEvaluacion.Controls.Add(this.btnRegistrar);
            this.gbRegistroEvaluacion.Controls.Add(this.label3);
            this.gbRegistroEvaluacion.Controls.Add(this.label2);
            this.gbRegistroEvaluacion.Location = new System.Drawing.Point(18, 88);
            this.gbRegistroEvaluacion.Name = "gbRegistroEvaluacion";
            this.gbRegistroEvaluacion.Size = new System.Drawing.Size(814, 87);
            this.gbRegistroEvaluacion.TabIndex = 3;
            this.gbRegistroEvaluacion.TabStop = false;
            this.gbRegistroEvaluacion.Text = "Registro de Evaluación";
            // 
            // nudNota
            // 
            this.nudNota.DecimalPlaces = 1;
            this.nudNota.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudNota.Location = new System.Drawing.Point(511, 38);
            this.nudNota.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(100, 20);
            this.nudNota.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nota:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(322, 37);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cboEspecialidad.TabIndex = 9;
            // 
            // cboTurno
            // 
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(98, 37);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(121, 21);
            this.cboTurno.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(85)))), ((int)(((byte)(170)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(100)))), ((int)(((byte)(195)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(637, 25);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 42);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar / Actualizar Evaluación";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Especialidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Turno:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 77);
            this.panel1.TabIndex = 7;
            // 
            // FrmEjercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 781);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbRegistroEvaluacion);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbAnalisisResultados);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEjercicio10";
            this.Text = "FrmEjercicio10";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluaciones)).EndInit();
            this.gbAnalisisResultados.ResumeLayout(false);
            this.gbAnalisisResultados.PerformLayout();
            this.gbRegistroEvaluacion.ResumeLayout(false);
            this.gbRegistroEvaluacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private System.Windows.Forms.GroupBox gbAnalisisResultados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.GroupBox gbRegistroEvaluacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPromedioNeurologia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPromedioInternista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPromedioGinecologia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPromedioPediatria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPromedioGeneral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMejorNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMejorTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMejorEspecialidad;
        private System.Windows.Forms.TextBox txtTurnosAprobados;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPediatria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGinecologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInternista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeurologia;
        private System.Windows.Forms.Panel panel1;
    }
}