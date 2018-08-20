using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Portaria;

namespace Intranet.Data.EntityConfiguration.Portaria
{
    public class LocalDestinoConfiguration : EntityTypeConfiguration<LocalDestino>
    {
        public LocalDestinoConfiguration()
        {
            this.ToTable("PortariaLocalDestino");
            this.HasKey(l => l.Id);
            this.Property(l => l.Id).HasColumnName("id").IsRequired();
            this.Property(l => l.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(l => l.Atalho).HasColumnName("atalho").HasMaxLength(255).IsRequired();
            this.Property(l => l.Categoria).HasColumnName("categoria").IsRequired();
            this.Property(l => l.Sala).HasColumnName("sala").IsRequired();
            this.Property(f => f.Excluido).HasColumnName("excluido").IsOptional();

            this.HasMany(l => l.Entradas).WithRequired(e => e.LocalDestino).HasForeignKey(l => l.IdLocalDestino);
        }
    }
}