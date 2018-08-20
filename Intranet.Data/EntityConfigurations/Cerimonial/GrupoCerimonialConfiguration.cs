using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Cerimonial;

namespace Intranet.Data.EntityConfigurations.Cerimonial
{
    public class GrupoCerimonialConfiguration : EntityTypeConfiguration<GrupoCerimonial>
    {
        public GrupoCerimonialConfiguration()
        {
            this.ToTable("CerimonialGrupo");
            this.HasKey(s => s.Id);
            this.Property(p => p.Id).HasColumnName("id").IsRequired();
            this.Property(s => s.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(a => a.Excluido).HasColumnName("excluido").IsOptional();

            this.HasMany(s => s.Autoridades).WithRequired(f => f.GrupoCerimonial).HasForeignKey(g => g.IdGrupoCerimonial).WillCascadeOnDelete();
        }
    }
}