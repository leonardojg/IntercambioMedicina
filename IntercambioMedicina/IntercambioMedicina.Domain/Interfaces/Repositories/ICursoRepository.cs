using IntercambioMedicina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercambioMedicina.Domain.Interfaces.Repositories
{
    public interface ICursoRepository : IRepositoryBase<Curso>
    {
        IEnumerable<Curso> BuscarPorNome(string nome);
    }
}
