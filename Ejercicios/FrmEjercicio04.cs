using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio04 : Form
    {
        private int numeroSecreto;
        private int intentosRestantes;
        private int puntuacion;
        private const int MAX_INTENTOS = 10;
        private void IniciarJuego()
        {
            Random random = new Random();
            numeroSecreto = random.Next(1, 101);
            intentosRestantes = MAX_INTENTOS;
            puntuacion = 100;

            txtMensaje.Text = "¡Buena suerte! Comienza a adivinar.";
            txtIntentos.Text = intentosRestantes.ToString();
            txtPuntuacion.Text = puntuacion.ToString();

            txtNumero.Clear();
            txtNumero.Enabled = true;
            btnAdivinar.Enabled = true;
            txtNumero.Focus();
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int numeroJugador) || numeroJugador < 1 || numeroJugador > 100)
            {
                MessageBox.Show("Ingresa un número válido entre 1 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            intentosRestantes--;
            txtIntentos.Text = intentosRestantes.ToString();

            if (numeroJugador == numeroSecreto)
            {
                txtMensaje.Text = "¡Correcto!";
                txtNumeroSecreto.Text = numeroSecreto.ToString(); //muestra el número en el cuadro grande
                FinalizarJuego(true);
            }
            else
            {
                if (intentosRestantes > 0)
                {
                    puntuacion -= 10; //dsminuye 10 puntos por cada fallo
                    txtPuntuacion.Text = puntuacion.ToString();

                    if (numeroJugador < numeroSecreto)
                        txtMensaje.Text = "El número secreto es mayor.";
                    else
                        txtMensaje.Text = "El número secreto es menor.";

                    txtNumero.Clear();
                    txtNumero.Focus();
                }
                else
                {
                    puntuacion = 0;
                    txtPuntuacion.Text = "0";
                    txtMensaje.Text = "¡Te quedaste sin intentos!";
                    txtNumeroSecreto.Text = numeroSecreto.ToString(); 
                    FinalizarJuego(false);
                }
            }
        }

        private void FinalizarJuego(bool gano)
        {
            txtNumero.Enabled = false;
            btnAdivinar.Enabled = false;

            if (gano)
                MessageBox.Show($"¡Ganaste! Puntuación final: {puntuacion}", "¡Victoria!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"Agotaste tus intentos. El número era {numeroSecreto}.", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        public FrmEjercicio04()
        {
            InitializeComponent();
        }

        private void FrmEjercicio04_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
