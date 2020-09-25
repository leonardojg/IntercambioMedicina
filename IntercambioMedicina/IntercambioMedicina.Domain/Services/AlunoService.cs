using System.Collections.Generic;
using System.Linq;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicina.Domain.Interfaces.Repositories;
using IntercambioMedicina.Domain.Interfaces.Services;

namespace IntercambioMedicina.Domain.Services
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
            :base(alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public IEnumerable<Aluno> ObterAlunoEspeciais(IEnumerable<Aluno> alunos)
        {
            return alunos.Where(a => a.AlunoEspecial(a));
        }
    }
}
