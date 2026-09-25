using System;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio15 : Form
    {
        private int[] votos = new int[3];

        private string[] candidatos =
        {
            "Ana Ruiz",
            "Luis Paz",
            "Eva Soto"
        };

        private int votosRegistrados = 0;

        public FrmEjercicio15()
        {
            InitializeComponent();

            nudCantidadVotantes.Minimum = 1;
            nudCantidadVotantes.Maximum = 100;
            nudCantidadVotantes.Value = 1;

            pbParticipacion.Minimum = 0;
            pbParticipacion.Maximum = 100;
            pbParticipacion.Value = 0;

            lblVotosEmitidos.Text = "0";
            lblVotosPendientes.Text = nudCantidadVotantes.Value.ToString();

            lblVotosRegistrados.Text =
                "0 de " + nudCantidadVotantes.Value + " votantes";

            lblPorcentajeParticipacion.Text = "0 %";

            lblGanador.Text = "Sin resultados";
            lblVotosGanador.Text = "";

            nudCantidadVotantes.ValueChanged +=
                nudCantidadVotantes_ValueChanged;

            ActualizarResultados();
        }

        private void nudCantidadVotantes_ValueChanged(object sender, EventArgs e)
        {
            if (votosRegistrados == 0)
            {
                ActualizarResultados();
            }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            int cantidadVotantes =
                Convert.ToInt32(nudCantidadVotantes.Value);

            if (votosRegistrados >= cantidadVotantes)
            {
                MessageBox.Show(
                    "Ya se registraron todos los votos permitidos.",
                    "Votación finalizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            int candidatoSeleccionado = -1;

            if (rbtCandidatoA.Checked)
            {
                candidatoSeleccionado = 0;
            }
            else if (rbtCandidatoB.Checked)
            {
                candidatoSeleccionado = 1;
            }
            else if (rbtCandidatoC.Checked)
            {
                candidatoSeleccionado = 2;
            }

            if (candidatoSeleccionado == -1)
            {
                MessageBox.Show(
                    "Seleccione un candidato antes de votar.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            votos[candidatoSeleccionado]++;

            votosRegistrados++;

            nudCantidadVotantes.Enabled = false;

            rbtCandidatoA.Checked = false;
            rbtCandidatoB.Checked = false;
            rbtCandidatoC.Checked = false;

            ActualizarResultados();

            if (votosRegistrados == cantidadVotantes)
            {
                btnVotar.Enabled = false;

                MessageBox.Show(
                    "Se registraron todos los votos.\nLa votación ha finalizado.",
                    "Votación finalizada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ActualizarResultados()
        {
            dgvResultados.Rows.Clear();

            for (int i = 0; i < votos.Length; i++)
            {
                double porcentaje = 0;

                if (votosRegistrados > 0)
                {
                    porcentaje =
                        (double)votos[i] /
                        votosRegistrados * 100;
                }

                dgvResultados.Rows.Add(
                    candidatos[i],
                    votos[i],
                    porcentaje.ToString("0.0") + " %"
                );
            }

            int cantidadVotantes =
                Convert.ToInt32(nudCantidadVotantes.Value);

            int votosRestantes =
                cantidadVotantes - votosRegistrados;

            if (votosRestantes < 0)
            {
                votosRestantes = 0;
            }

            lblVotosEmitidos.Text =
                votosRegistrados.ToString();

            lblVotosPendientes.Text =
                votosRestantes.ToString();

            lblVotosRegistrados.Text =
                votosRegistrados +
                " de " +
                cantidadVotantes +
                " votantes";

            double porcentajeParticipacion = 0;

            if (cantidadVotantes > 0)
            {
                porcentajeParticipacion =
                    (double)votosRegistrados /
                    cantidadVotantes * 100;
            }

            int valorBarra =
                (int)Math.Round(porcentajeParticipacion);

            if (valorBarra < 0)
            {
                valorBarra = 0;
            }

            if (valorBarra > 100)
            {
                valorBarra = 100;
            }

            pbParticipacion.Value = valorBarra;

            lblPorcentajeParticipacion.Text =
                porcentajeParticipacion.ToString("0.0") + " %";

            MostrarGanador();
        }

        private void MostrarGanador()
        {
            if (votosRegistrados == 0)
            {
                lblGanador.Text = "Sin resultados";
                lblVotosGanador.Text = "";
                return;
            }

            int mayorCantidad = votos[0];

            for (int i = 1; i < votos.Length; i++)
            {
                if (votos[i] > mayorCantidad)
                {
                    mayorCantidad = votos[i];
                }
            }

            string ganadores = "";
            int cantidadGanadores = 0;

            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] == mayorCantidad)
                {
                    if (ganadores != "")
                    {
                        ganadores += " - ";
                    }

                    ganadores += candidatos[i];
                    cantidadGanadores++;
                }
            }

            double porcentajeGanador =
                (double)mayorCantidad /
                votosRegistrados * 100;

            if (cantidadGanadores == 1)
            {
                lblGanador.Text = ganadores;

                lblVotosGanador.Text =
                    mayorCantidad +
                    " votos - " +
                    porcentajeGanador.ToString("0.0") +
                    " %";
            }
            else
            {
                lblGanador.Text =
                    "Empate: " + ganadores;

                lblVotosGanador.Text =
                    mayorCantidad +
                    " votos cada uno - " +
                    porcentajeGanador.ToString("0.0") +
                    " %";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < votos.Length; i++)
            {
                votos[i] = 0;
            }

            votosRegistrados = 0;

            nudCantidadVotantes.Enabled = true;
            nudCantidadVotantes.Value = 1;

            rbtCandidatoA.Checked = false;
            rbtCandidatoB.Checked = false;
            rbtCandidatoC.Checked = false;

            btnVotar.Enabled = true;

            pbParticipacion.Value = 0;

            lblVotosEmitidos.Text = "0";
            lblVotosPendientes.Text =
                nudCantidadVotantes.Value.ToString();

            lblVotosRegistrados.Text =
                "0 de " +
                nudCantidadVotantes.Value +
                " votantes";

            lblPorcentajeParticipacion.Text = "0 %";

            lblGanador.Text = "Sin resultados";
            lblVotosGanador.Text = "";

            ActualizarResultados();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}