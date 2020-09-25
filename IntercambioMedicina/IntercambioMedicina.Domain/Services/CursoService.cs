using System.Collections.Generic;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicina.Domain.Interfaces.Repositories;
using IntercambioMedicina.Domain.Interfaces.Services;

namespace IntercambioMedicina.Domain.Services
{
    public class CursoService : ServiceBase<Curso>, ICursoService
    {
        private readonly ICursoRepository _cursoRepository;

        public CursoService(ICursoRepository cursoRepository)
                : base(cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        public IEnumerable<Curso> BuscarPorNome(string nome)
        {
            return _cursoRepository.BuscarPorNome(nome);
        }
    }
}
