using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfiguration.Portaria;
using Intranet.Domain.Entities;
using Intranet.Domain.Entities.Portaria;

namespace Intranet.Data.Context
{
    public class PortariaContext : DbContext
    {
        public PortariaContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<LocalDestino> LocaisDestino { get; set; }
        public DbSet<RegistroEntrada> RegistrosEntrada { get; set; }

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


            modelBuilder.ComplexType<DadosAlteracaoRegistro>();
            modelBuilder.ComplexType<DadosCriacaoRegistro>();
            modelBuilder.ComplexType<InformacaoEndereco>();
            modelBuilder.ComplexType<InformacaoDocumento>();
            modelBuilder.ComplexType<InformacaoTelefone>();

            modelBuilder.Configurations.Add(new LocalDestinoConfiguration());
            modelBuilder.Configurations.Add(new RegistroEntradaConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}