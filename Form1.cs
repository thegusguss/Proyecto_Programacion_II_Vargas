using System;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtPassword.Text.Trim();

            if (usuario == "")
            {
                MessageBox.Show(
                    "Ingrese el usuario.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            if (contrasena == "")
            {
                MessageBox.Show(
                    "Ingrese la contraseña.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            if (usuario == "admin" && contrasena == "1234")
            {
                MessageBox.Show(
                    "Acceso correcto.",
                    "Bienvenido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                PanelPrincipalMDI panelPrincipal = new PanelPrincipalMDI(usuario);

                panelPrincipal.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}