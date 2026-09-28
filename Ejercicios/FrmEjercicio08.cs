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
    public partial class FrmEjercicio08 : Form
    {
        public FrmEjercicio08()
        {
            InitializeComponent();
            ConfigurarTablas();
        }
        private void ConfigurarTablas()
        {
            dgvEstudiante.Rows.Clear();
            dgvCursos.Rows.Clear();

            txtCantEstudiantes.Focus();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantEstudiantes.Text, out int N) || N <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de estudiantes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantEstudiantes.Focus();
                return;
            }

            double[,] matrizA = new double[N, 5];
            string[] cursos = { "Programación", "Base de Datos", "Matemática", "Física", "Economía" };

            dgvEstudiante.Rows.Clear();
            dgvCursos.Rows.Clear();

            for (int i = 0; i < N; i++)
            {
                double sumaNotasEstudiante = 0;

                for (int j = 0; j < 5; j++)
                {
                    string entrada = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Ingrese la nota de {cursos[j]} para el Estudiante {i + 1} (0.0 a 20.0):",
                        $"Captura de Calificaciones - Estudiante {i + 1}");

                    if (string.IsNullOrEmpty(entrada)) return;

                    if (double.TryParse(entrada, out double nota) && nota >= 0.0 && nota <= 20.0)
                    {
                        matrizA[i, j] = nota;
                        sumaNotasEstudiante += nota;
                    }
                    else
                    {
                        MessageBox.Show("Nota inválida. Ingrese una nota válida", "Advertencia", 
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        j = j - 1;
                    }
                }

                double promedioEstudiante = sumaNotasEstudiante / 5;
                dgvEstudiante.Rows.Add($"Estudiante {i + 1}", promedioEstudiante.ToString());

            }

            int totalAprobadosMatriz = 0, totalDesaprobadosMatriz = 0; 
            const double NOTA_APROBATORIA = 10.5;

            for (int j = 0; j < 5; j++)
            {
                double sumaNotasCurso = 0;
                int aprobadosCurso = 0, desaprobadosCurso = 0;

                for (int i = 0; i < N; i++)
                {
                    sumaNotasCurso += matrizA[i, j];

                    if (matrizA[i, j] >= NOTA_APROBATORIA)
                    {
                        aprobadosCurso++;
                        totalAprobadosMatriz++;
                    }
                    else
                    {
                        desaprobadosCurso++;
                        totalDesaprobadosMatriz++;
                    }
                }

                double promedioCurso = sumaNotasCurso / N;
                dgvCursos.Rows.Add(cursos[j], promedioCurso.ToString());
            }

            txtAprobados.Text = totalAprobadosMatriz.ToString();
            txtDesaprobados.Text = totalDesaprobadosMatriz.ToString();

            MessageBox.Show("¡Matriz de calificaciones procesada con éxito!", "Información", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantEstudiantes.Clear();
            txtAprobados.Clear();
            txtDesaprobados.Clear();
            ConfigurarTablas();
        }
    }
}
