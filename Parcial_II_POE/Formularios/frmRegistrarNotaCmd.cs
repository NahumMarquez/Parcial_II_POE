using System;
using System.Globalization;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    // Formulario hijo MODAL para editar las 3 notas de un estudiante en una materia
    public partial class frmRegistrarNotaCmd : Form
    {
        private readonly NotaRepositorio repo = new NotaRepositorio();
        private readonly NotaDetalle detalle;
        private Nota nota;

        public frmRegistrarNotaCmd(NotaDetalle detalle)
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Nota);
            Iconos.Boton(btnGuardar, Properties.Resources.Guardar);
            Iconos.Boton(btnCancelar, Properties.Resources.Cancelar);
            this.detalle = detalle;
        }

        private void frmRegistrarNotaCmd_Load(object sender, EventArgs e)
        {
            lblEstudianteValor.Text = detalle.NombreEstudiante;
            lblMateriaValor.Text = detalle.NombreMateria;

            try
            {
                nota = repo.ObtenerPorId(detalle.Id);
                if (nota.Laboratorio.HasValue) txtLaboratorio.Text = Formato(nota.Laboratorio.Value);
                if (nota.Parcial.HasValue) txtParcial.Text = Formato(nota.Parcial.Value);
                if (nota.Asistencia.HasValue) txtAsistencia.Text = Formato(nota.Asistencia.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la nota: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
            ActualizarTotal();
        }

        private static string Formato(decimal valor)
        {
            return valor.ToString("0.##", CultureInfo.InvariantCulture);
        }

        // Vacio = nota no registrada (null). Devuelve false si hay un valor invalido.
        private bool LeerNota(TextBox txt, string nombre, out decimal? resultado)
        {
            resultado = null;
            if (string.IsNullOrWhiteSpace(txt.Text)) return true;

            decimal valor;
            if (!Validaciones.TryNota(txt.Text, out valor))
            {
                MessageBox.Show("La nota de " + nombre + " debe ser un numero entre 0 y 10.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                txt.SelectAll();
                return false;
            }
            resultado = valor;
            return true;
        }

        private void ActualizarTotal()
        {
            decimal lab, parcial, asistencia;
            Validaciones.TryNota(txtLaboratorio.Text, out lab);
            Validaciones.TryNota(txtParcial.Text, out parcial);
            Validaciones.TryNota(txtAsistencia.Text, out asistencia);

            Nota temporal = new Nota { Laboratorio = lab, Parcial = parcial, Asistencia = asistencia };
            temporal.CalcularNotaFinal();
            lblNotaFinalValor.Text = temporal.NotaFinal.ToString("N2");
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal? lab, parcial, asistencia;
            if (!LeerNota(txtLaboratorio, "Laboratorio", out lab)) return;
            if (!LeerNota(txtParcial, "Parcial", out parcial)) return;
            if (!LeerNota(txtAsistencia, "Asistencia", out asistencia)) return;

            if (!lab.HasValue && !parcial.HasValue && !asistencia.HasValue)
            {
                MessageBox.Show("Debe quedar al menos una nota registrada.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                nota.Laboratorio = lab;
                nota.Parcial = parcial;
                nota.Asistencia = asistencia;
                nota.CalcularNotaFinal();

                repo.Actualizar(nota);
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

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e) { Validaciones.SoloDecimal(sender, e); }
    }
}
