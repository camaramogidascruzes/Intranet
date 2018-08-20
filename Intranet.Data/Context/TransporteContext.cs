using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfiguration.Geral;
using Intranet.Data.EntityConfigurations.Transporte;
using Intranet.Domain.Entities;
using Intranet.Domain.Entities.Transporte;
using Intranet.Data.EntityConfigurations.RedeSemFio;

namespace Intranet.Data.Context
{
    public class TransporteContext : DbContext
    {
        public TransporteContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<ContaCombustivel> ContasCombustivels { get; set; }
        public DbSet<ContratoSeguro> ContratosSeguro { get; set; }
        public DbSet<ControleDiario> ControlesDiarios { get; set; }
        public DbSet<ManutencaoOS> Manutencoes { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<TipoCombustivel> TiposCombustivel { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }


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

            modelBuilder.Configurations.Add(new ContaCombustivelConfiguration());
            modelBuilder.Configurations.Add(new ContaCombustivelQuotaConfiguration());
            modelBuilder.Configurations.Add(new ContaCombustivelMovimentacaoConfiguration());

            modelBuilder.Configurations.Add(new ContratoSeguroConfiguration());

            modelBuilder.Configurations.Add(new ControleDiarioConfiguration());
            modelBuilder.Configurations.Add(new ControleDiarioVeiculosUtilizadosConfiguration());
            modelBuilder.Configurations.Add(new ControleDiarioPedagioConfiguration());
            modelBuilder.Configurations.Add(new AbastecimentoConfiguration());
            modelBuilder.Configurations.Add(new ControleDiarioItinerarioForaMunicipioConfiguration());

            modelBuilder.Configurations.Add(new ManutencaoOSConfiguration());
            modelBuilder.Configurations.Add(new ItensManutencaoOSConfiguration());

            modelBuilder.Configurations.Add(new MotoristaConfiguration());
            modelBuilder.Configurations.Add(new TipoCombustivelConfiguration());
            modelBuilder.Configurations.Add(new VeiculoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}