using System;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    public partial class frmRegistrarMateria : Form
    {
        private readonly MateriaRepositorio repo = new MateriaRepositorio();

        public frmRegistrarMateria()
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Materia);
            Iconos.Boton(btnAgregar, Properties.Resources.Agregar);
        }

        private void frmRegistrarMateria_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargarGrid();
        }

        private void LimpiarControles()
        {
            txtCiclo.Clear();
            txtCarrera.Clear();
            txtNombre.Clear();
            txtCiclo.Focus();
        }

        private void CargarGrid()
        {
            try
            {
                dgvRegistro.DataSource = null;
                dgvRegistro.DataSource = repo.ObtenerTodos();
                dgvRegistro.Columns["Id"].Visible = false;
                dgvRegistro.Columns["Nombre"].HeaderText = "Materia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la informacion: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                if (repo.Existe(txtCiclo.Text, txtCarrera.Text, txtNombre.Text))
                {
                    MessageBox.Show("Esa materia ya esta registrada en ese ciclo y carrera.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Materia mat = new Materia
                {
                    Ciclo = txtCiclo.Text,
                    Carrera = txtCarrera.Text,
                    Nombre = txtNombre.Text
                };
                repo.Insertar(mat);

                MessageBox.Show("Materia guardada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Materia seleccionada = (Materia)dgvRegistro.Rows[e.RowIndex].DataBoundItem;

            using (frmRegistrarMateriaCmd frm = new frmRegistrarMateriaCmd(seleccionada))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                    CargarGrid();
            }
        }

        private void txtCiclo_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.TextoGeneral(e); }
        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloLetras(e); }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.TextoGeneral(e); }

        private void frmRegistrarMateria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is Button))
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
