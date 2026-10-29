using System.Collections.Generic;
using System.Linq;
using Parcial_II_POE.Clases;
using RepoDb;

namespace Parcial_II_POE.Repositorios
{
    public class NotaRepositorio : RepositorioBase<Nota>
    {
        public Nota ObtenerPorId(int id)
        {
            using (var cn = ConexionBD.ObtenerConexion())
            {
                return cn.Query<Nota>(x => x.Id == id).FirstOrDefault();
            }
        }

        // Devuelve la fila de notas de ese estudiante en esa materia (o null si aun no tiene)
        public Nota ObtenerPorEstudianteMateria(int idEstudiante, int idMateria)
        {
            using (var cn = ConexionBD.ObtenerConexion())
            {
                return cn.Query<Nota>(x => x.IdEstudiante == idEstudiante && x.IdMateria == idMateria)
                         .FirstOrDefault();
            }
        }

        // Une Nota + Estudiante + Materia para mostrar en la grilla
        public List<NotaDetalle> ObtenerDetalle()
        {
            List<Estudiante> estudiantes = new EstudianteRepositorio().ObtenerTodos();
            List<Materia> materias = new MateriaRepositorio().ObtenerTodos();
            List<Nota> notas = ObtenerTodos();

            return (from n in notas
                    join e in estudiantes on n.IdEstudiante equals e.Id
                    join m in materias on n.IdMateria equals m.Id
                    orderby n.Id
                    select new NotaDetalle
                    {
                        Id = n.Id,
                        IdEstudiante = n.IdEstudiante,
                        IdMateria = n.IdMateria,
                        CodigoEstudiante = e.Codigo,
                        NombreEstudiante = e.Nombre + " " + e.Apellido,
                        CarreraEstudiante = e.Carrera,
                        Ciclo = m.Ciclo,
                        NombreMateria = m.Nombre,
                        Laboratorio = n.Laboratorio,
                        Parcial = n.Parcial,
                        Asistencia = n.Asistencia,
                        NotaFinal = n.NotaFinal
                    }).ToList();
        }
    }
}
