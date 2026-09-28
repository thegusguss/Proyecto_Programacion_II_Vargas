using System;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio19 : Form
    {
        private int numeroCorrelativo = 1;
        private int filaSeleccionada = -1;

        public FrmEjercicio19()
        {
            InitializeComponent();
            label9.Parent = pictureBox1;
            txtNumero.Text = numeroCorrelativo.ToString();

            nudPrecio.ValueChanged += CalcularSubTotal;
            nudCantidad.ValueChanged += CalcularSubTotal;

            dgvProductos.CellClick += dgvProductos_CellClick;

            EstadoInicial();
        }

        private void CalcularSubTotal(object sender, EventArgs e)
        {
            decimal subtotal = nudPrecio.Value * nudCantidad.Value;
            txtSubTotal.Text = subtotal.ToString("0.00");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

            txtNumero.Text = numeroCorrelativo.ToString();

            txtProducto.Focus();

            btnGrabar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            string condicion = ObtenerCondicion();
            string estado = chkActivo.Checked ? "Activo" : "Inactivo";

            decimal precio = nudPrecio.Value;
            int cantidad = (int)nudCantidad.Value;
            decimal subtotal = precio * cantidad;

            dgvProductos.Rows.Add(
                numeroCorrelativo,
                txtProducto.Text.Trim(),
                cboCategoria.Text,
                precio.ToString("0.00"),
                cantidad,
                subtotal.ToString("0.00"),
                condicion,
                estado
            );

            numeroCorrelativo++;

            MessageBox.Show(
                "Producto grabado correctamente.",
                "Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimpiarCampos();

            txtNumero.Text = numeroCorrelativo.ToString();

            btnGrabar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show(
                    "Seleccione un producto para editar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            string condicion = ObtenerCondicion();
            string estado = chkActivo.Checked ? "Activo" : "Inactivo";

            decimal precio = nudPrecio.Value;
            int cantidad = (int)nudCantidad.Value;
            decimal subtotal = precio * cantidad;

            DataGridViewRow fila = dgvProductos.Rows[filaSeleccionada];

            fila.Cells["colNumero"].Value = txtNumero.Text;
            fila.Cells["colProducto"].Value = txtProducto.Text.Trim();
            fila.Cells["colCategoria"].Value = cboCategoria.Text;
            fila.Cells["colPrecio"].Value = precio.ToString("0.00");
            fila.Cells["colCantidad"].Value = cantidad;
            fila.Cells["colSubTotal"].Value = subtotal.ToString("0.00");
            fila.Cells["colCondicion"].Value = condicion;
            fila.Cells["colEstado"].Value = estado;

            MessageBox.Show(
                "Producto modificado correctamente.",
                "Editar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            filaSeleccionada = -1;

            LimpiarCampos();

            txtNumero.Text = numeroCorrelativo.ToString();

            btnGrabar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show(
                    "Seleccione un producto para eliminar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar el producto seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                dgvProductos.Rows.RemoveAt(filaSeleccionada);

                filaSeleccionada = -1;

                MessageBox.Show(
                    "Producto eliminado correctamente.",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimpiarCampos();

                txtNumero.Text = numeroCorrelativo.ToString();

                btnGrabar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            filaSeleccionada = -1;

            LimpiarCampos();

            txtNumero.Text = numeroCorrelativo.ToString();

            btnGrabar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar el formulario?",
                "Cerrar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No existen productos registrados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            SeleccionarFila(0);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                return;
            }

            if (filaSeleccionada == -1)
            {
                filaSeleccionada = 0;
            }
            else if (filaSeleccionada > 0)
            {
                filaSeleccionada--;
            }

            SeleccionarFila(filaSeleccionada);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                return;
            }

            if (filaSeleccionada == -1)
            {
                filaSeleccionada = 0;
            }
            else if (filaSeleccionada < dgvProductos.Rows.Count - 1)
            {
                filaSeleccionada++;
            }

            SeleccionarFila(filaSeleccionada);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No existen productos registrados.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            SeleccionarFila(dgvProductos.Rows.Count - 1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.Trim().ToLower();

            if (buscar == "")
            {
                MessageBox.Show(
                    "Ingrese un producto para buscar.",
                    "Buscar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBuscar.Focus();
                return;
            }

            bool encontrado = false;

            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                string numero = dgvProductos.Rows[i].Cells["colNumero"].Value?.ToString().ToLower() ?? "";
                string producto = dgvProductos.Rows[i].Cells["colProducto"].Value?.ToString().ToLower() ?? "";
                string categoria = dgvProductos.Rows[i].Cells["colCategoria"].Value?.ToString().ToLower() ?? "";

                if (numero.Contains(buscar) ||
                    producto.Contains(buscar) ||
                    categoria.Contains(buscar))
                {
                    SeleccionarFila(i);

                    encontrado = true;

                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show(
                    "No se encontró el producto.",
                    "Buscar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SeleccionarFila(e.RowIndex);
            }
        }

        private void SeleccionarFila(int indice)
        {
            if (indice < 0 || indice >= dgvProductos.Rows.Count)
            {
                return;
            }

            filaSeleccionada = indice;

            dgvProductos.ClearSelection();

            dgvProductos.Rows[indice].Selected = true;

            dgvProductos.CurrentCell = dgvProductos.Rows[indice].Cells[0];

            CargarDatosFila(indice);
        }

        private void CargarDatosFila(int indice)
        {
            DataGridViewRow fila = dgvProductos.Rows[indice];

            txtNumero.Text = fila.Cells["colNumero"].Value?.ToString();
            txtProducto.Text = fila.Cells["colProducto"].Value?.ToString();
            cboCategoria.Text = fila.Cells["colCategoria"].Value?.ToString();

            decimal precio;

            if (decimal.TryParse(
                fila.Cells["colPrecio"].Value?.ToString(),
                out precio))
            {
                nudPrecio.Value = precio;
            }

            decimal cantidad;

            if (decimal.TryParse(
                fila.Cells["colCantidad"].Value?.ToString(),
                out cantidad))
            {
                nudCantidad.Value = cantidad;
            }

            txtSubTotal.Text =
                fila.Cells["colSubTotal"].Value?.ToString();

            string condicion =
                fila.Cells["colCondicion"].Value?.ToString();

            rdbBueno.Checked = condicion == "Bueno";
            rdbRegular.Checked = condicion == "Regular";
            rdbMalo.Checked = condicion == "Malo";

            string estado =
                fila.Cells["colEstado"].Value?.ToString();

            chkActivo.Checked = estado == "Activo";

            btnGrabar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private string ObtenerCondicion()
        {
            if (rdbBueno.Checked)
            {
                return "Bueno";
            }

            if (rdbRegular.Checked)
            {
                return "Regular";
            }

            if (rdbMalo.Checked)
            {
                return "Malo";
            }

            return "";
        }

        private bool ValidarCampos()
        {
            if (txtProducto.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el nombre del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProducto.Focus();
                return false;
            }

            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una categoría.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cboCategoria.Focus();
                return false;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show(
                    "El precio debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudPrecio.Focus();
                return false;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que cero.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudCantidad.Focus();
                return false;
            }

            if (!rdbBueno.Checked &&
                !rdbRegular.Checked &&
                !rdbMalo.Checked)
            {
                MessageBox.Show(
                    "Seleccione la condición del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtProducto.Clear();

            cboCategoria.SelectedIndex = -1;

            nudPrecio.Value = 0;
            nudCantidad.Value = 0;

            txtSubTotal.Text = "0.00";

            rdbBueno.Checked = false;
            rdbRegular.Checked = false;
            rdbMalo.Checked = false;

            chkActivo.Checked = true;

            dgvProductos.ClearSelection();
        }

        private void EstadoInicial()
        {
            LimpiarCampos();

            txtNumero.Text = numeroCorrelativo.ToString();

            btnGrabar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}