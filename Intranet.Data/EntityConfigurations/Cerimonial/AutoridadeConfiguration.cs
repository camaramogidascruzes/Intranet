using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Cerimonial;

namespace Intranet.Data.EntityConfigurations.Cerimonial
{
    public class AutoridadeConfiguration : EntityTypeConfiguration<Autoridade>
    {
        public AutoridadeConfiguration()
        {
            this.ToTable("CerimonialAutoridades");

            this.HasKey(a => a.Id);

            this.Property(a => a.Id).HasColumnName("id").IsRequired();
            this.Property(a => a.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(a => a.Cargo).HasColumnName("cargo").HasMaxLength(255).IsOptional();
            this.Property(a => a.Observacao).HasColumnName("observacao").IsOptional();
            this.Property(a => a.Excluido).HasColumnName("excluido").IsOptional();

            this.HasOptional(a => a.Tratamento).WithMany(t => t.Autoridades).HasForeignKey(a => a.IdTratamento);
            this.HasOptional(a => a.Orgao).WithMany(o => o.Autoridades).HasForeignKey(a => a.IdOrgao);

            this.HasMany(g => g.Grupos).WithRequired(a => a.Autoridade).HasForeignKey(ga => ga.IdAutoridade).WillCascadeOnDelete();
        }
    }
}