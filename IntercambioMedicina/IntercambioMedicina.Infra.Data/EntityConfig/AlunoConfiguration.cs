

using IntercambioMedicina.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace IntercambioMedicina.Infra.Data.EntityConfig
{
    public class AlunoConfiguration : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfiguration()
        {
            HasKey(a => a.AlunoId);

            Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(a => a.Sobrenome)
              .IsRequired()
              .HasMaxLength(150);

            Property(a => a.Email)
              .IsRequired();
                
        }
    }
}
