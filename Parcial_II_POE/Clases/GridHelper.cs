using System.Windows.Forms;

namespace Parcial_II_POE.Clases
{
    // Configura la grilla de notas (se usa en el Panel y en frmRegistrarNota)
    public static class GridHelper
    {
        public static void ConfigurarNotas(DataGridView dgv)
        {
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["IdEstudiante"].Visible = false;
            dgv.Columns["IdMateria"].Visible = false;

            dgv.Columns["CodigoEstudiante"].HeaderText = "Codigo";
            dgv.Columns["NombreEstudiante"].HeaderText = "Estudiante";
            dgv.Columns["CarreraEstudiante"].HeaderText = "Carrera";
            dgv.Columns["Ciclo"].HeaderText = "Ciclo";
            dgv.Columns["NombreMateria"].HeaderText = "Materia";
            dgv.Columns["Laboratorio"].HeaderText = "Laboratorio (50%)";
            dgv.Columns["Parcial"].HeaderText = "Parcial (40%)";
            dgv.Columns["Asistencia"].HeaderText = "Asistencia (10%)";
            dgv.Columns["NotaFinal"].HeaderText = "Nota Final";

            foreach (string col in new[] { "Laboratorio", "Parcial", "Asistencia", "NotaFinal" })
                dgv.Columns[col].DefaultCellStyle.Format = "N2";
        }
    }
}
