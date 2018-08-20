using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class MotoristaConfiguration : EntityTypeConfiguration<Motorista>
    {
        public MotoristaConfiguration()
        {
            this.ToTable("TransporteMotoristas");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(m => m.CarteiraMotoristaNumero).HasColumnName("carteiramotoristanumero").HasMaxLength(255).IsRequired();
            this.Property(m => m.CarteiraMotoristaDataValidade).HasColumnName("carteiramotoristadatavalidade").IsRequired();
            this.Property(c => c.Excluido).HasColumnName("excluido").IsRequired();

            this.HasRequired(m => m.Funcionario).WithMany().HasForeignKey(m => m.IdFuncionario);
            this.HasRequired(m => m.SetorDesignado).WithMany().HasForeignKey(m => m.IdSetor);

        }
    }
}