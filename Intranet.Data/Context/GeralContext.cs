using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfiguration.Geral;
using Intranet.Data.EntityConfiguration.RedeSemFio;
using Intranet.Domain.Entities;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.Context
{
    public class GeralContext : DbContext
    {
        public GeralContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<TipoEmpresa> TiposEmpresa { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Parlamentar> Parlamentares { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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

            modelBuilder.Configurations.Add(new CargoConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new EmpresaContatoConfiguration());
            modelBuilder.Configurations.Add(new EmpresasTiposConfiguration());
            modelBuilder.Configurations.Add(new TipoEmpresaConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioContatoConfiguration());
            modelBuilder.Configurations.Add(new OcupacaoConfiguration());
            modelBuilder.Configurations.Add(new GrupoConfiguration());
            modelBuilder.Configurations.Add(new CategoriaUsuarioRedeSemFioConfiguration());
            modelBuilder.Configurations.Add(new ParlamentarConfiguration());
            modelBuilder.Configurations.Add(new PatrimonioConfiguration());
            modelBuilder.Configurations.Add(new SetorConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new UsuarioGrupoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
