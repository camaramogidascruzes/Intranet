using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class ManutencaoOSConfiguration : EntityTypeConfiguration<ManutencaoOS>
    {
        public ManutencaoOSConfiguration()
        {
            this.ToTable("TransporteOrdensServico");
            this.HasKey(m => m.Id);
            this.Property(m => m.Id).HasColumnName("id").IsRequired();
            this.Property(m => m.NumeroNF).HasColumnName("numeronotafiscal").HasMaxLength(10).IsRequired();
            this.Property(m => m.DataNF).HasColumnName("datanotafiscal").IsRequired();
            this.Property(m => m.ValorNF).HasColumnName("valornotafiscal").IsRequired();
            this.Property(m => m.DescricaoServico).HasColumnName("descricaoservico").IsRequired();
            this.Property(m => m.OdometroEntrada).HasColumnName("odometroentrada").IsOptional();
            this.Property(m => m.DataEntrada).HasColumnName("dataentrada").IsOptional();
            this.Property(m => m.DataEntrega).HasColumnName("dataentrega").IsOptional();
            this.Property(m => m.DataEntrega).HasColumnName("dataentrega").IsOptional();
            this.Property(m => m.DataLimiteGarantia).HasColumnName("datalimitegarantia").IsOptional();
            this.Property(m => m.Observacao).HasColumnName("observacao").IsOptional();
            this.Property(c => c.Excluido).HasColumnName("excluido").IsRequired();

            this.HasRequired(m => m.Veiculo).WithMany().HasForeignKey(m => m.IdVeiculo);
            this.HasOptional(m => m.Empresa).WithMany().HasForeignKey(m => m.IdEmpresa);

            this.HasMany(m => m.Itens).WithRequired(i => i.ManutencaoOS);
        }
    }

    public class ItensManutencaoOSConfiguration : EntityTypeConfiguration<ItensManutencaoOS>
    {
        public ItensManutencaoOSConfiguration()
        {
            this.ToTable("TransporteOrdensServicoItens");
            this.HasKey(m => m.Id);
            this.Property(i => i.Id).HasColumnName("id").IsRequired();
            this.Property(i => i.Codigo).HasColumnName("codigo").HasMaxLength(255).IsRequired();
            this.Property(i => i.Descricao).HasColumnName("descricao").IsOptional();
            this.Property(i => i.Quantidade).HasColumnName("quantidade").IsOptional();
            this.Property(i => i.Unidade).HasColumnName("unidade").IsOptional();
            this.Property(i => i.ValorUnitario).HasColumnName("valorunitario").IsOptional();
            this.Property(i => i.ValorTotal).HasColumnName("valortotal").IsOptional();
            this.Property(i => i.Observacao).HasColumnName("observacao").IsOptional();

            this.HasRequired(i => i.ManutencaoOS).WithMany(m => m.Itens).HasForeignKey(i => i.IdManutencaoOS).WillCascadeOnDelete(true);
        }
    }
}