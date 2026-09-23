using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Clases;

namespace TrabajoGrupalUnidad1_Vargas_Vargas_Vargas.Ejercicios
{
    public partial class FrmEjercicio07 : Form
    {
        private List<Contacto> contactos = new List<Contacto>();

        public FrmEjercicio07()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el nombre del contacto.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el teléfono del contacto.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTelefono.Focus();
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Ingrese el correo electrónico.",
                    "Dato requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico válido.",
                    "Correo incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();
                return;
            }

            Contacto nuevoContacto = new Contacto();

            nuevoContacto.Nombre = txtNombre.Text.Trim();
            nuevoContacto.Telefono = txtTelefono.Text.Trim();
            nuevoContacto.Email = txtEmail.Text.Trim();

            contactos.Add(nuevoContacto);

            MostrarContactos(contactos);

            MessageBox.Show(
                "Contacto agregado correctamente.",
                "Agenda de Contactos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione un contacto para eliminar.",
                    "Eliminar contacto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Contacto contactoSeleccionado =
                dgvContactos.SelectedRows[0].Tag as Contacto;

            if (contactoSeleccionado == null)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea eliminar el contacto " +
                contactoSeleccionado.Nombre + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                contactos.Remove(contactoSeleccionado);

                MostrarContactos(contactos);

                MessageBox.Show(
                    "Contacto eliminado correctamente.",
                    "Agenda de Contactos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            MostrarContactos(contactos);
        }

        private void MostrarContactos(IEnumerable<Contacto> lista)
        {
            dgvContactos.Rows.Clear();

            foreach (Contacto contacto in lista)
            {
                int fila = dgvContactos.Rows.Add(
                    contacto.Nombre,
                    contacto.Telefono,
                    contacto.Email);

                dgvContactos.Rows[fila].Tag = contacto;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtBuscar.Text.Trim();

            if (nombreBuscar == "")
            {
                MessageBox.Show(
                    "Ingrese un nombre para realizar la búsqueda.",
                    "Buscar contacto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtBuscar.Focus();
                return;
            }

            List<Contacto> resultados = contactos
                .Where(c => c.Nombre.IndexOf(
                    nombreBuscar,
                    StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            MostrarContactos(resultados);

            if (resultados.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron contactos con ese nombre.",
                    "Resultado de búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}