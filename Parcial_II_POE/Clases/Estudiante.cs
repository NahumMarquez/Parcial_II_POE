namespace Parcial_II_POE.Clases
{
    // Tabla SQL: Estudiante
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Codigo { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }

        public Estudiante Copiar()
        {
            return (Estudiante)this.MemberwiseClone();
        }
    }
}
