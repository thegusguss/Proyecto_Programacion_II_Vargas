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
    public partial class FrmEjercicio02 : Form
    {
        public FrmEjercicio02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad, superan30 = 0, usuariomayor = 0, usuariomenor = 0;
            double consumo, pago, totalrecaudado = 0, sumaconsumos = 0, mayorconsumo = 0, menorconsumo = 0;

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de usuarios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cantidad = Convert.ToInt32(txtCantidad.Text);

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad de usuarios debe ser mayor a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvResultados.Rows.Clear();

            for (int i = 1; i <= cantidad; i++)
            {
                string consumoIngresado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el consumo mensual en m³:", "Usuario N° " + i, "");

                if (consumoIngresado == "")
                {
                    MessageBox.Show("Debe ingresar el consumo");
                    return;
                }

                if (!double.TryParse(consumoIngresado, out consumo))
                {
                    MessageBox.Show("Ingrese un valor numérico");
                    i--;
                    continue;
                }

                if (consumo < 0)
                {
                    MessageBox.Show("El consumo no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    i--;
                    continue;
                }

                if (consumo <= 10)
                {
                    pago = 15;
                }
                else if (consumo <= 20)
                {
                    pago = 25;
                }
                else if (consumo <= 30)
                {
                    pago = 40;
                }
                else
                {
                    pago = 40 + ((consumo - 30) * 2);
                }

                totalrecaudado = totalrecaudado + pago;
                sumaconsumos = sumaconsumos + consumo;

                // Mayor y menor consumo
                if (i == 1)
                {
                    mayorconsumo = consumo;
                    menorconsumo = consumo;

                    usuariomayor = i;
                    usuariomenor = i;
                }
                else
                {
                    if (consumo > mayorconsumo)
                    {
                        mayorconsumo = consumo;
                        usuariomayor = i;
                    }

                    if (consumo < menorconsumo)
                    {
                        menorconsumo = consumo;
                        usuariomenor = i;
                    }
                }

                // Contar usuarios que superaron los 30 m³
                if (consumo > 30)
                {
                    superan30 = superan30 + 1;
                }

                dgvResultados.Rows.Add("Usuario N° " + i, consumo.ToString("0.00"), "S/ " + pago.ToString("0.00"));

            }

            double promedio = sumaconsumos / cantidad;

            txtTotalRecaudado.Text = "S/ " + totalrecaudado.ToString("0.00");
            txtMayorConsumo.Text = "Usuario N° " + usuariomayor + " - " + mayorconsumo.ToString("0.00") + " m³";
            txtMenorConsumo.Text = "Usuario N° " + usuariomenor + " - " + menorconsumo.ToString("0.00") + " m³";
            txtPromedio.Text = promedio.ToString("0.00") + " m³";
            txtSuperan30.Text = superan30.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();

            txtTotalRecaudado.Clear();
            txtMayorConsumo.Clear();
            txtMenorConsumo.Clear();
            txtPromedio.Clear();
            txtSuperan30.Clear();

            dgvResultados.Rows.Clear();

            txtCantidad.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
