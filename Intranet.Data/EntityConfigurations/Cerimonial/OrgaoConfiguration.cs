using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Cerimonial;

namespace Intranet.Data.EntityConfigurations.Cerimonial
{
    public class OrgaoConfiguration : EntityTypeConfiguration<Orgao>
    {
        public OrgaoConfiguration()
        {
            this.ToTable("cerimonialorgaos");
            this.HasKey(o => o.Id);
            this.Property(o => o.Id).HasColumnName("id").IsRequired();
            this.Property(o => o.Observacao).HasColumnName("observacao").IsOptional();
            this.Property(o => o.Excluido).HasColumnName("excluido").IsOptional();

            this.HasMany(o => o.Autoridades).WithOptional(a => a.Orgao);
        }
    }
}