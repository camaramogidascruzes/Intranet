using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.RedeSemFio;

namespace Intranet.Data.EntityConfiguration.RedeSemFio
{
    public class CategoriaUsuarioRedeSemFioConfiguration : EntityTypeConfiguration<CategoriaUsuarioRedeSemFio>
    {
        public CategoriaUsuarioRedeSemFioConfiguration()
        {
            this.ToTable("RedeSemFioCategoriaUsuario");
            this.HasKey(c => c.Id);
            this.Property(a => a.Id).HasColumnName("id").IsRequired();
            this.Property(a => a.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(a => a.Validade).HasColumnName("validade").IsRequired();
            this.Property(a => a.Quota).HasColumnName("quota").IsRequired();

            this.HasMany(c => c.Grupos).WithOptional(g => g.CategoriaRedeSemFio).HasForeignKey(g => g.IdCategoriaRedeSemFio);
        }
        
    }
}