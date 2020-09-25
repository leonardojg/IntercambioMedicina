
using System;

namespace IntercambioMedicina.Domain.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public Decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int AlunoId { get; set; }

        public virtual Aluno  Aluno{ get; set; }

    }
}
