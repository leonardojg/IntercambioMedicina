using IntercambioMedicina.Domain.Entities;
using System.Collections.Generic;

namespace IntercambioMedicina.Application.Interface
{
   
    public interface IAlunoAppService : IAppServiceBase<Aluno>
    {
        IEnumerable<Aluno> ObterAlunosEspeciais();
    }
}