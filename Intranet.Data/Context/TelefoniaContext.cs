using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfiguration.Telefonia;
using Intranet.Domain.Entities.Telefonia;

namespace Intranet.Data.Context
{
    public class TelefoniaContext : DbContext
    {
        public TelefoniaContext() : base("name=intranetdatabase")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<CatalogoTelefonico> Catalogos { get; set; }
        public DbSet<ItensCatalogoTelefonico> ItensCatalogos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("intranet");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new DadosCriacaoRegistroConfiguration());
            modelBuilder.Configurations.Add(new DadosAlteracaoRegistroConfiguration());
            modelBuilder.Configurations.Add(new InformacaoEnderecoConfiguration());
            modelBuilder.Configurations.Add(new InformacaoDocumentoConfiguration());
            modelBuilder.Configurations.Add(new InformacaoTelefoneConfiguration());

            modelBuilder.Configurations.Add(new CatalogoTelefonicoConfiguration());
            modelBuilder.Configurations.Add(new ItensCatalogoTelefonicoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}