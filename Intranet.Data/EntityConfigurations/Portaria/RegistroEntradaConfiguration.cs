using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Portaria;

namespace Intranet.Data.EntityConfiguration.Portaria
{
    public class RegistroEntradaConfiguration : EntityTypeConfiguration<RegistroEntrada>
    {
        public RegistroEntradaConfiguration()
        {
            this.ToTable("PortariaRegistroEntrada");
            this.HasKey(r => r.Id);
            this.Property(r => r.Id).HasColumnName("id").IsRequired();
            this.Property(r => r.DataHoraRegistro).HasColumnName("datahoraregistro").IsRequired();


        }   
    }
}