using System;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    public partial class frmRegistrarMateriaCmd : Form
    {
        private readonly MateriaRepositorio repo = new MateriaRepositorio();
        private readonly Materia materia;

        public frmRegistrarMateriaCmd(Materia materia)
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Materia);
            Iconos.Boton(btnGuardar, Properties.Resources.Guardar);
            Iconos.Boton(btnCancelar, Properties.Resources.Cancelar);
            this.materia = materia.Copiar();
        }

        private void frmRegistrarMateriaCmd_Load(object sender, EventArgs e)
        {
            txtCiclo.Text = materia.Ciclo;
            txtCarrera.Text = materia.Carrera;
            txtNombre.Text = materia.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCiclo.Text) || string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Validaciones.TextBoxesAMayuscula(this);   // BONUS

            try
            {
                if (repo.Existe(txtCiclo.Text, txtCarrera.Text, txtNombre.Text, materia.Id))
                {
                    MessageBox.Show("Esa materia ya esta registrada en ese ciclo y carrera.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                materia.Ciclo = txtCiclo.Text;
                materia.Carrera = txtCarrera.Text;
                materia.Nombre = txtNombre.Text;

                repo.Actualizar(materia);
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

        private void txtCiclo_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.TextoGeneral(e); }
        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.TextoGeneral(e); }
    }
}
