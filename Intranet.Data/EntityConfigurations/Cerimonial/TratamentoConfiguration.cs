using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Cerimonial;

namespace Intranet.Data.EntityConfigurations.Cerimonial
{
    public class TratamentoConfiguration : EntityTypeConfiguration<Tratamento>
    {
        public TratamentoConfiguration()
        {
            this.ToTable("CerimonialTratamentos");
            this.HasKey(t => t.Id);

            this.Property(t => t.Id).HasColumnName("id").IsRequired();
            this.Property(t => t.Abreviacao).HasColumnName("abreviacao").HasMaxLength(255).IsRequired();
            this.Property(t => t.Extenso).HasColumnName("extenso").HasMaxLength(255).IsRequired();
            this.Property(a => a.Excluido).HasColumnName("excluido").IsOptional();

            this.HasMany(t => t.Autoridades).WithOptional(a => a.Tratamento);
        }
    }
}