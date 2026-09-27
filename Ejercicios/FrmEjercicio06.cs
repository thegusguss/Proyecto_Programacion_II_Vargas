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
    public partial class FrmEjercicio06 : Form
    {
        public FrmEjercicio06()
        {
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double saldo, monto;
            double saldoAnterior;
            int cantidadBilletes = 0;

            if (txtSaldo.Text == "" || txtMonto.Text == "")
            {
                MessageBox.Show("Complete los datos");
                return;
            }

            saldo = Convert.ToDouble(txtSaldo.Text);
            monto = Convert.ToDouble(txtMonto.Text);

            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser positivo");
                return;
            }

            if (monto % 10 != 0)
            {
                MessageBox.Show("El monto debe ser múltiplo de 10");
                return;
            }

            if (monto > saldo)
            {
                MessageBox.Show("Saldo insuficiente");
                return;
            }

            saldoAnterior = saldo;

            int restante = Convert.ToInt32(monto);

            int[] billetes = { 200, 100, 50, 20, 10 };
            dgvBilletes.Rows.Clear();

            for (int i = 0; i < billetes.Length; i++)
            {
                int cantidad = restante / billetes[i];
                restante = restante % billetes[i];

                if (cantidad > 0)
                {
                    dgvBilletes.Rows.Add("S/ " + billetes[i], cantidad);
                    cantidadBilletes = cantidadBilletes + cantidad;
                }
            }

            saldo = saldo - monto;

            txtSaldoAnterior.Text = "S/ " + saldoAnterior.ToString("0.00");
            txtRetirado.Text = "S/ " + monto.ToString("0.00");
            txtCantidadBilletes.Text = cantidadBilletes.ToString();
            txtSaldoRestante.Text = "S/ " + saldo.ToString("0.00");

            txtSaldo.Text = saldo.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMonto.Clear();

            txtSaldoAnterior.Clear();
            txtRetirado.Clear();
            txtCantidadBilletes.Clear();
            txtSaldoRestante.Clear();
            dgvBilletes.Rows.Clear();

            txtMonto.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
