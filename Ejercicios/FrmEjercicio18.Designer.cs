namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    partial class FrmEjercicio18
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPorProductos = new System.Windows.Forms.Label();
            this.lblMayorStock = new System.Windows.Forms.Label();
            this.lblMenorStock = new System.Windows.Forms.Label();
            this.lblAlertas = new System.Windows.Forms.Label();
            this.pgbStock = new System.Windows.Forms.ProgressBar();
            this.lstbAlertas = new System.Windows.Forms.ListBox();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.Location = new System.Drawing.Point(313, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 32);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Control de Inventario";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(96, 114);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "Código:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(95, 176);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 31;
            this.lblCategoria.Text = "Categoría:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(99, 235);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(102, 37);
            this.btnRegistrar.TabIndex = 32;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(224, 235);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(102, 37);
            this.btnCalcular.TabIndex = 33;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Periféricos",
            "Monitores",
            "Computadoras"});
            this.cmbCategoria.Location = new System.Drawing.Point(175, 171);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cmbCategoria.TabIndex = 34;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigo.Location = new System.Drawing.Point(170, 111);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 22);
            this.txtCodigo.TabIndex = 35;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(425, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Location = new System.Drawing.Point(500, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 22);
            this.txtNombre.TabIndex = 37;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(425, 179);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 16);
            this.lblStock.TabIndex = 40;
            this.lblStock.Text = "Stock:";
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Location = new System.Drawing.Point(607, 182);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(90, 16);
            this.lblStockMin.TabIndex = 41;
            this.lblStockMin.Text = "Stock Mínimo:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(78, 482);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 16);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "Total de productos:";
            // 
            // lblPorProductos
            // 
            this.lblPorProductos.AutoSize = true;
            this.lblPorProductos.Location = new System.Drawing.Point(78, 542);
            this.lblPorProductos.Name = "lblPorProductos";
            this.lblPorProductos.Size = new System.Drawing.Size(218, 16);
            this.lblPorProductos.TabIndex = 43;
            this.lblPorProductos.Text = "% productos sobre el sotck mínimo:";
            // 
            // lblMayorStock
            // 
            this.lblMayorStock.AutoSize = true;
            this.lblMayorStock.Location = new System.Drawing.Point(369, 508);
            this.lblMayorStock.Name = "lblMayorStock";
            this.lblMayorStock.Size = new System.Drawing.Size(86, 16);
            this.lblMayorStock.TabIndex = 44;
            this.lblMayorStock.Text = "Mayor stock: ";
            // 
            // lblMenorStock
            // 
            this.lblMenorStock.AutoSize = true;
            this.lblMenorStock.Location = new System.Drawing.Point(675, 508);
            this.lblMenorStock.Name = "lblMenorStock";
            this.lblMenorStock.Size = new System.Drawing.Size(83, 16);
            this.lblMenorStock.TabIndex = 45;
            this.lblMenorStock.Text = "Menor stock:";
            // 
            // lblAlertas
            // 
            this.lblAlertas.AutoSize = true;
            this.lblAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertas.Location = new System.Drawing.Point(659, 254);
            this.lblAlertas.Name = "lblAlertas";
            this.lblAlertas.Size = new System.Drawing.Size(167, 18);
            this.lblAlertas.TabIndex = 46;
            this.lblAlertas.Text = "Alertas de stock bajo";
            // 
            // pgbStock
            // 
            this.pgbStock.Location = new System.Drawing.Point(371, 542);
            this.pgbStock.Name = "pgbStock";
            this.pgbStock.Size = new System.Drawing.Size(378, 23);
            this.pgbStock.TabIndex = 47;
            // 
            // lstbAlertas
            // 
            this.lstbAlertas.FormattingEnabled = true;
            this.lstbAlertas.ItemHeight = 16;
            this.lstbAlertas.Location = new System.Drawing.Point(662, 276);
            this.lstbAlertas.Name = "lstbAlertas";
            this.lstbAlertas.Size = new System.Drawing.Size(204, 164);
            this.lstbAlertas.TabIndex = 48;
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(475, 179);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(59, 22);
            this.nudStock.TabIndex = 49;
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(703, 182);
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(55, 22);
            this.nudStockMin.TabIndex = 50;
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Stock,
            this.StockMin});
            this.dgvInventario.Location = new System.Drawing.Point(95, 290);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(541, 150);
            this.dgvInventario.TabIndex = 51;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 90;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 80;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 60;
            // 
            // StockMin
            // 
            this.StockMin.HeaderText = "Stock Mín.";
            this.StockMin.MinimumWidth = 6;
            this.StockMin.Name = "StockMin";
            this.StockMin.Width = 60;
            // 
            // FrmEjercicio18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 594);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.nudStockMin);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.lstbAlertas);
            this.Controls.Add(this.pgbStock);
            this.Controls.Add(this.lblAlertas);
            this.Controls.Add(this.lblMenorStock);
            this.Controls.Add(this.lblMayorStock);
            this.Controls.Add(this.lblPorProductos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblStockMin);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmEjercicio18";
            this.Text = "FrmEjercicio18";
            this.Load += new System.EventHandler(this.FrmEjercicio18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPorProductos;
        private System.Windows.Forms.Label lblMayorStock;
        private System.Windows.Forms.Label lblMenorStock;
        private System.Windows.Forms.Label lblAlertas;
        private System.Windows.Forms.ProgressBar pgbStock;
        private System.Windows.Forms.ListBox lstbAlertas;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMin;
    }
}