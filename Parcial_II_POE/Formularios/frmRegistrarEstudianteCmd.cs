using System;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    // Formulario hijo MODAL: devuelve DialogResult.OK si se guardo
    public partial class frmRegistrarEstudianteCmd : Form
    {
        private readonly EstudianteRepositorio repo = new EstudianteRepositorio();
        private readonly Estudiante estudiante;

        public frmRegistrarEstudianteCmd(Estudiante estudiante)
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Estudiante);
            Iconos.Boton(btnGuardar, Properties.Resources.Guardar);
            Iconos.Boton(btnCancelar, Properties.Resources.Cancelar);
            this.estudiante = estudiante.Copiar();   // si cancela, la grilla no cambia
        }

        private void frmRegistrarEstudianteCmd_Load(object sender, EventArgs e)
        {
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            txtCodigo.Text = estudiante.Codigo;
            txtEdad.Text = estudiante.Edad.ToString();
            txtCarrera.Text = estudiante.Carrera;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

            Validaciones.TextBoxesAMayuscula(this);   // BONUS

            try
            {
                if (repo.ExisteCodigo(txtCodigo.Text, estudiante.Id))
                {
                    MessageBox.Show("Ya existe otro estudiante con ese codigo.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;
                }

                estudiante.Nombre = txtNombre.Text;
                estudiante.Apellido = txtApellido.Text;
                estudiante.Codigo = txtCodigo.Text;
                estudiante.Edad = edad;
                estudiante.Carrera = txtCarrera.Text;

                repo.Actualizar(estudiante);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.LetrasYNumeros(e); }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloNumeros(e); }
        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
    }
}
