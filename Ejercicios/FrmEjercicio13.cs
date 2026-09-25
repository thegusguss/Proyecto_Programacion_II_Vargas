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
    public partial class FrmEjercicio13 : Form
    {
        public FrmEjercicio13()
        {
            InitializeComponent();
        }

        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            int codigo;
            string tipo;

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

            if (codigo < 100 || codigo > 999)
            {
                MessageBox.Show("El código debe ser un número de tres cifras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
                return;
            }

            if (codigo % 2 == 0 && codigo % 3 == 0 && codigo % 5 == 0)
            {
                tipo = "Administrativo";
            }
            else if (codigo % 3 == 0 && codigo % 5 == 0 && codigo % 2 != 0)
            {
                tipo = "Directivo";
            }
            else if (codigo % 2 == 0 && codigo % 3 != 0 && codigo % 5 != 0)
            {
                tipo = "Vendedor";
            }
            else if (codigo % 2 != 0 && codigo % 3 != 0 && codigo % 5 != 0)
            {
                tipo = "Seguridad";
            }
            else
            {
                tipo = "No clasificado";
            }

            txtTipo.Text = tipo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtTipo.Clear();
            txtCodigo.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
