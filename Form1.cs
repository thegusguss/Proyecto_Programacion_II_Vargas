using System;
using System.Windows.Forms;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtUsuario.Focus();

            this.AcceptButton = btnIngresar;
            this.CancelButton = btnSalir;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim().ToLower();
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

            string nombreUsuario = ValidarUsuario(usuario, contrasena);

            if (nombreUsuario != "")
            {
                MessageBox.Show(
                    "Bienvenido(a), " + nombreUsuario + ".",
                    "Acceso correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Hide();

                PanelPrincipalMDI panelPrincipal =
                    new PanelPrincipalMDI(nombreUsuario);

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

        private string ValidarUsuario(string usuario, string contrasena)
        {
            if (usuario == "gustavo" && contrasena == "1234")
            {
                return "Gustavo Adolfo Vargas Calizaya";
            }

            if (usuario == "yadhira" && contrasena == "1234")
            {
                return "Yadhira Xiomara Shanik Vargas Maquera";
            }

            if (usuario == "mileyde" && contrasena == "1234")
            {
                return "Mileyde Melany Vargas Laura";
            }

            return "";
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