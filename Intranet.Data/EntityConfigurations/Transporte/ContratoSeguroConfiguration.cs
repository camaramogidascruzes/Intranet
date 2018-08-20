using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class ContratoSeguroConfiguration : EntityTypeConfiguration<ContratoSeguro>
    {
        public ContratoSeguroConfiguration()
        {
            this.ToTable("TransporteContratosSeguros");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(c => c.NumeroApolice).HasColumnName("numeroapolice").HasMaxLength(255).IsOptional();
            this.Property(c => c.DataInicio).HasColumnName("dataInicio").IsOptional();
            this.Property(c => c.DataTermino).HasColumnName("dataTermino").IsOptional();
            this.Property(c => c.ValorFranquia).HasColumnName("valorFranquia").IsOptional();
            this.Property(c => c.Observacao).HasColumnName("observacao").IsOptional();
            this.Property(c => c.Excluido).HasColumnName("excluido").IsRequired();

            this.HasRequired(c => c.Empresa).WithMany().HasForeignKey(c => c.IdEmpresa);
            this.HasMany(c => c.VeiculosCobertos).WithRequired(v => v.Seguro);

        }
    }
}