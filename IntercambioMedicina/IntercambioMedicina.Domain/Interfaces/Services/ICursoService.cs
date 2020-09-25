using IntercambioMedicina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercambioMedicina.Domain.Interfaces.Services
{
   public interface ICursoService : IServiceBase<Curso>
    {
        IEnumerable<Curso> BuscarPorNome(string nome);
    }
}
