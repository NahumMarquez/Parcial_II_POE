using System;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    public partial class frmRegistrarEstudiante : Form
    {
        private readonly EstudianteRepositorio repo = new EstudianteRepositorio();

        public frmRegistrarEstudiante()
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Estudiante);
            Iconos.Boton(btnAgregar, Properties.Resources.Agregar);
        }

        // Form_Load: limpia controles y carga la grilla
        private void frmRegistrarEstudiante_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarGrid();
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCodigo.Clear();
            txtEdad.Clear();
            txtCarrera.Clear();
            txtNombre.Focus();
        }

        private void CargarGrid()
        {
            try
            {
                dgvRegistro.DataSource = null;
                dgvRegistro.DataSource = repo.ObtenerTodos();
                dgvRegistro.Columns["Id"].Visible = false;
                dgvRegistro.Columns["Codigo"].HeaderText = "Codigo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la informacion: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int edad;
            if (!int.TryParse(txtEdad.Text, out edad) || edad < 1 || edad > 120)
            {
                MessageBox.Show("La edad debe ser un numero entre 1 y 120.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                txtEdad.SelectAll();
                return;
            }

            // BONUS MAYUSCULA antes de insertar
            Validaciones.TextBoxesAMayuscula(this);

            try
            {
                if (repo.ExisteCodigo(txtCodigo.Text))
                {
                    MessageBox.Show("Ya existe un estudiante con ese codigo.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;
                }

                Estudiante est = new Estudiante
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Codigo = txtCodigo.Text,
                    Edad = edad,
                    Carrera = txtCarrera.Text
                };
                repo.Insertar(est);

                MessageBox.Show("Estudiante guardado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Doble clic en la grilla: abre el formulario hijo modal para editar
        private void dgvRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Estudiante seleccionado = (Estudiante)dgvRegistro.Rows[e.RowIndex].DataBoundItem;

            using (frmRegistrarEstudianteCmd frm = new frmRegistrarEstudianteCmd(seleccionado))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    CargarGrid();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.LetrasYNumeros(e); }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloNumeros(e); }
        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }

        // Enter pasa al siguiente control
        private void frmRegistrarEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is Button))
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
