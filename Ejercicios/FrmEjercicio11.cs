using System;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio11 : Form
    {
        public FrmEjercicio11()
        {
            InitializeComponent();

            txtPalabra.Focus();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (palabra == "")
            {
                MessageBox.Show(
                    "Ingrese una palabra.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPalabra.Focus();
                return;
            }

            int cantidadVocales = 0;

            foreach (char letra in palabra.ToLower())
            {
                if (letra == 'a' ||
                    letra == 'e' ||
                    letra == 'i' ||
                    letra == 'o' ||
                    letra == 'u')
                {
                    cantidadVocales++;
                }
            }

            txtCantidadVocales.Text = cantidadVocales.ToString();

            if (cantidadVocales % 2 == 0)
            {
                txtTipoCantidad.Text = "Par";

                gbCasoPar.Enabled = true;
                gbCasoImpar.Enabled = false;

                txtNuevaPalabra.Clear();
                txtLongitud.Clear();

                txtFrase.Focus();
            }
            else
            {
                txtTipoCantidad.Text = "Impar";

                gbCasoPar.Enabled = false;
                gbCasoImpar.Enabled = true;

                txtFrase.Clear();
                txtMayusculas.Clear();

                txtNuevaPalabra.Focus();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtTipoCantidad.Text == "")
            {
                MessageBox.Show(
                    "Primero debe analizar una palabra.",
                    "Proceso requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPalabra.Focus();
                return;
            }

            if (txtTipoCantidad.Text == "Par")
            {
                if (txtFrase.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Ingrese una frase.",
                        "Dato requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtFrase.Focus();
                    return;
                }

                txtMayusculas.Text = txtFrase.Text.ToUpper();
            }
            else
            {
                if (txtNuevaPalabra.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Ingrese una nueva palabra.",
                        "Dato requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNuevaPalabra.Focus();
                    return;
                }

                txtLongitud.Text =
                    txtNuevaPalabra.Text.Trim().Length.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();

            txtCantidadVocales.Clear();
            txtTipoCantidad.Clear();

            txtFrase.Clear();
            txtMayusculas.Clear();

            txtNuevaPalabra.Clear();
            txtLongitud.Clear();

            gbCasoPar.Enabled = false;
            gbCasoImpar.Enabled = false;

            txtPalabra.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}