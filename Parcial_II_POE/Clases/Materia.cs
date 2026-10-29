namespace Parcial_II_POE.Clases
{
    // Tabla SQL: Materia
    public class Materia
    {
        public int Id { get; set; }
        public string Ciclo { get; set; }
        public string Carrera { get; set; }
        public string Nombre { get; set; }

        public Materia Copiar()
        {
            return (Materia)this.MemberwiseClone();
        }
    }
}
