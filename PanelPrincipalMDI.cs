using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas
{
    public partial class PanelPrincipalMDI : Form
    {
        private string usuarioActual;

        private int totalAperturas = 0;

        private Dictionary<string, int> aperturasEjercicios =
            new Dictionary<string, int>();

        public PanelPrincipalMDI(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void PanelPrincipalMDI_Load(object sender, EventArgs e)
        {
            tsslUsuario.Text = "Usuario: " + usuarioActual;
            tsslFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

            lblMasAbierto.Text = "Ninguno";
            lblTotalAperturas.Text = "0";

            tmrReloj.Start();
        }

        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            tsslFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void AbrirFormulario<T>(string nombreEjercicio) where T : Form, new()
        {
            foreach (Form formularioAbierto in MdiChildren)
            {
                if (formularioAbierto is T)
                {
                    formularioAbierto.Activate();
                    return;
                }
            }

            T formulario = new T();

            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;

            formulario.Show();

            RegistrarAcceso(nombreEjercicio);
        }

        private void RegistrarAcceso(string ejercicio)
        {
            string hora = DateTime.Now.ToString("HH:mm:ss");

            ListViewItem fila = new ListViewItem(hora);
            fila.SubItems.Add(ejercicio);

            lvHistorial.Items.Add(fila);

            totalAperturas++;

            if (aperturasEjercicios.ContainsKey(ejercicio))
            {
                aperturasEjercicios[ejercicio]++;
            }
            else
            {
                aperturasEjercicios.Add(ejercicio, 1);
            }

            lblTotalAperturas.Text = totalAperturas.ToString();

            var masAbierto = aperturasEjercicios
                .OrderByDescending(x => x.Value)
                .First();

            string veces = masAbierto.Value == 1 ? "vez" : "veces";

            lblMasAbierto.Text =
                masAbierto.Key + " (" + masAbierto.Value + " " + veces + ")";
        }

        private void ejercicio02ConsumoDeAguaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio03TablaDeMultiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEjercicio03>("Tabla de Multiplicar");
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in MdiChildren)
            {
                formulario.Close();
            }
        }

        private void ejercicio07AgendaDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEjercicio07>("Agenda de Contactos");
        }

        private void ejercicio10EvaluaciónEPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEjercicio10>("Evaluación EPS");
        }

        private void ejercicio11PalabrasYFrasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEjercicio11>("Palabras y Frases");
        }

        private void ejercicio12FizzBuzzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEjercicio12>("Fizz Buzz");
        }

        private void ejercicio15SistemaDeVotaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEjercicio15>("Sistema de Votación");
        }
    }
}