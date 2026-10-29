using Parcial_II_POE.Clases;
using RepoDb;

namespace Parcial_II_POE.Repositorios
{
    public class EstudianteRepositorio : RepositorioBase<Estudiante>
    {
        // idExcluir sirve al editar: no compara el registro contra si mismo
        public bool ExisteCodigo(string codigo, int idExcluir = 0)
        {
            using (var cn = ConexionBD.ObtenerConexion())
            {
                return cn.Count<Estudiante>(x => x.Codigo == codigo && x.Id != idExcluir) > 0;
            }
        }
    }
}
