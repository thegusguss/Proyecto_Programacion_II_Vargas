namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio16));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblMatriculados = new System.Windows.Forms.Label();
            this.lblManana = new System.Windows.Forms.Label();
            this.lblTarde = new System.Windows.Forms.Label();
            this.lblNoche = new System.Windows.Forms.Label();
            this.lblMatriculadoCarrera = new System.Windows.Forms.Label();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblCantManana = new System.Windows.Forms.Label();
            this.lblCantTarde = new System.Windows.Forms.Label();
            this.lblCantNoche = new System.Windows.Forms.Label();
            this.lblCantPromedio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rdbManana = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbNoche = new System.Windows.Forms.RadioButton();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(501, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 22);
            this.txtNombre.TabIndex = 23;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(74, 109);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 20);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitulo.Location = new System.Drawing.Point(251, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 29);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "REGISTRO DE MATRÍCULA";
            // 
            // mskDNI
            // 
            this.mskDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mskDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskDNI.Location = new System.Drawing.Point(152, 109);
            this.mskDNI.Mask = "00000000";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(127, 22);
            this.mskDNI.TabIndex = 24;
            this.mskDNI.Enter += new System.EventHandler(this.mskDNI_Enter);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(416, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // nudEdad
            // 
            this.nudEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEdad.Location = new System.Drawing.Point(152, 150);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(59, 27);
            this.nudEdad.TabIndex = 26;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(65, 150);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 20);
            this.lblEdad.TabIndex = 27;
            this.lblEdad.Text = "Edad:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(238, 152);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(71, 20);
            this.lblCarrera.TabIndex = 28;
            this.lblCarrera.Text = "Carrera:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Ing. Sistemas",
            "Ing. Civil",
            "Ing. Industrial",
            "Ing. Ambiental",
            "Ing. Electrónica",
            "Ing. Agroindustrial"});
            this.cmbCarrera.Location = new System.Drawing.Point(331, 148);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(213, 24);
            this.cmbCarrera.TabIndex = 29;
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.Edad,
            this.Carrera,
            this.Turno});
            this.dgvEstudiantes.GridColor = System.Drawing.Color.Gray;
            this.dgvEstudiantes.Location = new System.Drawing.Point(69, 300);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(881, 238);
            this.dgvEstudiantes.TabIndex = 34;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 125;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 125;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.MinimumWidth = 6;
            this.Turno.Name = "Turno";
            this.Turno.Width = 125;
            // 
            // dgvErrores
            // 
            this.dgvErrores.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Campo,
            this.Detalle});
            this.dgvErrores.Location = new System.Drawing.Point(69, 564);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.RowHeadersWidth = 51;
            this.dgvErrores.RowTemplate.Height = 24;
            this.dgvErrores.Size = new System.Drawing.Size(649, 238);
            this.dgvErrores.TabIndex = 35;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(582, 148);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 20);
            this.lblCorreo.TabIndex = 37;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Location = new System.Drawing.Point(682, 146);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(219, 22);
            this.txtCorreo.TabIndex = 38;
            // 
            // lblMatriculados
            // 
            this.lblMatriculados.AutoSize = true;
            this.lblMatriculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculados.Location = new System.Drawing.Point(74, 820);
            this.lblMatriculados.Name = "lblMatriculados";
            this.lblMatriculados.Size = new System.Drawing.Size(210, 20);
            this.lblMatriculados.TabIndex = 39;
            this.lblMatriculados.Text = "Matriculados por Turno:";
            // 
            // lblManana
            // 
            this.lblManana.AutoSize = true;
            this.lblManana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManana.Location = new System.Drawing.Point(75, 861);
            this.lblManana.Name = "lblManana";
            this.lblManana.Size = new System.Drawing.Size(78, 20);
            this.lblManana.TabIndex = 40;
            this.lblManana.Text = "Mañana: ";
            // 
            // lblTarde
            // 
            this.lblTarde.AutoSize = true;
            this.lblTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarde.Location = new System.Drawing.Point(261, 861);
            this.lblTarde.Name = "lblTarde";
            this.lblTarde.Size = new System.Drawing.Size(57, 20);
            this.lblTarde.TabIndex = 41;
            this.lblTarde.Text = "Tarde:";
            // 
            // lblNoche
            // 
            this.lblNoche.AutoSize = true;
            this.lblNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoche.Location = new System.Drawing.Point(438, 861);
            this.lblNoche.Name = "lblNoche";
            this.lblNoche.Size = new System.Drawing.Size(62, 20);
            this.lblNoche.TabIndex = 42;
            this.lblNoche.Text = "Noche:";
            // 
            // lblMatriculadoCarrera
            // 
            this.lblMatriculadoCarrera.AutoSize = true;
            this.lblMatriculadoCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculadoCarrera.Location = new System.Drawing.Point(74, 936);
            this.lblMatriculadoCarrera.Name = "lblMatriculadoCarrera";
            this.lblMatriculadoCarrera.Size = new System.Drawing.Size(226, 20);
            this.lblMatriculadoCarrera.TabIndex = 43;
            this.lblMatriculadoCarrera.Text = "Matriculados por Carrera:";
            // 
            // lstCarreras
            // 
            this.lstCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.ItemHeight = 20;
            this.lstCarreras.Location = new System.Drawing.Point(78, 977);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(260, 164);
            this.lstCarreras.TabIndex = 44;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(75, 897);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(128, 20);
            this.lblPromedio.TabIndex = 45;
            this.lblPromedio.Text = "Edad Promedio:";
            // 
            // lblCantManana
            // 
            this.lblCantManana.AutoSize = true;
            this.lblCantManana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantManana.Location = new System.Drawing.Point(175, 861);
            this.lblCantManana.Name = "lblCantManana";
            this.lblCantManana.Size = new System.Drawing.Size(18, 20);
            this.lblCantManana.TabIndex = 46;
            this.lblCantManana.Text = "0";
            // 
            // lblCantTarde
            // 
            this.lblCantTarde.AutoSize = true;
            this.lblCantTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTarde.Location = new System.Drawing.Point(336, 861);
            this.lblCantTarde.Name = "lblCantTarde";
            this.lblCantTarde.Size = new System.Drawing.Size(18, 20);
            this.lblCantTarde.TabIndex = 47;
            this.lblCantTarde.Text = "0";
            // 
            // lblCantNoche
            // 
            this.lblCantNoche.AutoSize = true;
            this.lblCantNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantNoche.Location = new System.Drawing.Point(515, 861);
            this.lblCantNoche.Name = "lblCantNoche";
            this.lblCantNoche.Size = new System.Drawing.Size(18, 20);
            this.lblCantNoche.TabIndex = 48;
            this.lblCantNoche.Text = "0";
            // 
            // lblCantPromedio
            // 
            this.lblCantPromedio.AutoSize = true;
            this.lblCantPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPromedio.Location = new System.Drawing.Point(222, 897);
            this.lblCantPromedio.Name = "lblCantPromedio";
            this.lblCantPromedio.Size = new System.Drawing.Size(18, 20);
            this.lblCantPromedio.TabIndex = 49;
            this.lblCantPromedio.Text = "0";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(778, 203);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(208, 63);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMatricular
            // 
            this.btnMatricular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMatricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricular.ForeColor = System.Drawing.Color.Black;
            this.btnMatricular.Image = ((System.Drawing.Image)(resources.GetObject("btnMatricular.Image")));
            this.btnMatricular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricular.Location = new System.Drawing.Point(546, 203);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(208, 63);
            this.btnMatricular.TabIndex = 50;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = false;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rdbManana);
            this.gbxTurno.Controls.Add(this.rdbTarde);
            this.gbxTurno.Controls.Add(this.rdbNoche);
            this.gbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTurno.Location = new System.Drawing.Point(70, 193);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(402, 86);
            this.gbxTurno.TabIndex = 52;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rdbManana
            // 
            this.rdbManana.AutoSize = true;
            this.rdbManana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbManana.Location = new System.Drawing.Point(17, 40);
            this.rdbManana.Name = "rdbManana";
            this.rdbManana.Size = new System.Drawing.Size(89, 24);
            this.rdbManana.TabIndex = 31;
            this.rdbManana.TabStop = true;
            this.rdbManana.Text = "Mañana";
            this.rdbManana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTarde.Location = new System.Drawing.Point(166, 40);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(73, 24);
            this.rdbTarde.TabIndex = 32;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbNoche
            // 
            this.rdbNoche.AutoSize = true;
            this.rdbNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoche.Location = new System.Drawing.Point(299, 40);
            this.rdbNoche.Name = "rdbNoche";
            this.rdbNoche.Size = new System.Drawing.Size(78, 24);
            this.rdbNoche.TabIndex = 33;
            this.rdbNoche.TabStop = true;
            this.rdbNoche.Text = "Noche";
            this.rdbNoche.UseVisualStyleBackColor = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.Width = 125;
            // 
            // Campo
            // 
            this.Campo.HeaderText = "Campo";
            this.Campo.MinimumWidth = 6;
            this.Campo.Name = "Campo";
            this.Campo.Width = 125;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 200;
            // 
            // FrmEjercicio16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 1175);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.lblCantPromedio);
            this.Controls.Add(this.lblCantNoche);
            this.Controls.Add(this.lblCantTarde);
            this.Controls.Add(this.lblCantManana);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.lblMatriculadoCarrera);
            this.Controls.Add(this.lblNoche);
            this.Controls.Add(this.lblTarde);
            this.Controls.Add(this.lblManana);
            this.Controls.Add(this.lblMatriculados);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.dgvErrores);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.mskDNI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio16";
            this.Text = "FrmEjercicio16";
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblMatriculados;
        private System.Windows.Forms.Label lblManana;
        private System.Windows.Forms.Label lblTarde;
        private System.Windows.Forms.Label lblNoche;
        private System.Windows.Forms.Label lblMatriculadoCarrera;
        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblCantManana;
        private System.Windows.Forms.Label lblCantTarde;
        private System.Windows.Forms.Label lblCantNoche;
        private System.Windows.Forms.Label lblCantPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rdbManana;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbNoche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
    }
}