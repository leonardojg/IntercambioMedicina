using IntercambioMedicina.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace IntercambioMedicina.Infra.Data.EntityConfig
{
    public class CursoConfiguration : EntityTypeConfiguration<Curso>
    {
        public CursoConfiguration()
        {
            HasKey(c => c.CursoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.Valor)
              .IsRequired();


            HasRequired(c => c.Aluno)
                .WithMany()
                .HasForeignKey(p => p.AlunoId);
        }

    }
}

