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
    public partial class FrmEjercicio05 : Form
    {
        public FrmEjercicio05()
        {
            InitializeComponent();
        }

        private int rondaActual = 1, victoriasUsuario = 0, victoriasComputadora = 0, empates = 0;
        private const int MAX_RONDAS = 5;
        private string eleccionUsuario = "", eleccionComputadora = "";
        private Random random = new Random();

        private void btnSiguienteRonda_Click(object sender, EventArgs e)
        {
            if (rondaActual < MAX_RONDAS)
            {
                rondaActual++;
                gbxRondas.Text = $"Ronda {rondaActual}";
                txtResultado.Clear();
                pcbUsuario.Image = null;
                pcbComputadora.Image = null;
                AlternarBotonesSeleccion(true);
                btnSiguienteRonda.Enabled = false;
            }
            else
            {
                EvaluarGanadorFinal();
            }
        }

        private void InicializarJuego()
        {
            rondaActual = 1;
            victoriasUsuario = 0;
            victoriasComputadora = 0;
            empates = 0;
            gbxRondas.Text = $"Ronda {rondaActual}";
            txtResultado.Clear();
            txtResultadoFinal.Clear();
            dgvVictorias.Rows.Clear();

            pcbUsuario.Image = null;
            pcbComputadora.Image = null;
            AlternarBotonesSeleccion(true);
            btnSiguienteRonda.Enabled = false;
        }

        private void FrmEjercicio05_Load(object sender, EventArgs e)
        {
            InicializarJuego();
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            ProcesarJugada("Piedra");
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            ProcesarJugada("Papel");
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            ProcesarJugada("Tijera");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarJuego();
        }

        private void ProcesarJugada(string eleccion)
        {
            eleccionUsuario = eleccion;
            string[] opciones = { "Piedra", "Papel", "Tijera" };
            eleccionComputadora = opciones[random.Next(0, 3)];

            AsignarImagenControl(pcbUsuario, eleccionUsuario);
            AsignarImagenControl(pcbComputadora, eleccionComputadora);

            string resultadoRonda = "";

            if (eleccionUsuario == eleccionComputadora)
            {
                resultadoRonda = "Empate";
                empates++;
            }
            else if ((eleccionUsuario == "Piedra" && eleccionComputadora == "Tijera") ||
                     (eleccionUsuario == "Papel" && eleccionComputadora == "Piedra") ||
                     (eleccionUsuario == "Tijera" && eleccionComputadora == "Papel"))
            {
                resultadoRonda = "Ganaste";
                victoriasUsuario++;
            }
            else
            {
                resultadoRonda = "Perdiste";
                victoriasComputadora++;
            }

            dgvVictorias.Rows.Add(rondaActual, eleccionUsuario, eleccionComputadora);
            txtResultado.Text = $"¡{resultadoRonda} esta ronda!";
            AlternarBotonesSeleccion(false);
            btnSiguienteRonda.Enabled = true;

            if (rondaActual == MAX_RONDAS)
            {
                btnSiguienteRonda.Text = "Ver Resultado Final";
            }
        }

        private void AsignarImagenControl(PictureBox pcbControl, string eleccion)
        {
            switch (eleccion)
            {
                case "Piedra":
                    pcbControl.Image = Properties.Resources.puno;
                    break;
                case "Papel":
                    pcbControl.Image = Properties.Resources.mano;
                    break;
                case "Tijera":
                    pcbControl.Image = Properties.Resources.tijeras;
                    break;
            }
            pcbControl.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void EvaluarGanadorFinal()
        {
            btnSiguienteRonda.Enabled = false;
            AlternarBotonesSeleccion(false);
            string ganadorFinal = "";

            if (victoriasUsuario > victoriasComputadora)
                ganadorFinal = "¡USUARIO ES EL GANADOR FINAL!";
            else if (victoriasComputadora > victoriasUsuario)
                ganadorFinal = "LA COMPUTADORA GANA EL JUEGO";
            else
                ganadorFinal = "¡EL JUEGO HA TERMINADO EN EMPATE!";

            txtResultadoFinal.Text = $"U: {victoriasUsuario} | CPU: {victoriasComputadora} | Empates: {empates} -> {ganadorFinal}";

            MessageBox.Show($"Juego Terminado.\n\nUsuario: {victoriasUsuario} victorias\nComputadora: {victoriasComputadora} victorias\nEmpates: {empates}\n\n{ganadorFinal}",
                            "Fin de la partida", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("¿Quieres jugar otra partida?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnSiguienteRonda.Text = "Siguiente Ronda";
                InicializarJuego();
            }
        }

        private void AlternarBotonesSeleccion(bool estado)
        {
            btnPiedra.Enabled = estado;
            btnPapel.Enabled = estado;
            btnTijera.Enabled = estado;
        }
    }
}
