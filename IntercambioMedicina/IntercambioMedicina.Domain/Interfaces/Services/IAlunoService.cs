using IntercambioMedicina.Domain.Entities;
using System.Collections.Generic;

namespace IntercambioMedicina.Domain.Interfaces.Services
{
    public interface IAlunoService : IServiceBase<Aluno>
    {
        IEnumerable<Aluno> ObterAlunoEspeciais(IEnumerable<Aluno> alunos);
    }
}
