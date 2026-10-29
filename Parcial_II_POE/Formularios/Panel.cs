using System;
using System.Windows.Forms;
using Parcial_II_POE.Clases;
using Parcial_II_POE.Repositorios;

namespace Parcial_II_POE.Formularios
{
    public partial class Panel : Form
    {
        private readonly NotaRepositorio repoNota = new NotaRepositorio();

        public Panel()
        {
            InitializeComponent();
            Iconos.Formulario(this, Properties.Resources.Panel);
            Iconos.Menu(registrosToolStripMenuItem, Properties.Resources.Estudiante);
            Iconos.Menu(ingresarAEstudiantesToolStripMenuItem, Properties.Resources.Estudiante);
            Iconos.Menu(materiasToolStripMenuItem, Properties.Resources.Materia);
            Iconos.Menu(ingresarAMateriasToolStripMenuItem, Properties.Resources.Materia);
            Iconos.Menu(notasToolStripMenuItem, Properties.Resources.Nota);
            Iconos.Menu(ingresarANotasToolStripMenuItem1, Properties.Resources.Nota);
        }

        private void CerrarFormularioActivo()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void AbrirFormulario(Form frm)
        {
            CerrarFormularioActivo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ingresarAEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarEstudiante());
        }

        private void ingresarAMateriasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarMateria());

        }


        private void ingresarANotasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRegistrarNota());
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        // Form_Load: muestra todas las notas y se suscribe para refrescar cuando algo cambie
        private void Panel_Load(object sender, EventArgs e)
        {
            Notificador.DatosCambiaron += CargarNotas;
            CargarNotas();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Notificador.DatosCambiaron -= CargarNotas;
            base.OnFormClosed(e);
        }

        public void CargarNotas()
        {
            try
            {
                dgvNotas.DataSource = null;
                dgvNotas.DataSource = repoNota.ObtenerDetalle();
                GridHelper.ConfigurarNotas(dgvNotas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las notas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}