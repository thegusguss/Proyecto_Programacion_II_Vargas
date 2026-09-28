using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Clases;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio18 : Form
    {
        public FrmEjercicio18()
        {
            InitializeComponent();
        }

        private List<Producto> inventario = new List<Producto>();


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete el Código y el Nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto nuevoProducto = new Producto
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Categoria = cmbCategoria.SelectedItem.ToString(),
                StockActual = (int)nudStock.Value,
                StockMinimo = (int)nudStockMin.Value
            };

            inventario.Add(nuevoProducto);

            dgvInventario.Rows.Add(nuevoProducto.Codigo, nuevoProducto.Nombre, nuevoProducto.Categoria, nuevoProducto.StockActual, nuevoProducto.StockMinimo);

            txtCodigo.Clear();
            txtNombre.Clear();
            nudStock.Value = 0;
            nudStockMin.Value = 0;
            txtCodigo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (inventario.Count == 0)
            {
                MessageBox.Show("No hay productos registrados para calcular.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalProductos = inventario.Count;

            Producto prodMayorStock = inventario[0];
            Producto prodMenorStock = inventario[0];

            int productosSobreMinimo = 0;

            lstbAlertas.Items.Clear();

            for (int i = 0; i < inventario.Count; i++)
            {
                Producto p = inventario[i];

                if (p.StockActual > prodMayorStock.StockActual)
                {
                    prodMayorStock = p;
                }
                if (p.StockActual < prodMenorStock.StockActual)
                {
                    prodMenorStock = p;
                }

                if (p.StockActual < p.StockMinimo)
                {
                    lstbAlertas.Items.Add($"⚠ {p.Codigo}: {p.StockActual} < {p.StockMinimo}");
                }
                else
                {
                    productosSobreMinimo++;
                }
            }

            double porcentajeSobreMinimo = ((double)productosSobreMinimo / totalProductos) * 100;

            lblTotal.Text = $"Total productos: {totalProductos}";
            lblMayorStock.Text = $"Mayor stock: {prodMayorStock.Codigo} ({prodMayorStock.StockActual})";
            lblMenorStock.Text = $"Menor stock: {prodMenorStock.Codigo} ({prodMenorStock.StockActual})";

            pgbStock.Value = (int)Math.Round(porcentajeSobreMinimo);
            lblPorProductos.Text = $"% productos sobre el stock mínimo: {pgbStock.Value}%";


        }

        private void FrmEjercicio18_Load(object sender, EventArgs e)
        {
            cmbCategoria.SelectedIndex = 0;

            pgbStock.Minimum = 0;
            pgbStock.Maximum = 100;
            pgbStock.Value = 0;
        }
    }
}
