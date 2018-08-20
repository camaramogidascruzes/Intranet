using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class VeiculoConfiguration : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoConfiguration()
        {
            this.ToTable("TransporteVeiculos");
            this.HasKey(v => v.Id);
            this.Property(v => v.Id).HasColumnName("id").IsRequired();
            this.Property(v => v.Modelo).HasColumnName("modelo").HasMaxLength(255).IsRequired();
            this.Property(v => v.Placa).HasColumnName("placa").HasMaxLength(12).IsRequired();
            this.Property(v => v.Cor).HasColumnName("cor").HasMaxLength(255).IsRequired();
            this.Property(v => v.AnoFabricao).HasColumnName("anofrabricacao").IsRequired();
            this.Property(v => v.AnoModelo).HasColumnName("anomodelo").IsRequired();
            this.Property(v => v.Chassi).HasColumnName("chassi").HasMaxLength(255).IsRequired();
            this.Property(v => v.Renavam).HasColumnName("renavam").HasMaxLength(255).IsRequired();
            this.Property(v => v.NumeroMotor).HasColumnName("numeromotor").HasMaxLength(50).IsRequired();
            this.Property(v => v.Observacao).HasColumnName("observacao").IsRequired();
            this.Property(g => g.Excluido).HasColumnName("excluido").IsRequired();

            this.HasRequired(v => v.EmpresaCompra).WithMany().HasForeignKey(v => v.IdEmpresaCompra);
            this.HasRequired(v => v.Patrimonio).WithMany().HasForeignKey(v => v.IdPatrimonio);
            this.HasRequired(v => v.Seguro).WithMany(s => s.VeiculosCobertos).HasForeignKey(v => v.IdContratoSeguro);


        }
    }
}