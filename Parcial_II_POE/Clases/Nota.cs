using System;

namespace Parcial_II_POE.Clases
{
    // Tabla SQL: Nota  (una fila por estudiante + materia)
    // Las notas son decimal? porque se van registrando una por una; null = aun no registrada
    public class Nota
    {
        public int Id { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
        public decimal? Laboratorio { get; set; }   // 50%
        public decimal? Parcial { get; set; }       // 40%
        public decimal? Asistencia { get; set; }    // 10%
        public decimal NotaFinal { get; set; }

        // NotaFinal = (Laboratorio * 0.5) + (Parcial * 0.4) + (Asistencia * 0.1)
        // Suma solo lo que ya se registro (lo que falta cuenta como 0)
        public void CalcularNotaFinal()
        {
            NotaFinal = Math.Round(
                ((Laboratorio ?? 0m) * 0.5m) +
                ((Parcial ?? 0m) * 0.4m) +
                ((Asistencia ?? 0m) * 0.1m), 2);
        }
    }
}
