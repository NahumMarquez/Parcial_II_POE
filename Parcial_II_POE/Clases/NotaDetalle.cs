namespace Parcial_II_POE.Clases
{
    // NO es una tabla: es lo que se muestra en las grillas de notas
    // (Nota + datos del estudiante + datos de la materia). El orden = orden de columnas.
    public class NotaDetalle
    {
        public int Id { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
        public string CodigoEstudiante { get; set; }
        public string NombreEstudiante { get; set; }
        public string CarreraEstudiante { get; set; }
        public string Ciclo { get; set; }
        public string NombreMateria { get; set; }
        public decimal? Laboratorio { get; set; }
        public decimal? Parcial { get; set; }
        public decimal? Asistencia { get; set; }
        public decimal NotaFinal { get; set; }
    }
}
