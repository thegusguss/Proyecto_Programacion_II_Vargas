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
    public partial class FrmEjercicio14 : Form
    {
        public FrmEjercicio14()
        {
            InitializeComponent();
        }

        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            int codigo;
            int estadoCivil;
            int edad;
            int sexo;

            string estadoCivilTexto;
            string sexoTexto;

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código del empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe contener solo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            if (codigo < 1000 || codigo > 9999)
            {
                MessageBox.Show("El código debe tener cuatro cifras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }

            estadoCivil = codigo / 1000;
            edad = (codigo / 10) % 100;
            sexo = codigo % 10;

            if (estadoCivil < 1 || estadoCivil > 4)
            {
                MessageBox.Show("El estado civil debe estar representado por 1, 2, 3 o 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (edad <= 0)
            {
                MessageBox.Show("La edad ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sexo != 1 && sexo != 2)
            {
                MessageBox.Show("El sexo debe estar representado por 1 o 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (estadoCivil == 1)
            {
                estadoCivilTexto = "Soltero";
            }
            else if (estadoCivil == 2)
            {
                estadoCivilTexto = "Casado";
            }
            else if (estadoCivil == 3)
            {
                estadoCivilTexto = "Viudo";
            }
            else
            {
                estadoCivilTexto = "Divorciado";
            }

            if (sexo == 1)
            {
                sexoTexto = "Femenino";
            }
            else
            {
                sexoTexto = "Masculino";
            }

            txtEstadoCivil.Text = estadoCivilTexto;
            txtEdad.Text = edad.ToString();
            txtSexo.Text = sexoTexto;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtEstadoCivil.Clear();
            txtEdad.Clear();
            txtSexo.Clear();

            txtCodigo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
