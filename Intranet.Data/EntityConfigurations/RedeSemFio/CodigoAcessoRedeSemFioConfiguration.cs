using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.RedeSemFio;

namespace Intranet.Data.EntityConfigurations.RedeSemFio
{
    public class CodigoAcessoRedeSemFioConfiguration : EntityTypeConfiguration<CodigoAcessoRedeSemFio>
    {
        public CodigoAcessoRedeSemFioConfiguration()
        {
            this.ToTable("RedeSemFioCodigoAcesso");

            this.HasKey(c => c.Id);

            this.Property(a => a.Id).HasColumnName("id").IsRequired();
            this.Property(a => a.Codigo).HasColumnName("codigo").HasMaxLength(255).IsRequired();
            this.Property(a => a.DataEmissao).HasColumnName("dataEmissao").IsRequired();
            this.Property(a => a.Validade).HasColumnName("validade").IsRequired();
            this.Property(a => a.Quota).HasColumnName("Quota").IsRequired();

            this.HasRequired(c => c.Usuario).WithMany(u => u.Codigos).HasForeignKey(c => c.IdUsuarioRedeSemFio);
        }
    }
}