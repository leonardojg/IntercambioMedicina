using IntercambioMedicina.Application.Interface;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicina.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace IntercambioMedicina.Application
{
    public class CursoAppService : AppServiceBase<Curso>, ICursoAppService
    {
        private readonly ICursoService _cursoService;

        public CursoAppService(ICursoService cursoService)
            : base(cursoService)
        {
            _cursoService = cursoService;
        }

        public IEnumerable<Curso> BuscarPorNome(string nome)
        {
            return _cursoService.BuscarPorNome(nome);
        }
    }
}
