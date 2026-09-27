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
    public partial class FrmEjercicio16 : Form
    {
        int cantManana = 0;
        int cantTarde = 0;
        int cantNoche = 0;

        int totalMatriculados = 0;
        int sumaEdades = 0;

        int cantSistemas = 0;
        int cantCivil = 0;
        int cantIndustrial = 0;
        int cantArquitectura = 0;
        int cantAdministracion = 0;

        public FrmEjercicio16()
        {
            InitializeComponent();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            string dni = "";
            string nombre = "";
            string carrera = "";
            string correo = "";
            string turno = "";

            int edad = 0;
            bool hayError = false;

            try
            {
                if (!mskDNI.MaskCompleted)
                {
                    throw new Exception("El DNI debe tener 8 dígitos");
                }

                dni = mskDNI.Text;
            }
            catch (Exception ex)
            {
                dgvErrores.Rows.Add(DateTime.Now.ToString("HH:mm:ss"), "DNI", ex.Message);
                hayError = true;
            }

            try
            {
                nombre = txtNombre.Text.Trim();

                if (nombre == "")
                {
                    throw new Exception("Debe ingresar el nombre");
                }
            }
            catch (Exception ex)
            {
                dgvErrores.Rows.Add(DateTime.Now.ToString("HH:mm:ss"), "Nombre", ex.Message);
                hayError = true;
            }

            try
            {
                edad = Convert.ToInt32(nudEdad.Value);

                if (edad <= 16)
                {
                    throw new Exception("La edad debe ser mayor a 16 años");
                }
            }
            catch (Exception ex)
            {
                dgvErrores.Rows.Add(DateTime.Now.ToString("HH:mm:ss"), "Edad", ex.Message);
                hayError = true;
            }

            try
            {
                if (cmbCarrera.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una carrera");
                }

                carrera = cmbCarrera.Text;
            }
            catch (Exception ex)
            {
                dgvErrores.Rows.Add(DateTime.Now.ToString("HH:mm:ss"), "Carrera", ex.Message);
                hayError = true;
            }

            try
            {
                correo = txtCorreo.Text.Trim();

                if (correo == "")
                {
                    throw new Exception("Debe ingresar el correo");
                }

                if (!correo.Contains("@"))
                {
                    throw new Exception("El correo debe contener @");
                }
            }
            catch (Exception ex)
            {
                dgvErrores.Rows.Add(DateTime.Now.ToString("HH:mm:ss"), "Correo", ex.Message);

                hayError = true;
            }

            try
            {
                if (rdbManana.Checked)
                {
                    turno = "Mañana";
                }
                else if (rdbTarde.Checked)
                {
                    turno = "Tarde";
                }
                else if (rdbNoche.Checked)
                {
                    turno = "Noche";
                }
                else
                {
                    throw new Exception("Debe seleccionar un turno");
                }
            }
            catch (Exception ex)
            {
                dgvErrores.Rows.Add(
                    DateTime.Now.ToString("HH:mm:ss"),
                    "Turno",
                    ex.Message);

                hayError = true;
            }

            if (hayError == true)
            {
                MessageBox.Show("Existen datos incorrectos. Revise el Log de errores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool repetido = false;

            for (int i = 0; i < dgvEstudiantes.Rows.Count - 1; i++)
            {
                if (dgvEstudiantes.Rows[i].Cells[0].Value.ToString() == dni)
                {
                    repetido = true;
                }
            }

            if (repetido == true)
            {
                MessageBox.Show("El estudiante ya se encuentra matriculado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvEstudiantes.Rows.Add(dni, nombre, edad, carrera, turno);
            totalMatriculados = totalMatriculados + 1;
            sumaEdades = sumaEdades + edad;

            if (turno == "Mañana")
            {
                cantManana = cantManana + 1;
            }
            else if (turno == "Tarde")
            {
                cantTarde = cantTarde + 1;
            }
            else if (turno == "Noche")
            {
                cantNoche = cantNoche + 1;
            }

            if (carrera == "Ing. Sistemas")
            {
                cantSistemas = cantSistemas + 1;
            }
            else if (carrera == "Ing. Civil")
            {
                cantCivil = cantCivil + 1;
            }
            else if (carrera == "Ing. Industrial")
            {
                cantIndustrial = cantIndustrial + 1;
            }
            else if (carrera == "Arquitectura")
            {
                cantArquitectura = cantArquitectura + 1;
            }
            else if (carrera == "Administración")
            {
                cantAdministracion = cantAdministracion + 1;
            }

            lblCantManana.Text = cantManana.ToString();
            lblCantTarde.Text = cantTarde.ToString();
            lblCantNoche.Text = cantNoche.ToString();

            double promedio;
            promedio = (double)sumaEdades / totalMatriculados;

            lblCantPromedio.Text = promedio.ToString("0.00");
            lstCarreras.Items.Clear();
            lstCarreras.Items.Add("Ing. Sistemas: " + cantSistemas);
            lstCarreras.Items.Add("Ing. Civil: " + cantCivil);
            lstCarreras.Items.Add("Ing. Industrial: " + cantIndustrial);
            lstCarreras.Items.Add("Arquitectura: " + cantArquitectura);
            lstCarreras.Items.Add("Administración: " + cantAdministracion);


            MessageBox.Show("Estudiante matriculado correctamente", "Matrícula", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mskDNI.Clear();
            txtNombre.Clear();
            nudEdad.Value = 0;
            cmbCarrera.SelectedIndex = -1;
            txtCorreo.Clear();

            rdbManana.Checked = false;
            rdbTarde.Checked = false;
            rdbNoche.Checked = false;

            mskDNI.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mskDNI.Clear();
            txtNombre.Clear();
            nudEdad.Value = 0;
            cmbCarrera.SelectedIndex = -1;
            txtCorreo.Clear();

            rdbManana.Checked = false;
            rdbTarde.Checked = false;
            rdbNoche.Checked = false;

            mskDNI.Focus();
        }

        private void mskDNI_Enter(object sender, EventArgs e)
        {
            mskDNI.SelectionStart = 0;
        }
    }
}
