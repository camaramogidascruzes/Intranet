﻿


using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfiguration.Geral;
using Intranet.Data.EntityConfiguration.Portaria;
using Intranet.Data.EntityConfiguration.Telefonia;
using Intranet.Data.EntityConfigurations.Cerimonial;
using Intranet.Data.EntityConfigurations.RedeSemFio;
using Intranet.Data.EntityConfigurations.Transporte;
using Intranet.Domain.Entities.Cerimonial;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.Entities.Portaria;
using Intranet.Domain.Entities.RedeSemFio;
using Intranet.Domain.Entities.Telefonia;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.Context
{
    public class MigrationContext : DbContext
    {
        public MigrationContext() : base("name=intranetdatabase")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        /* Geral */
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<EmpresaContato> EmpresaContatos { get; set; }
        public virtual DbSet<EmpresasTipos> EmpresasTipos { get; set; }
        public virtual DbSet<TipoEmpresa> TiposEmpresa { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<FuncionarioContato> FuncionarioContatos { get; set; }
        public virtual DbSet<Ocupacao> Ocupacoes { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<Parlamentar> Parlamentares { get; set; }
        public virtual DbSet<Patrimonio> Patrimonios { get; set; }
        public virtual DbSet<Setor> Setores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioGrupo> UsuariosGrupos { get; set; }
        /* Cerimonial */
        public virtual DbSet<Autoridade> Autoridades { get; set; }
        public virtual DbSet<AutoridadeGrupoCerimonial> AutoridadesGruposCeronial { get; set; }
        public virtual DbSet<GrupoCerimonial> GruposCerimonial { get; set; }
        public virtual DbSet<Orgao> Orgaos { get; set; }
        public virtual DbSet<Tratamento> Tratamentos { get; set; }
        /* Portaria */
        public virtual DbSet<LocalDestino> LocaisDestino { get; set; }
        public virtual DbSet<RegistroEntrada> RegistrosEntrada { get; set; }
        /* Rede Sem Fio */
        public virtual DbSet<CategoriaUsuarioRedeSemFio> CategoriasUsuarioRedeSemFio { get; set; }
        public virtual DbSet<CodigoAcessoRedeSemFio> CodigosAcessoRedeSemFio { get; set; }
        public virtual DbSet<UsuarioRedeSemFio> UsuariosRedeSemFio { get; set; }
        /* Telefonia */
        public virtual DbSet<CatalogoTelefonico> Catalogos { get; set; }
        public virtual DbSet<ItensCatalogoTelefonico> ItensCatalogos { get; set; }
        /* TRansporte */
        public virtual DbSet<ContaCombustivel> ContasCombustivels { get; set; }
        public virtual DbSet<ContratoSeguro> ContratosSeguro { get; set; }
        public virtual DbSet<ControleDiario> ControlesDiarios { get; set; }
        public virtual DbSet<ManutencaoOS> Manutencoes { get; set; }
        public virtual DbSet<Motorista> Motoristas { get; set; }
        public virtual DbSet<TipoCombustivel> TiposCombustivel { get; set; }
        public virtual DbSet<Veiculo> Veiculos { get; set; }



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

            /* Cerimonial */
            modelBuilder.Configurations.Add(new AutoridadeConfiguration());
            modelBuilder.Configurations.Add(new AutoridadeGrupoCerimonialConfiguration());
            modelBuilder.Configurations.Add(new GrupoCerimonialConfiguration());
            modelBuilder.Configurations.Add(new OrgaoConfiguration());
            modelBuilder.Configurations.Add(new TratamentoConfiguration());
            /* Geral */
            modelBuilder.Configurations.Add(new CargoConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
            modelBuilder.Configurations.Add(new EmpresaContatoConfiguration());
            modelBuilder.Configurations.Add(new EmpresasTiposConfiguration());
            modelBuilder.Configurations.Add(new TipoEmpresaConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioContatoConfiguration());
            modelBuilder.Configurations.Add(new OcupacaoConfiguration());
            modelBuilder.Configurations.Add(new GrupoConfiguration());
            modelBuilder.Configurations.Add(new ParlamentarConfiguration());
            modelBuilder.Configurations.Add(new PatrimonioConfiguration());
            modelBuilder.Configurations.Add(new SetorConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new UsuarioGrupoConfiguration());
            /* Portaria */
            modelBuilder.Configurations.Add(new LocalDestinoConfiguration());
            modelBuilder.Configurations.Add(new RegistroEntradaConfiguration());
            /* Rede Sem Fio */
            modelBuilder.Configurations.Add(new CategoriaUsuarioRedeSemFioConfiguration());
            modelBuilder.Configurations.Add(new CodigoAcessoRedeSemFioConfiguration());
            modelBuilder.Configurations.Add(new UsuarioRedeSemFioConfiguration());
            /* Telefonia */
            modelBuilder.Configurations.Add(new CatalogoTelefonicoConfiguration());
            modelBuilder.Configurations.Add(new ItensCatalogoTelefonicoConfiguration());
            /* TRansporte */
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
