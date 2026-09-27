namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjercicio02));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtSuperan30 = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtMenorConsumo = new System.Windows.Forms.TextBox();
            this.txtMayorConsumo = new System.Windows.Forms.TextBox();
            this.txtTotalRecaudado = new System.Windows.Forms.TextBox();
            this.lblSuperan = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumom3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(254, 725);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(159, 63);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(360, 197);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(159, 63);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtSuperan30
            // 
            this.txtSuperan30.Location = new System.Drawing.Point(392, 669);
            this.txtSuperan30.Name = "txtSuperan30";
            this.txtSuperan30.Size = new System.Drawing.Size(170, 22);
            this.txtSuperan30.TabIndex = 32;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(392, 635);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(170, 22);
            this.txtPromedio.TabIndex = 31;
            // 
            // txtMenorConsumo
            // 
            this.txtMenorConsumo.Location = new System.Drawing.Point(392, 595);
            this.txtMenorConsumo.Name = "txtMenorConsumo";
            this.txtMenorConsumo.Size = new System.Drawing.Size(170, 22);
            this.txtMenorConsumo.TabIndex = 30;
            // 
            // txtMayorConsumo
            // 
            this.txtMayorConsumo.Location = new System.Drawing.Point(392, 560);
            this.txtMayorConsumo.Name = "txtMayorConsumo";
            this.txtMayorConsumo.Size = new System.Drawing.Size(170, 22);
            this.txtMayorConsumo.TabIndex = 29;
            // 
            // txtTotalRecaudado
            // 
            this.txtTotalRecaudado.Location = new System.Drawing.Point(392, 517);
            this.txtTotalRecaudado.Name = "txtTotalRecaudado";
            this.txtTotalRecaudado.Size = new System.Drawing.Size(170, 22);
            this.txtTotalRecaudado.TabIndex = 28;
            // 
            // lblSuperan
            // 
            this.lblSuperan.AutoSize = true;
            this.lblSuperan.Location = new System.Drawing.Point(138, 672);
            this.lblSuperan.Name = "lblSuperan";
            this.lblSuperan.Size = new System.Drawing.Size(177, 16);
            this.lblSuperan.TabIndex = 27;
            this.lblSuperan.Text = "Usuarios que superan 30 m³:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(138, 635);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(146, 16);
            this.lblPromedio.TabIndex = 26;
            this.lblPromedio.Text = "Promedio de consumo:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(138, 598);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(156, 16);
            this.lblMenor.TabIndex = 25;
            this.lblMenor.Text = "Usuario menor consumo:";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(138, 560);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(156, 16);
            this.lblMayor.TabIndex = 24;
            this.lblMayor.Text = "Usuario mayor consumo:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(138, 523);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 16);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total recaudado:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Consumom3,
            this.Monto});
            this.dgvResultados.Location = new System.Drawing.Point(106, 293);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(530, 184);
            this.dgvResultados.TabIndex = 22;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = " N° Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // Consumom3
            // 
            this.Consumom3.HeaderText = "Consumo m³";
            this.Consumom3.MinimumWidth = 6;
            this.Consumom3.Name = "Consumom3";
            this.Consumom3.Width = 125;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto a pagar";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.Width = 125;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(168, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 63);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(347, 133);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 22);
            this.txtCantidad.TabIndex = 20;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(190, 136);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(137, 16);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad de usuarios:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(149, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 29);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "CONSUMO MENSUAL DE AGUA";
            // 
            // FrmEjercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 867);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtSuperan30);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtMenorConsumo);
            this.Controls.Add(this.txtMayorConsumo);
            this.Controls.Add(this.txtTotalRecaudado);
            this.Controls.Add(this.lblSuperan);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio02";
            this.Text = "FrmEjercicio02";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtSuperan30;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtMenorConsumo;
        private System.Windows.Forms.TextBox txtMayorConsumo;
        private System.Windows.Forms.TextBox txtTotalRecaudado;
        private System.Windows.Forms.Label lblSuperan;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumom3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTitulo;
    }
}