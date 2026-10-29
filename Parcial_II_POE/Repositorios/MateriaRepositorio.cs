using Parcial_II_POE.Clases;
using RepoDb;

namespace Parcial_II_POE.Repositorios
{
    public class MateriaRepositorio : RepositorioBase<Materia>
    {
        // Evita repetir la misma materia en el mismo ciclo y carrera
        public bool Existe(string ciclo, string carrera, string nombre, int idExcluir = 0)
        {
            using (var cn = ConexionBD.ObtenerConexion())
            {
                return cn.Count<Materia>(x => x.Ciclo == ciclo && x.Carrera == carrera
                                           && x.Nombre == nombre && x.Id != idExcluir) > 0;
            }
        }
    }
}
