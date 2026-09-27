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
    public partial class FrmEjercicio17 : Form
    {
        int cantViajes = 0;
        double totalRecaudado = 0, mayorCosto = 0, menorCosto = 0;
        bool viajeCalculado = false;

        public FrmEjercicio17()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (viajeCalculado == false)
            {
                MessageBox.Show("Primero debe calcular un viaje", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (rdbSi.Checked)
            {
                nudHora.Value = 0;

                txtKilometros.Clear();

                rdbEconomico.Checked = false;
                rdbConfort.Checked = false;
                rdbPremium.Checked = false;

                rdbSi.Checked = false;
                rdbNo.Checked = false;

                lblFranja.Text = "0";
                lblCosto.Text = "0";

                viajeCalculado = false;

                txtKilometros.Focus();
            }
            else if (rdbNo.Checked)
            {
                MessageBox.Show("Sesión finalizada", "Taxi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione Sí o No en ¿Otro viaje?", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nudHora.Value = 0;

            txtKilometros.Clear();

            rdbEconomico.Checked = false;
            rdbConfort.Checked = false;
            rdbPremium.Checked = false;
            rdbSi.Checked = false;
            rdbNo.Checked = false;

            lblFranja.Text = "0";
            lblCosto.Text = "0";
            lblViajes.Text = "0";
            lblTotal.Text = "0";
            lblMayor.Text = "0";
            lblMenor.Text = "0";

            cantViajes = 0;
            totalRecaudado = 0;
            mayorCosto = 0;
            menorCosto = 0;

            viajeCalculado = false;
            txtKilometros.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Desea cerrar el formulario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int hora;

            double kilometros;
            double tarifa = 0;
            double recargo = 0;
            double costo;

            string franja = "";


            if (viajeCalculado == true)
            {
                MessageBox.Show("Primero indique si desea realizar otro viaje", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtKilometros.Text == "")
            {
                MessageBox.Show("Ingrese los kilómetros recorridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKilometros.Focus();
                return;
            }

            if (!double.TryParse(txtKilometros.Text, out kilometros))
            {
                MessageBox.Show("Ingrese un valor numérico en kilómetros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKilometros.Clear();
                txtKilometros.Focus();
                return;
            }

            if (kilometros <= 0)
            {
                MessageBox.Show("Los kilómetros deben ser mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKilometros.Focus();
                return;
            }

            if (rdbEconomico.Checked == false &&
                rdbConfort.Checked == false &&
                rdbPremium.Checked == false)
            {
                MessageBox.Show("Seleccione un tipo de vehículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            hora = Convert.ToInt32(nudHora.Value);

            switch (hora)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:

                    franja = "Madrugada";
                    tarifa = 2.00;

                    break;


                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:

                    franja = "Diurno";
                    tarifa = 1.50;

                    break;


                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:

                    franja = "Nocturno";
                    tarifa = 2.00;

                    break;
            }

            if (rdbEconomico.Checked)
            {
                recargo = 0;
            }
            else if (rdbConfort.Checked)
            {
                recargo = 0.10;
            }
            else if (rdbPremium.Checked)
            {
                recargo = 0.20;
            }

            costo = kilometros * tarifa;
            costo = costo + (costo * recargo);

            lblFranja.Text = franja;
            lblCosto.Text = "S/ " + costo.ToString("0.00");
            cantViajes = cantViajes + 1;
            totalRecaudado = totalRecaudado + costo;

            if (cantViajes == 1)
            {
                mayorCosto = costo;
                menorCosto = costo;
            }
            else
            {
                if (costo > mayorCosto)
                {
                    mayorCosto = costo;
                }

                if (costo < menorCosto)
                {
                    menorCosto = costo;
                }
            }

            lblViajes.Text = cantViajes.ToString();
            lblTotal.Text = "S/ " + totalRecaudado.ToString("0.00");
            lblMayor.Text = "S/ " + mayorCosto.ToString("0.00");
            lblMenor.Text = "S/ " + menorCosto.ToString("0.00");

            viajeCalculado = true;
        }
    }
}
