using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.EntityConfiguration.Geral
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            this.ToTable("GeralEmpresa");
            this.HasKey(e => e.Id);
            this.Property(t => t.Id).HasColumnName("id").IsRequired();
            this.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(e => e.DocumentoCpfCnpjTipo).HasColumnName("documentotipodocumentocpfcnpj").IsOptional();
            this.Property(e => e.DocumentoCpfCnpj).HasColumnName("documentocpfcnpj").HasMaxLength(20).IsOptional();
            this.Property(e => e.Observacao).HasColumnName("observacao").IsOptional();
            this.Property(f => f.Excluido).HasColumnName("excluido").IsOptional();

            this.HasMany(e => e.Contatos).WithRequired(c => c.Empresa).HasForeignKey(c => c.IdEmpresa);
            this.HasMany(e => e.Tipos).WithRequired(c => c.Empresa).HasForeignKey(c => c.IdEmpresa);
        }
        
    }

    public class EmpresaContatoConfiguration : EntityTypeConfiguration<EmpresaContato>
    {
        public EmpresaContatoConfiguration()
        {
            this.ToTable("GeralEmpresaContatos");
            this.HasKey(ec => ec.Id);
            this.Property(t => t.Id).HasColumnName("id").IsRequired();
            this.Property(ec => ec.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(f => f.Excluido).HasColumnName("excluido").IsOptional();

            this.HasRequired(ec => ec.Empresa).WithMany(e => e.Contatos);
        }
    }

    public class EmpresasTiposConfiguration : EntityTypeConfiguration<EmpresasTipos>
    {
        public EmpresasTiposConfiguration()
        {
            this.ToTable("GeralEmpresasTipos");
            this.HasKey(e => new
            {
                e.IdEmpresa,
                e.IdTipoEmpresa
            });
            this.HasRequired(et => et.Empresa).WithMany(e => e.Tipos);
            this.HasRequired(et => et.TipoEmpresa).WithMany(e => e.Empresas);
        }
    }

    public class TipoEmpresaConfiguration : EntityTypeConfiguration<TipoEmpresa>
    {
        public TipoEmpresaConfiguration()
        {
            this.ToTable("GeralTipoEmpresa");
            this.HasKey(s => s.Id);
            this.Property(p => p.Id).HasColumnName("id").IsRequired();
            this.Property(s => s.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();

            this.HasMany(s => s.Empresas).WithRequired(f => f.TipoEmpresa);
        }
    }
}