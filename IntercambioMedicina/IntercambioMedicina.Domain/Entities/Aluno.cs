

using System;
using System.Collections.Generic;

namespace IntercambioMedicina.Domain.Entities
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<Curso> Cursos { get; set; }

        public bool AlunoEspecial(Aluno aluno)
        {
            return aluno.Ativo && DateTime.Now.Year - aluno.DataCadastro.Year >= 5;
        }
    }
}
