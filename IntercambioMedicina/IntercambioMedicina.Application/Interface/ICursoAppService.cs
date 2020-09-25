using IntercambioMedicina.Domain.Entities;
using System.Collections.Generic;

namespace IntercambioMedicina.Application.Interface
{
    public interface ICursoAppService : IAppServiceBase<Curso>
    {
        IEnumerable<Curso> BuscarPorNome(string nome);
    }
}

