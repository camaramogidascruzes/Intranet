
using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.EntityConfiguration.Geral
{
    public class CargoConfiguration : EntityTypeConfiguration<Cargo>
    {
        public CargoConfiguration()
        {
            this.ToTable("GeralCargos");

            this.HasKey(c => c.Id);

            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(c => c.Nome).HasColumnName("nome").HasMaxLength(255);
            this.Property(f => f.Excluido).HasColumnName("Excluido").IsOptional();

            this.HasMany(c => c.Funcionarios).WithRequired(f => f.Cargo).HasForeignKey(f => f.Idcargo);
        }
    }
}
