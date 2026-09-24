using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio03 : Form
    {
        public FrmEjercicio03()
        {
            InitializeComponent();

            cboHasta.Items.Clear();

            for (int i = 1; i <= 20; i++)
            {
                cboHasta.Items.Add(i);
            }

            cboHasta.SelectedIndex = 19;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero;

            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show(
                    "Ingrese un número entero válido.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNumero.Focus();
                return;
            }

            if (cboHasta.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione hasta qué número desea generar la tabla.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboHasta.Focus();
                return;
            }

            int hasta = Convert.ToInt32(cboHasta.SelectedItem);

            int pares = 0;
            int impares = 0;
            int suma = 0;
            int mayor = int.MinValue;
            int multiplosTres = 0;

            dgvTabla.Rows.Clear();

            for (int i = 1; i <= hasta; i++)
            {
                int resultado = numero * i;

                string tipo;
                string multiploTres;

                if (resultado % 2 == 0)
                {
                    tipo = "Par";
                    pares++;
                }
                else
                {
                    tipo = "Impar";
                    impares++;
                }

                if (resultado % 3 == 0)
                {
                    multiploTres = "Sí";
                    multiplosTres++;
                }
                else
                {
                    multiploTres = "No";
                }

                suma += resultado;

                if (resultado > mayor)
                {
                    mayor = resultado;
                }

                dgvTabla.Rows.Add(
                    i,
                    numero + " x " + i,
                    resultado,
                    tipo,
                    multiploTres
                );
            }

            txtPares.Text = pares.ToString();
            txtImpares.Text = impares.ToString();
            txtSuma.Text = suma.ToString();
            txtMayor.Text = mayor.ToString();
            txtMultiplosTres.Text = multiplosTres.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();

            cboHasta.SelectedIndex = 19;

            dgvTabla.Rows.Clear();

            txtPares.Clear();
            txtImpares.Clear();
            txtSuma.Clear();
            txtMayor.Clear();
            txtMultiplosTres.Clear();

            txtNumero.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTabla.Columns[e.ColumnIndex].HeaderText == "Múltiplo de 3" &&
        e.Value != null &&
        e.Value.ToString() == "Sí")
            {
                e.CellStyle.BackColor = Color.FromArgb(210, 250, 220);
                e.CellStyle.ForeColor = Color.Green;
                e.CellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
        }
    }
}