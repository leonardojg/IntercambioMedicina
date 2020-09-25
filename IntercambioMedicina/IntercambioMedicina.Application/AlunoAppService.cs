using System.Collections.Generic;
using IntercambioMedicina.Application.Interface;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicina.Domain.Interfaces.Services;


namespace IntercambioMedicina.Application
{
    public class AlunoAppService : AppServiceBase<Aluno>, IAlunoAppService
    {
        private readonly IAlunoService _alunoService;

        public AlunoAppService(IAlunoService alunoService)
            : base(alunoService)
        {
            _alunoService = alunoService;
        }

        public IEnumerable<Aluno> ObterAlunosEspeciais()
        {
            return _alunoService.ObterAlunoEspeciais(_alunoService.GetAll());
        }
    }
}