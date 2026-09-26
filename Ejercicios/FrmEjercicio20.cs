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
    public partial class FrmEjercicio20 : Form
    {
        public FrmEjercicio20()
        {
            InitializeComponent();
        }

        private void btnPedirCarta_Click(object sender, EventArgs e)
        {
            int puntaje, cartas, carta;

            Random aleatorio = new Random();

            puntaje = Convert.ToInt32(lblPuntaje.Text);
            cartas = Convert.ToInt32(lblCartas.Text);

            carta = aleatorio.Next(1, 12);

            puntaje = puntaje + carta;
            cartas = cartas + 1;

            lblPuntaje.Text = puntaje.ToString();
            lblCartas.Text = cartas.ToString();

            MessageBox.Show("Carta obtenida: " + carta);

            if (puntaje > 21)
            {
                int perdidas;

                perdidas = Convert.ToInt32(lblPerdidas.Text);
                perdidas = perdidas + 1;

                lblPerdidas.Text = perdidas.ToString();

                lblResultado.Text = "¡Perdiste! Te pasaste de 21";

                btnPedirCarta.Enabled = false;
                btnPlantarse.Enabled = false;
                btnNuevaRonda.Enabled = true;
            }
        }

        private void btnPlantarse_Click(object sender, EventArgs e)
        {
            int puntaje, cartas, ganadas;

            puntaje = Convert.ToInt32(lblPuntaje.Text);
            cartas = Convert.ToInt32(lblCartas.Text);

            if (cartas == 0)
            {
                MessageBox.Show("Primero debe pedir una carta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (puntaje <= 21)
            {
                ganadas = Convert.ToInt32(lblGanadas.Text);

                ganadas = ganadas + 1;

                lblGanadas.Text = ganadas.ToString();

                lblResultado.Text = "¡Ganaste! Te plantaste con " + puntaje;

                btnPedirCarta.Enabled = false;
                btnPlantarse.Enabled = false;
                btnNuevaRonda.Enabled = true;
            }
        }

        private void btnNuevaRonda_Click(object sender, EventArgs e)
        {
            lblPuntaje.Text = "0";
            lblCartas.Text = "0";
            lblResultado.Text = "";
            btnPedirCarta.Enabled = true;
            btnPlantarse.Enabled = true;
            btnNuevaRonda.Enabled = false;
        }
    }
}
