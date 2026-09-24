using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio10 : Form
    {
        private readonly string[] turnos =
        {
            "Turno 1",
            "Turno 2",
            "Turno 3",
            "Turno 4"
        };

        private readonly string[] especialidades =
        {
            "Pediatría",
            "Ginecología",
            "Internista",
            "Neurología"
        };

        private readonly decimal[,] datosIniciales =
        {
            { 3.2m, 4.3m, 4.8m, 2.5m },
            { 4.1m, 4.0m, 4.2m, 4.0m },
            { 3.7m, 3.8m, 4.5m, 3.8m },
            { 3.8m, 4.3m, 4.4m, 3.0m }
        };

        private decimal[,] notas = new decimal[4, 4];

        public FrmEjercicio10()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CargarDatosIniciales();
        }

        private void ConfigurarFormulario()
        {
            cboTurno.Items.Clear();
            cboEspecialidad.Items.Clear();

            cboTurno.Items.AddRange(turnos);
            cboEspecialidad.Items.AddRange(especialidades);

            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTurno.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;

            nudNota.Minimum = 1;
            nudNota.Maximum = 5;
            nudNota.DecimalPlaces = 1;
            nudNota.Increment = 0.1m;
            nudNota.Value = 3.5m;

            dgvEvaluaciones.AllowUserToAddRows = false;
            dgvEvaluaciones.AllowUserToDeleteRows = false;
            dgvEvaluaciones.ReadOnly = true;
            dgvEvaluaciones.MultiSelect = false;
            dgvEvaluaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluaciones.RowHeadersVisible = false;

            txtTurnosAprobados.ReadOnly = true;
            txtMejorEspecialidad.ReadOnly = true;
            txtMejorTurno.ReadOnly = true;
            txtMejorNota.ReadOnly = true;
            txtPromedioGeneral.ReadOnly = true;
            txtPromedioPediatria.ReadOnly = true;
            txtPromedioGinecologia.ReadOnly = true;
            txtPromedioInternista.ReadOnly = true;
            txtPromedioNeurologia.ReadOnly = true;
        }

        private void CargarDatosIniciales()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    notas[i, j] = datosIniciales[i, j];
                }
            }

            MostrarMatriz();
            LimpiarResultados();
        }

        private void MostrarMatriz()
        {
            dgvEvaluaciones.Rows.Clear();

            for (int i = 0; i < 4; i++)
            {
                dgvEvaluaciones.Rows.Add(
                    turnos[i],
                    notas[i, 0].ToString("0.0"),
                    notas[i, 1].ToString("0.0"),
                    notas[i, 2].ToString("0.0"),
                    notas[i, 3].ToString("0.0")
                );
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboTurno.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un turno.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboTurno.Focus();
                return;
            }

            if (cboEspecialidad.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una especialidad.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboEspecialidad.Focus();
                return;
            }

            int fila = cboTurno.SelectedIndex;
            int columna = cboEspecialidad.SelectedIndex;

            decimal nota = nudNota.Value;

            notas[fila, columna] = nota;

            MostrarMatriz();
            LimpiarResultados();

            MessageBox.Show(
                "Evaluación registrada correctamente.\n\n" +
                "Turno: " + turnos[fila] + "\n" +
                "Especialidad: " + especialidades[columna] + "\n" +
                "Nota: " + nota.ToString("0.0"),
                "Evaluación actualizada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            List<string> turnosAprobados = new List<string>();

            decimal sumaGeneral = 0;
            decimal mayorNota = notas[0, 0];

            int filaMayor = 0;
            int columnaMayor = 0;

            decimal[] sumaEspecialidades = new decimal[4];

            for (int i = 0; i < 4; i++)
            {
                bool todasMayoresIgualCuatro = true;

                for (int j = 0; j < 4; j++)
                {
                    decimal notaActual = notas[i, j];

                    sumaGeneral += notaActual;
                    sumaEspecialidades[j] += notaActual;

                    if (notaActual < 4.0m)
                    {
                        todasMayoresIgualCuatro = false;
                    }

                    if (notaActual > mayorNota)
                    {
                        mayorNota = notaActual;
                        filaMayor = i;
                        columnaMayor = j;
                    }
                }

                if (todasMayoresIgualCuatro)
                {
                    turnosAprobados.Add(turnos[i]);
                }
            }

            decimal promedioGeneral = sumaGeneral / 16;

            txtTurnosAprobados.Text =
                turnosAprobados.Count > 0
                ? string.Join(", ", turnosAprobados)
                : "Ninguno";

            txtMejorEspecialidad.Text = especialidades[columnaMayor];
            txtMejorTurno.Text = turnos[filaMayor];
            txtMejorNota.Text = mayorNota.ToString("0.0");

            txtPromedioGeneral.Text = promedioGeneral.ToString("0.00");

            txtPromedioPediatria.Text =
                (sumaEspecialidades[0] / 4).ToString("0.00");

            txtPromedioGinecologia.Text =
                (sumaEspecialidades[1] / 4).ToString("0.00");

            txtPromedioInternista.Text =
                (sumaEspecialidades[2] / 4).ToString("0.00");

            txtPromedioNeurologia.Text =
                (sumaEspecialidades[3] / 4).ToString("0.00");
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            CargarDatosIniciales();

            cboTurno.SelectedIndex = 0;
            cboEspecialidad.SelectedIndex = 0;
            nudNota.Value = 3.5m;

            MessageBox.Show(
                "Las evaluaciones fueron restablecidas.",
                "Restablecer",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarResultados()
        {
            txtTurnosAprobados.Clear();
            txtMejorEspecialidad.Clear();
            txtMejorTurno.Clear();
            txtMejorNota.Clear();
            txtPromedioGeneral.Clear();
            txtPromedioPediatria.Clear();
            txtPromedioGinecologia.Clear();
            txtPromedioInternista.Clear();
            txtPromedioNeurologia.Clear();
        }
    }
}