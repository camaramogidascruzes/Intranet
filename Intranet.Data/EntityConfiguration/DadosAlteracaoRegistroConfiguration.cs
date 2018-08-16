using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities;

namespace Intranet.Data.EntityConfiguration
{
    class DadosAlteracaoRegistroConfiguration : ComplexTypeConfiguration<DadosAlteracaoRegistro>
    {
        public DadosAlteracaoRegistroConfiguration()
        {
            this.Property(t => t.DataUltimaAlteracao).HasColumnName("DataUltimaAlteracao").IsRequired();
            this.Property(t => t.UsuarioUltimaAlteracao).HasColumnName("UsuarioUltimaAlteracao").HasMaxLength(255).IsRequired();
        }
    }
}