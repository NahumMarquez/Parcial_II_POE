using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    public partial class frmRegistrarNota : Form
    {
        private readonly EstudianteRepositorio repoEstudiante = new EstudianteRepositorio();
        private readonly MateriaRepositorio repoMateria = new MateriaRepositorio();
        private readonly NotaRepositorio repoNota = new NotaRepositorio();

        // evita disparar eventos mientras se llenan los combos por codigo
        private bool cargando = false;

        public frmRegistrarNota()
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Nota);
            Iconos.Boton(btnAgregar, Properties.Resources.Agregar);
        }

        // Form_Load: limpia controles, llena combos y carga la grilla
        private void frmRegistrarNota_Load(object sender, EventArgs e)
        {
            CargarCombos();
            LimpiarControles();
            CargarGrid();
        }

        private void CargarCombos()
        {
            cargando = true;
            try
            {
                cmbEstudiante.DataSource = repoEstudiante.ObtenerTodos()
                    .Select(x => new ItemCombo { Id = x.Id, Texto = x.Codigo + " - " + x.Nombre + " " + x.Apellido })
                    .ToList();
                cmbEstudiante.DisplayMember = "Texto";
                cmbEstudiante.ValueMember = "Id";

                cmbMateria.DataSource = repoMateria.ObtenerTodos()
                    .Select(x => new ItemCombo { Id = x.Id, Texto = x.Nombre + " (" + x.Carrera + " - Ciclo " + x.Ciclo + ")" })
                    .ToList();
                cmbMateria.DisplayMember = "Texto";
                cmbMateria.ValueMember = "Id";

                cmbTipoNota.Items.Clear();
                cmbTipoNota.Items.Add("Laboratorio (50%)");
                cmbTipoNota.Items.Add("Parcial (40%)");
                cmbTipoNota.Items.Add("Asistencia (10%)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cargando = false;
            }
        }

        private void LimpiarControles()
        {
            cargando = true;
            cmbEstudiante.SelectedIndex = -1;
            cmbMateria.SelectedIndex = -1;
            cmbTipoNota.SelectedIndex = -1;
            cargando = false;

            txtLaboratorio.Clear();
            txtParcial.Clear();
            txtAsistencia.Clear();
            BloquearNotas();
            lblNotaFinalValor.Text = "0.00";
        }

        private void BloquearNotas()
        {
            txtLaboratorio.ReadOnly = true;
            txtParcial.ReadOnly = true;
            txtAsistencia.ReadOnly = true;
        }

        private void CargarGrid()
        {
            try
            {
                dgvRegistro.DataSource = null;
                dgvRegistro.DataSource = repoNota.ObtenerDetalle();
                GridHelper.ConfigurarNotas(dgvRegistro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la informacion: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Al elegir estudiante + materia se muestran las notas que ya tiene registradas
        private void CargarNotasActuales()
        {
            txtLaboratorio.Clear();
            txtParcial.Clear();
            txtAsistencia.Clear();

            ItemCombo est = cmbEstudiante.SelectedItem as ItemCombo;
            ItemCombo mat = cmbMateria.SelectedItem as ItemCombo;
            if (est == null || mat == null)
            {
                ActualizarTotal();
                return;
            }

            try
            {
                Nota nota = repoNota.ObtenerPorEstudianteMateria(est.Id, mat.Id);
                if (nota != null)
                {
                    if (nota.Laboratorio.HasValue) txtLaboratorio.Text = Formato(nota.Laboratorio.Value);
                    if (nota.Parcial.HasValue) txtParcial.Text = Formato(nota.Parcial.Value);
                    if (nota.Asistencia.HasValue) txtAsistencia.Text = Formato(nota.Asistencia.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar las notas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarTotal();
        }

        private static string Formato(decimal valor)
        {
            return valor.ToString("0.##", CultureInfo.InvariantCulture);
        }

        // Suma automatica de los porcentajes de las notas escritas hasta el momento
        private void ActualizarTotal()
        {
            decimal lab, parcial, asistencia;
            Validaciones.TryNota(txtLaboratorio.Text, out lab);      // si esta vacia o invalida queda en 0
            Validaciones.TryNota(txtParcial.Text, out parcial);
            Validaciones.TryNota(txtAsistencia.Text, out asistencia);

            Nota temporal = new Nota { Laboratorio = lab, Parcial = parcial, Asistencia = asistencia };
            temporal.CalcularNotaFinal();
            lblNotaFinalValor.Text = temporal.NotaFinal.ToString("N2");
        }

        private void cmbEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            CargarNotasActuales();
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            CargarNotasActuales();
        }

        // Segun la nota elegida se habilita solo su TextBox
        private void cmbTipoNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            BloquearNotas();
            TextBox txt = ObtenerTextBoxSeleccionado();
            if (txt != null)
            {
                txt.ReadOnly = false;
                txt.Focus();
            }
        }

        private TextBox ObtenerTextBoxSeleccionado()
        {
            switch (cmbTipoNota.SelectedIndex)
            {
                case 0: return txtLaboratorio;
                case 1: return txtParcial;
                case 2: return txtAsistencia;
                default: return null;
            }
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ItemCombo est = cmbEstudiante.SelectedItem as ItemCombo;
            ItemCombo mat = cmbMateria.SelectedItem as ItemCombo;

            if (est == null || mat == null)
            {
                MessageBox.Show("Selecciona el estudiante y la materia.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TextBox txt = ObtenerTextBoxSeleccionado();
            if (txt == null)
            {
                MessageBox.Show("Selecciona la nota que vas a registrar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show("Escribe el valor de la nota.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return;
            }

            decimal valor;
            if (!Validaciones.TryNota(txt.Text, out valor))
            {
                MessageBox.Show("La nota debe ser un numero entre 0 y 10.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                txt.SelectAll();
                return;
            }

            Validaciones.TextBoxesAMayuscula(this);   // BONUS

            try
            {
                Nota nota = repoNota.ObtenerPorEstudianteMateria(est.Id, mat.Id);
                bool esNueva = (nota == null);
                if (esNueva)
                    nota = new Nota { IdEstudiante = est.Id, IdMateria = mat.Id };

                // si esa nota ya estaba registrada no se sobrescribe aqui (se edita con doble clic en la grilla)
                bool yaRegistrada =
                    (cmbTipoNota.SelectedIndex == 0 && nota.Laboratorio.HasValue) ||
                    (cmbTipoNota.SelectedIndex == 1 && nota.Parcial.HasValue) ||
                    (cmbTipoNota.SelectedIndex == 2 && nota.Asistencia.HasValue);
                if (yaRegistrada)
                {
                    MessageBox.Show("Esa nota ya fue registrada. Para cambiarla, haz doble clic sobre la fila en la grilla.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbTipoNota.SelectedIndex == 0) nota.Laboratorio = valor;
                else if (cmbTipoNota.SelectedIndex == 1) nota.Parcial = valor;
                else nota.Asistencia = valor;

                nota.CalcularNotaFinal();

                if (esNueva) repoNota.Insertar(nota);
                else repoNota.Actualizar(nota);

                MessageBox.Show("Nota registrada. Nota final actual: " + nota.NotaFinal.ToString("N2"),
                    "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // se mantiene estudiante y materia para seguir ingresando las demas notas
                cargando = true;
                cmbTipoNota.SelectedIndex = -1;
                cargando = false;
                BloquearNotas();
                CargarNotasActuales();
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
            NotaDetalle seleccionada = (NotaDetalle)dgvRegistro.Rows[e.RowIndex].DataBoundItem;

            using (frmRegistrarNotaCmd frm = new frmRegistrarNotaCmd(seleccionada))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    CargarGrid();
                    CargarNotasActuales();
                }
            }
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloDecimal(sender, e); }

        private void frmRegistrarNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !(ActiveControl is Button) && !(ActiveControl is ComboBox))
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
