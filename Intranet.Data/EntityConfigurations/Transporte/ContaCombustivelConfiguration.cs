using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class ContaCombustivelConfiguration : EntityTypeConfiguration<ContaCombustivel>
    {
        public ContaCombustivelConfiguration()
        {
            this.ToTable("TransporteContaCombustivel");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(c => c.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(c => c.Excluido).HasColumnName("excluido").IsRequired();

            this.HasRequired(c => c.Setor).WithMany().HasForeignKey(c => c.IdSetor);
            this.HasMany(c => c.Quota).WithRequired(q => q.ContaCombustivel);
        }
    }

    public class ContaCombustivelQuotaConfiguration : EntityTypeConfiguration<ContaCombustivelQuota>
    {
        public ContaCombustivelQuotaConfiguration()
        {
            this.ToTable("TransporteContaCombustivelQuota");
            this.HasKey(q => q.Id);
            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(q => q.Quantidade).HasColumnName("quantidade").IsRequired();
            this.Property(q => q.Saldo).HasColumnName("saldo").IsRequired();

            this.HasRequired(q => q.TipoCombustivel).WithMany().HasForeignKey(q => q.IdTipoCombustivel);
            this.HasRequired(q => q.ContaCombustivel).WithMany(c => c.Quota).HasForeignKey(q => q.IdContaCombustivel);

            this.HasMany(q => q.Movimentacao).WithRequired(m => m.Quota);
        }
    }

    public class ContaCombustivelMovimentacaoConfiguration : EntityTypeConfiguration<ContaCombustivelMovimentacao>
    {
        public ContaCombustivelMovimentacaoConfiguration()
        {
            this.ToTable("TransporteContaCombustivelMovimentacao");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id).HasColumnName("id").IsRequired();
            this.Property(m => m.Data).HasColumnName("data").IsRequired();
            this.Property(m => m.Valor).HasColumnName("valor").IsRequired();

            this.HasRequired(m => m.Quota).WithMany(q => q.Movimentacao).HasForeignKey(m => m.IdContaCombustivelQuota);
        }
    }
}