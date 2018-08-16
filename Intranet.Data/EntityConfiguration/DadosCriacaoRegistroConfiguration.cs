using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities;

namespace Intranet.Data.EntityConfiguration
{
    public class DadosCriacaoRegistroConfiguration : ComplexTypeConfiguration<DadosCriacaoRegistro>
    {
        public DadosCriacaoRegistroConfiguration()
        {
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao").IsRequired();
            this.Property(t => t.UsuarioCriacao).HasColumnName("UsuarioCriacao").HasMaxLength(255).IsRequired();
        }
    }
}