using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class TipoCombustivelConfiguration : EntityTypeConfiguration<TipoCombustivel>
    {
        public TipoCombustivelConfiguration()
        {
            this.ToTable("TransporteTiposCombustivel");
            this.HasKey(t => t.Id);
            this.Property(v => v.Id).HasColumnName("id").IsRequired();
            this.Property(v => v.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(g => g.Excluido).HasColumnName("excluido").IsRequired();
        }
    }
}