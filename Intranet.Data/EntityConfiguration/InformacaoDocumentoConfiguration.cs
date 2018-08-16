using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities;

namespace Intranet.Data.EntityConfiguration
{
    public class InformacaoDocumentoConfiguration : ComplexTypeConfiguration<InformacaoDocumento>
    {
        public InformacaoDocumentoConfiguration()
        {
            this.Property(f => f.DocumentoCpf).HasColumnName("documentocpf").HasMaxLength(30);
            this.Property(f => f.DocumentoIdentidadeNumero).HasColumnName("documentoidentidadenumero").HasMaxLength(30);
            this.Property(f => f.DocumentoIdentidadeOrgaoEmissor).HasColumnName("documentoidentidadeorgaoemissor").HasMaxLength(30);
        }
    }
}