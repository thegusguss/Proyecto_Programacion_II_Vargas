using Microsoft.VisualBasic;
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
    public partial class FrmEjercicio09 : Form
    {
        public FrmEjercicio09()
        {
            InitializeComponent();
        }

        private void FrmEjercicio09_Load(object sender, EventArgs e)
        {
            int contador = 1;

            while (contador <= 5)
            {
                string nombre = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese el nombre del estudiante #{contador}:",
                    "Registro de Estudiantes");

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    nombre = "Estudiante " + contador;
                }

                dgvEstudiante.Rows.Add(nombre, "Ingresar", 0, 0, 0, 0, "Pendiente");
                contador++;
            }
        }

        private void dgvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvEstudiante.Columns[e.ColumnIndex].Name == "IngresoNotas")
                {
                    double practica = 0, trabajos = 0, examen = 0;
                    bool notaValida = false;

                    while (!notaValida)
                    {
                        string input = Microsoft.VisualBasic.Interaction.InputBox(
                            "Ingrese nota de Práctica (0 - 20):", "Notas de Práctica");
                        if (string.IsNullOrEmpty(input)) return; 
                        if (double.TryParse(input, out practica) && practica >= 0 && practica <= 20)
                            notaValida = true;
                        else
                            MessageBox.Show("Por favor, ingrese un número válido entre 0 y 20.", 
                                "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    notaValida = false; 
                    while (!notaValida)
                    {
                        string input = Interaction.InputBox("Ingrese nota de Trabajos encargados (0 - 20):", "Notas de Trabajos");
                        if (string.IsNullOrEmpty(input)) return;

                        if (double.TryParse(input, out trabajos) && trabajos >= 0 && trabajos <= 20)
                            notaValida = true;
                        else
                            MessageBox.Show("Por favor, ingrese un número válido entre 0 y 20.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    notaValida = false;
                    while (!notaValida)
                    {
                        string input = Interaction.InputBox("Ingrese nota de Examen Final (0 - 20):", "Nota de Examen Final");
                        if (string.IsNullOrEmpty(input)) return;

                        if (double.TryParse(input, out examen) && examen >= 0 && examen <= 20)
                            notaValida = true;
                        else
                            MessageBox.Show("Por favor, ingrese un número válido entre 0 y 20.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    double notaFinal = (practica * 0.30) + (trabajos * 0.30) + (examen * 0.40);

                    string estado = "";
                    if (notaFinal > 10 && notaFinal <= 20)
                    {
                        estado = "Aprobado";
                    }
                    else if (notaFinal > 2 && notaFinal <= 10)
                    {
                        estado = "Desaprobado";
                    }
                    else
                    {
                        estado = "Abandono";
                    }


                    dgvEstudiante.Rows[e.RowIndex].Cells["Practica"].Value = practica;
                    dgvEstudiante.Rows[e.RowIndex].Cells["Trabajo"].Value = trabajos;
                    dgvEstudiante.Rows[e.RowIndex].Cells["Examen"].Value = examen;
                    dgvEstudiante.Rows[e.RowIndex].Cells["NotaFinal"].Value = Math.Round(notaFinal, 2);
                    dgvEstudiante.Rows[e.RowIndex].Cells["Estado"].Value = estado;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvEstudiante.Rows.Clear();
            FrmEjercicio09_Load(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
