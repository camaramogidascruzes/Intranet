using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Telefonia;

namespace Intranet.Data.EntityConfiguration.Telefonia
{
    public class CatalogoTelefonicoConfiguration: EntityTypeConfiguration<CatalogoTelefonico>
    {
        public CatalogoTelefonicoConfiguration()
        {
            this.ToTable("TelefoniaCatalogo");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(c => c.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            //this.Property(c => c.PermissaoVisualizacao).HasColumnName("permissaovisualizacao").HasColumnType();
            //this.Property(c => c.Excluido).HasColumnName("excluido").IsOptional();

            this.HasMany(l => l.Itens).WithRequired(e => e.CatalogoTelefonico);
        }
    }

    public class ItensCatalogoTelefonicoConfiguration : EntityTypeConfiguration<ItensCatalogoTelefonico>
    {
        public ItensCatalogoTelefonicoConfiguration()
        {
            this.ToTable("TelefoniaCatalogoItens");
            this.HasKey(i => i.Id);
            this.Property(i => i.Id).HasColumnName("id").IsRequired();
            this.Property(i => i.Local).HasColumnName("local").HasMaxLength(255).IsRequired();
            //this.Property(i => i.PermissaoVisualizacao).HasColumnName("permissaovisualizacao");

            this.HasRequired(i => i.CatalogoTelefonico).WithMany(c => c.Itens).HasForeignKey(i => i.IdCatalogo);
        }
    }
}