using System;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio12 : Form
    {
        public FrmEjercicio12()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    lstResultados.Items.Add("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    lstResultados.Items.Add("fizz");
                }
                else if (i % 5 == 0)
                {
                    lstResultados.Items.Add("buzz");
                }
                else
                {
                    lstResultados.Items.Add(i);
                }
            }

            lblTotal.Text = lstResultados.Items.Count.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            lblTotal.Text = "0";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}