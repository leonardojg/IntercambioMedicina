using System.Collections.Generic;
using System.Linq;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicina.Domain.Interfaces;
using IntercambioMedicina.Domain.Interfaces.Repositories;

namespace IntercambioMedicina.Infra.Data.Repositories
{
    public class CursoRepository : RepositoryBase<Curso>, ICursoRepository
    {
        public IEnumerable<Curso> BuscarPorNome(string nome)
        {
            return Db.Cursos.Where(c => c.Nome == nome);
        }
    }
}
