using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfigurations.Cerimonial;
using Intranet.Domain.Entities;
using Intranet.Domain.Entities.Cerimonial;

namespace Intranet.Data.Context
{
    public class CerimonialContext : DbContext
    {
        public CerimonialContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Autoridade> Autoridades { get; set; }
        public DbSet<AutoridadeGrupoCerimonial> AutoridadesGruposCeronial { get; set; }
        public DbSet<GrupoCerimonial> GruposCerimonial { get; set; }
        public DbSet<Orgao> Orgaos { get; set; }
        public DbSet<Tratamento> Tratamentos { get; set; }


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

            modelBuilder.Configurations.Add(new AutoridadeConfiguration());
            modelBuilder.Configurations.Add(new AutoridadeGrupoCerimonialConfiguration());
            modelBuilder.Configurations.Add(new GrupoCerimonialConfiguration());
            modelBuilder.Configurations.Add(new OrgaoConfiguration());
            modelBuilder.Configurations.Add(new TratamentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}