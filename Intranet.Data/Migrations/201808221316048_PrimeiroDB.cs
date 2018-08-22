namespace Intranet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiroDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "intranet.CerimonialAutoridades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        cep = c.String(maxLength: 10),
                        logradouro = c.String(maxLength: 255),
                        numero = c.String(maxLength: 10),
                        complemento = c.String(maxLength: 255),
                        bairro = c.String(maxLength: 255),
                        cidade = c.String(maxLength: 255),
                        uf = c.String(maxLength: 10),
                        cargo = c.String(maxLength: 255),
                        observacao = c.String(),
                        IdTratamento = c.Int(),
                        IdOrgao = c.Int(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.cerimonialorgaos", t => t.IdOrgao)
                .ForeignKey("intranet.CerimonialTratamentos", t => t.IdTratamento)
                .Index(t => t.IdTratamento)
                .Index(t => t.IdOrgao);
            
            CreateTable(
                "intranet.CerimonialAutoridadeGrupos",
                c => new
                    {
                        IdAutoridade = c.Int(nullable: false),
                        IdGrupoCerimonial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdAutoridade, t.IdGrupoCerimonial })
                .ForeignKey("intranet.CerimonialGrupo", t => t.IdGrupoCerimonial, cascadeDelete: true)
                .ForeignKey("intranet.CerimonialAutoridades", t => t.IdAutoridade, cascadeDelete: true)
                .Index(t => t.IdAutoridade)
                .Index(t => t.IdGrupoCerimonial);
            
            CreateTable(
                "intranet.CerimonialGrupo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.cerimonialorgaos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        cep = c.String(maxLength: 10),
                        logradouro = c.String(maxLength: 255),
                        numero = c.String(maxLength: 10),
                        complemento = c.String(maxLength: 255),
                        bairro = c.String(maxLength: 255),
                        cidade = c.String(maxLength: 255),
                        uf = c.String(maxLength: 10),
                        observacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.CerimonialTratamentos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        abreviacao = c.String(nullable: false, maxLength: 255),
                        extenso = c.String(nullable: false, maxLength: 255),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.GeralCargos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 255),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.GeralFuncionariosCargos",
                c => new
                    {
                        idcargo = c.Int(nullable: false),
                        idfuncionario = c.Int(nullable: false),
                        rgf = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => new { t.idcargo, t.idfuncionario })
                .ForeignKey("intranet.GeralFuncionarios", t => t.idfuncionario)
                .ForeignKey("intranet.GeralCargos", t => t.idcargo)
                .Index(t => t.idcargo)
                .Index(t => t.idfuncionario);
            
            CreateTable(
                "intranet.GeralFuncionarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 255),
                        documentocpf = c.String(maxLength: 30),
                        documentoidentidadenumero = c.String(maxLength: 30),
                        documentoidentidadeorgaoemissor = c.String(maxLength: 30),
                        datanascimento = c.DateTime(),
                        IdSetor = c.Int(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "intranet.GeralFuncionarioContatos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255),
                        operadoratelefone = c.String(maxLength: 255),
                        IdFuncionario = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralFuncionarios", t => t.IdFuncionario)
                .Index(t => t.IdFuncionario);
            
            CreateTable(
                "intranet.GeralSetores",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.TelefoniaCatalogo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        PermissaoVisualizacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.TelefoniaCatalogoItens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        local = c.String(nullable: false, maxLength: 255),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255),
                        operadoratelefone = c.String(maxLength: 255),
                        PermissaoVisualizacao = c.Int(nullable: false),
                        IdCatalogo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TelefoniaCatalogo", t => t.IdCatalogo)
                .Index(t => t.IdCatalogo);
            
            CreateTable(
                "intranet.RedeSemFioCategoriaUsuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        validade = c.Int(nullable: false),
                        quota = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.GeralGrupos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false),
                        bloqueado = c.Boolean(nullable: false),
                        IdCategoriaRedeSemFio = c.Int(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.RedeSemFioCategoriaUsuario", t => t.IdCategoriaRedeSemFio)
                .Index(t => t.IdCategoriaRedeSemFio);
            
            CreateTable(
                "intranet.GeralUsuarioGrupo",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false),
                        IdGrupo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => new { t.IdUsuario, t.IdGrupo })
                .ForeignKey("intranet.GeralUsuarios", t => t.IdUsuario)
                .ForeignKey("intranet.GeralGrupos", t => t.IdGrupo)
                .Index(t => t.IdUsuario)
                .Index(t => t.IdGrupo);
            
            CreateTable(
                "intranet.GeralUsuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 255),
                        nome = c.String(nullable: false, maxLength: 255),
                        passwordhHash = c.String(nullable: false, maxLength: 255),
                        dataultimologin = c.DateTime(),
                        terminobloqueio = c.DateTime(),
                        bloqueado = c.Boolean(),
                        quantidadefalhasacesso = c.Int(),
                        ipultimoacesso = c.String(nullable: false, maxLength: 255),
                        necessarioalterarsenha = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.RedeSemFioCodigoAcesso",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 255),
                        dataEmissao = c.DateTime(nullable: false),
                        validade = c.Int(nullable: false),
                        Quota = c.Int(nullable: false),
                        IdUsuarioRedeSemFio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.RedeSemFioUsuario", t => t.IdUsuarioRedeSemFio)
                .Index(t => t.IdUsuarioRedeSemFio);
            
            CreateTable(
                "intranet.RedeSemFioUsuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        documentocpf = c.String(maxLength: 30),
                        documentoidentidadenumero = c.String(maxLength: 30),
                        documentoidentidadeorgaoemissor = c.String(maxLength: 30),
                        datanascimento = c.DateTime(nullable: false),
                        cep = c.String(maxLength: 10),
                        logradouro = c.String(maxLength: 255),
                        numero = c.String(maxLength: 10),
                        complemento = c.String(maxLength: 255),
                        bairro = c.String(maxLength: 255),
                        cidade = c.String(maxLength: 255),
                        uf = c.String(maxLength: 10),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255),
                        operadoratelefone = c.String(maxLength: 255),
                        IdFuncionarioCadastrante = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralFuncionarios", t => t.IdFuncionarioCadastrante)
                .Index(t => t.IdFuncionarioCadastrante);
            
            CreateTable(
                "intranet.TransporteContaCombustivel",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        IdSetor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "intranet.TransporteContaCombustivelQuota",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdTipoCombustivel = c.Int(nullable: false),
                        IdContaCombustivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TransporteTiposCombustivel", t => t.IdTipoCombustivel)
                .ForeignKey("intranet.TransporteContaCombustivel", t => t.IdContaCombustivel)
                .Index(t => t.IdTipoCombustivel)
                .Index(t => t.IdContaCombustivel);
            
            CreateTable(
                "intranet.TransporteContaCombustivelMovimentacao",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdContaCombustivelQuota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TransporteContaCombustivelQuota", t => t.IdContaCombustivelQuota)
                .Index(t => t.IdContaCombustivelQuota);
            
            CreateTable(
                "intranet.TransporteTiposCombustivel",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.TransporteContratosSeguros",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdEmpresa = c.Int(nullable: false),
                        numeroapolice = c.String(maxLength: 255),
                        dataInicio = c.DateTime(),
                        dataTermino = c.DateTime(),
                        valorFranquia = c.Decimal(precision: 18, scale: 2),
                        observacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralEmpresa", t => t.IdEmpresa)
                .Index(t => t.IdEmpresa);
            
            CreateTable(
                "intranet.GeralEmpresa",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        documentotipodocumentocpfcnpj = c.Int(),
                        documentocpfcnpj = c.String(maxLength: 20),
                        cep = c.String(maxLength: 10),
                        logradouro = c.String(maxLength: 255),
                        numero = c.String(maxLength: 10),
                        complemento = c.String(maxLength: 255),
                        bairro = c.String(maxLength: 255),
                        cidade = c.String(maxLength: 255),
                        uf = c.String(maxLength: 10),
                        observacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.GeralEmpresaContatos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255),
                        operadoratelefone = c.String(maxLength: 255),
                        IdEmpresa = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralEmpresa", t => t.IdEmpresa)
                .Index(t => t.IdEmpresa);
            
            CreateTable(
                "intranet.GeralEmpresasTipos",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false),
                        IdTipoEmpresa = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        TipoEmpresa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdEmpresa, t.IdTipoEmpresa })
                .ForeignKey("intranet.GeralTipoEmpresa", t => t.TipoEmpresa_Id)
                .ForeignKey("intranet.GeralEmpresa", t => t.IdEmpresa)
                .Index(t => t.IdEmpresa)
                .Index(t => t.TipoEmpresa_Id);
            
            CreateTable(
                "intranet.GeralTipoEmpresa",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.TransporteVeiculos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        modelo = c.String(nullable: false, maxLength: 255),
                        placa = c.String(nullable: false, maxLength: 12),
                        cor = c.String(nullable: false, maxLength: 255),
                        anofrabricacao = c.Int(nullable: false),
                        anomodelo = c.Int(nullable: false),
                        chassi = c.String(nullable: false, maxLength: 255),
                        renavam = c.String(nullable: false, maxLength: 255),
                        numeromotor = c.String(nullable: false, maxLength: 50),
                        observacao = c.String(nullable: false),
                        IdEmpresaCompra = c.Int(nullable: false),
                        IdPatrimonio = c.Int(nullable: false),
                        IdContratoSeguro = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralEmpresa", t => t.IdEmpresaCompra)
                .ForeignKey("intranet.GeralPatrimonios", t => t.IdPatrimonio)
                .ForeignKey("intranet.TransporteContratosSeguros", t => t.IdContratoSeguro)
                .Index(t => t.IdEmpresaCompra)
                .Index(t => t.IdPatrimonio)
                .Index(t => t.IdContratoSeguro);
            
            CreateTable(
                "intranet.GeralPatrimonios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numero = c.Int(nullable: false),
                        dataaquisicao = c.DateTime(),
                        numeroprocessoaquisicao = c.String(maxLength: 255),
                        datalimitegarantia = c.DateTime(),
                        observacao = c.String(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.TransporteControleDiario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false),
                        numero = c.Int(nullable: false),
                        termoresponsabilidadedestino = c.String(),
                        termoresponsabilidadefinalidade = c.String(),
                        Observacao = c.String(),
                        IdMotorista = c.Int(nullable: false),
                        IdFuncionarioRequisitante = c.Int(),
                        IdParlamentarRequisitante = c.Int(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("intranet.GeralFuncionarios", t => t.IdFuncionarioRequisitante)
                .ForeignKey("intranet.TransporteMotoristas", t => t.IdMotorista)
                .ForeignKey("intranet.GeralParlamentares", t => t.IdParlamentarRequisitante)
                .Index(t => t.IdMotorista)
                .Index(t => t.IdFuncionarioRequisitante)
                .Index(t => t.IdParlamentarRequisitante);
            
            CreateTable(
                "intranet.TransporteAbastecimento",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numerorequisicao = c.String(nullable: false, maxLength: 255),
                        numeronotafiscal = c.String(nullable: false, maxLength: 255),
                        quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        odometro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdControleDiario = c.Int(nullable: false),
                        IdTipoCombustivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TransporteTiposCombustivel", t => t.IdTipoCombustivel)
                .ForeignKey("intranet.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdControleDiario)
                .Index(t => t.IdTipoCombustivel);
            
            CreateTable(
                "intranet.TransporteControleDiarioItinerarioForaMunicipio",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        horasaida = c.Time(nullable: false, precision: 7),
                        horaretorno = c.Time(nullable: false, precision: 7),
                        destino = c.String(nullable: false, maxLength: 255),
                        observacao = c.String(),
                        IdControleDiario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdControleDiario);
            
            CreateTable(
                "intranet.TransporteMotoristas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        carteiramotoristanumero = c.String(nullable: false, maxLength: 255),
                        carteiramotoristadatavalidade = c.DateTime(nullable: false),
                        IdFuncionario = c.Int(nullable: false),
                        IdSetor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralFuncionarios", t => t.IdFuncionario)
                .ForeignKey("intranet.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdFuncionario)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "intranet.GeralParlamentares",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        nomecompleto = c.String(maxLength: 255),
                        IdSetor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "intranet.TransporteControleDiarioPedagio",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        local = c.String(nullable: false, maxLength: 255),
                        numero = c.String(nullable: false, maxLength: 255),
                        datahora = c.DateTime(nullable: false),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        observacao = c.String(),
                        IdControleDiario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdControleDiario);
            
            CreateTable(
                "intranet.TransporteControleDiarioVeiculosUtilizados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        saida = c.DateTime(nullable: false),
                        retorno = c.DateTime(nullable: false),
                        odometroraida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        odometroretorno = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdVeiculo = c.Int(nullable: false),
                        IdControleDiario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("intranet.TransporteVeiculos", t => t.IdVeiculo)
                .ForeignKey("intranet.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdVeiculo)
                .Index(t => t.IdControleDiario);
            
            CreateTable(
                "intranet.PortariaLocalDestino",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255),
                        atalho = c.String(nullable: false, maxLength: 255),
                        categoria = c.Int(nullable: false),
                        sala = c.Int(nullable: false),
                        DataVencimento = c.DateTime(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "intranet.PortariaRegistroEntrada",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdLocalDestino = c.Int(nullable: false),
                        datahoraregistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.PortariaLocalDestino", t => t.IdLocalDestino)
                .Index(t => t.IdLocalDestino);
            
            CreateTable(
                "intranet.TransporteOrdensServico",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numeronotafiscal = c.String(nullable: false, maxLength: 10),
                        datanotafiscal = c.DateTime(nullable: false),
                        valornotafiscal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        descricaoservico = c.String(nullable: false),
                        odometroentrada = c.Decimal(precision: 18, scale: 2),
                        dataentrada = c.DateTime(),
                        dataentrega = c.DateTime(),
                        datalimitegarantia = c.DateTime(),
                        observacao = c.String(),
                        IdVeiculo = c.Int(nullable: false),
                        IdEmpresa = c.Int(),
                        DataCriacao = c.DateTime(nullable: false),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255),
                        DataUltimaAlteracao = c.DateTime(nullable: false),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.GeralEmpresa", t => t.IdEmpresa)
                .ForeignKey("intranet.TransporteVeiculos", t => t.IdVeiculo)
                .Index(t => t.IdVeiculo)
                .Index(t => t.IdEmpresa);
            
            CreateTable(
                "intranet.TransporteOrdensServicoItens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 255),
                        descricao = c.String(),
                        quantidade = c.Decimal(precision: 18, scale: 2),
                        unidade = c.String(),
                        valorunitario = c.Decimal(precision: 18, scale: 2),
                        valortotal = c.Decimal(precision: 18, scale: 2),
                        observacao = c.String(),
                        IdManutencaoOS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("intranet.TransporteOrdensServico", t => t.IdManutencaoOS, cascadeDelete: true)
                .Index(t => t.IdManutencaoOS);
            
        }
        
        public override void Down()
        {
            DropForeignKey("intranet.TransporteOrdensServico", "IdVeiculo", "intranet.TransporteVeiculos");
            DropForeignKey("intranet.TransporteOrdensServicoItens", "IdManutencaoOS", "intranet.TransporteOrdensServico");
            DropForeignKey("intranet.TransporteOrdensServico", "IdEmpresa", "intranet.GeralEmpresa");
            DropForeignKey("intranet.PortariaRegistroEntrada", "IdLocalDestino", "intranet.PortariaLocalDestino");
            DropForeignKey("intranet.TransporteControleDiarioVeiculosUtilizados", "IdControleDiario", "intranet.TransporteControleDiario");
            DropForeignKey("intranet.TransporteControleDiarioVeiculosUtilizados", "IdVeiculo", "intranet.TransporteVeiculos");
            DropForeignKey("intranet.TransporteControleDiarioPedagio", "IdControleDiario", "intranet.TransporteControleDiario");
            DropForeignKey("intranet.TransporteControleDiario", "IdParlamentarRequisitante", "intranet.GeralParlamentares");
            DropForeignKey("intranet.GeralParlamentares", "IdSetor", "intranet.GeralSetores");
            DropForeignKey("intranet.TransporteControleDiario", "IdMotorista", "intranet.TransporteMotoristas");
            DropForeignKey("intranet.TransporteMotoristas", "IdSetor", "intranet.GeralSetores");
            DropForeignKey("intranet.TransporteMotoristas", "IdFuncionario", "intranet.GeralFuncionarios");
            DropForeignKey("intranet.TransporteControleDiarioItinerarioForaMunicipio", "IdControleDiario", "intranet.TransporteControleDiario");
            DropForeignKey("intranet.TransporteControleDiario", "IdFuncionarioRequisitante", "intranet.GeralFuncionarios");
            DropForeignKey("intranet.TransporteAbastecimento", "IdControleDiario", "intranet.TransporteControleDiario");
            DropForeignKey("intranet.TransporteAbastecimento", "IdTipoCombustivel", "intranet.TransporteTiposCombustivel");
            DropForeignKey("intranet.TransporteVeiculos", "IdContratoSeguro", "intranet.TransporteContratosSeguros");
            DropForeignKey("intranet.TransporteVeiculos", "IdPatrimonio", "intranet.GeralPatrimonios");
            DropForeignKey("intranet.TransporteVeiculos", "IdEmpresaCompra", "intranet.GeralEmpresa");
            DropForeignKey("intranet.TransporteContratosSeguros", "IdEmpresa", "intranet.GeralEmpresa");
            DropForeignKey("intranet.GeralEmpresasTipos", "IdEmpresa", "intranet.GeralEmpresa");
            DropForeignKey("intranet.GeralEmpresasTipos", "TipoEmpresa_Id", "intranet.GeralTipoEmpresa");
            DropForeignKey("intranet.GeralEmpresaContatos", "IdEmpresa", "intranet.GeralEmpresa");
            DropForeignKey("intranet.TransporteContaCombustivel", "IdSetor", "intranet.GeralSetores");
            DropForeignKey("intranet.TransporteContaCombustivelQuota", "IdContaCombustivel", "intranet.TransporteContaCombustivel");
            DropForeignKey("intranet.TransporteContaCombustivelQuota", "IdTipoCombustivel", "intranet.TransporteTiposCombustivel");
            DropForeignKey("intranet.TransporteContaCombustivelMovimentacao", "IdContaCombustivelQuota", "intranet.TransporteContaCombustivelQuota");
            DropForeignKey("intranet.RedeSemFioCodigoAcesso", "IdUsuarioRedeSemFio", "intranet.RedeSemFioUsuario");
            DropForeignKey("intranet.RedeSemFioUsuario", "IdFuncionarioCadastrante", "intranet.GeralFuncionarios");
            DropForeignKey("intranet.GeralGrupos", "IdCategoriaRedeSemFio", "intranet.RedeSemFioCategoriaUsuario");
            DropForeignKey("intranet.GeralUsuarioGrupo", "IdGrupo", "intranet.GeralGrupos");
            DropForeignKey("intranet.GeralUsuarioGrupo", "IdUsuario", "intranet.GeralUsuarios");
            DropForeignKey("intranet.TelefoniaCatalogoItens", "IdCatalogo", "intranet.TelefoniaCatalogo");
            DropForeignKey("intranet.GeralFuncionariosCargos", "idcargo", "intranet.GeralCargos");
            DropForeignKey("intranet.GeralFuncionarios", "IdSetor", "intranet.GeralSetores");
            DropForeignKey("intranet.GeralFuncionarioContatos", "IdFuncionario", "intranet.GeralFuncionarios");
            DropForeignKey("intranet.GeralFuncionariosCargos", "idfuncionario", "intranet.GeralFuncionarios");
            DropForeignKey("intranet.CerimonialAutoridades", "IdTratamento", "intranet.CerimonialTratamentos");
            DropForeignKey("intranet.CerimonialAutoridades", "IdOrgao", "intranet.cerimonialorgaos");
            DropForeignKey("intranet.CerimonialAutoridadeGrupos", "IdAutoridade", "intranet.CerimonialAutoridades");
            DropForeignKey("intranet.CerimonialAutoridadeGrupos", "IdGrupoCerimonial", "intranet.CerimonialGrupo");
            DropIndex("intranet.TransporteOrdensServicoItens", new[] { "IdManutencaoOS" });
            DropIndex("intranet.TransporteOrdensServico", new[] { "IdEmpresa" });
            DropIndex("intranet.TransporteOrdensServico", new[] { "IdVeiculo" });
            DropIndex("intranet.PortariaRegistroEntrada", new[] { "IdLocalDestino" });
            DropIndex("intranet.TransporteControleDiarioVeiculosUtilizados", new[] { "IdControleDiario" });
            DropIndex("intranet.TransporteControleDiarioVeiculosUtilizados", new[] { "IdVeiculo" });
            DropIndex("intranet.TransporteControleDiarioPedagio", new[] { "IdControleDiario" });
            DropIndex("intranet.GeralParlamentares", new[] { "IdSetor" });
            DropIndex("intranet.TransporteMotoristas", new[] { "IdSetor" });
            DropIndex("intranet.TransporteMotoristas", new[] { "IdFuncionario" });
            DropIndex("intranet.TransporteControleDiarioItinerarioForaMunicipio", new[] { "IdControleDiario" });
            DropIndex("intranet.TransporteAbastecimento", new[] { "IdTipoCombustivel" });
            DropIndex("intranet.TransporteAbastecimento", new[] { "IdControleDiario" });
            DropIndex("intranet.TransporteControleDiario", new[] { "IdParlamentarRequisitante" });
            DropIndex("intranet.TransporteControleDiario", new[] { "IdFuncionarioRequisitante" });
            DropIndex("intranet.TransporteControleDiario", new[] { "IdMotorista" });
            DropIndex("intranet.TransporteVeiculos", new[] { "IdContratoSeguro" });
            DropIndex("intranet.TransporteVeiculos", new[] { "IdPatrimonio" });
            DropIndex("intranet.TransporteVeiculos", new[] { "IdEmpresaCompra" });
            DropIndex("intranet.GeralEmpresasTipos", new[] { "TipoEmpresa_Id" });
            DropIndex("intranet.GeralEmpresasTipos", new[] { "IdEmpresa" });
            DropIndex("intranet.GeralEmpresaContatos", new[] { "IdEmpresa" });
            DropIndex("intranet.TransporteContratosSeguros", new[] { "IdEmpresa" });
            DropIndex("intranet.TransporteContaCombustivelMovimentacao", new[] { "IdContaCombustivelQuota" });
            DropIndex("intranet.TransporteContaCombustivelQuota", new[] { "IdContaCombustivel" });
            DropIndex("intranet.TransporteContaCombustivelQuota", new[] { "IdTipoCombustivel" });
            DropIndex("intranet.TransporteContaCombustivel", new[] { "IdSetor" });
            DropIndex("intranet.RedeSemFioUsuario", new[] { "IdFuncionarioCadastrante" });
            DropIndex("intranet.RedeSemFioCodigoAcesso", new[] { "IdUsuarioRedeSemFio" });
            DropIndex("intranet.GeralUsuarioGrupo", new[] { "IdGrupo" });
            DropIndex("intranet.GeralUsuarioGrupo", new[] { "IdUsuario" });
            DropIndex("intranet.GeralGrupos", new[] { "IdCategoriaRedeSemFio" });
            DropIndex("intranet.TelefoniaCatalogoItens", new[] { "IdCatalogo" });
            DropIndex("intranet.GeralFuncionarioContatos", new[] { "IdFuncionario" });
            DropIndex("intranet.GeralFuncionarios", new[] { "IdSetor" });
            DropIndex("intranet.GeralFuncionariosCargos", new[] { "idfuncionario" });
            DropIndex("intranet.GeralFuncionariosCargos", new[] { "idcargo" });
            DropIndex("intranet.CerimonialAutoridadeGrupos", new[] { "IdGrupoCerimonial" });
            DropIndex("intranet.CerimonialAutoridadeGrupos", new[] { "IdAutoridade" });
            DropIndex("intranet.CerimonialAutoridades", new[] { "IdOrgao" });
            DropIndex("intranet.CerimonialAutoridades", new[] { "IdTratamento" });
            DropTable("intranet.TransporteOrdensServicoItens");
            DropTable("intranet.TransporteOrdensServico");
            DropTable("intranet.PortariaRegistroEntrada");
            DropTable("intranet.PortariaLocalDestino");
            DropTable("intranet.TransporteControleDiarioVeiculosUtilizados");
            DropTable("intranet.TransporteControleDiarioPedagio");
            DropTable("intranet.GeralParlamentares");
            DropTable("intranet.TransporteMotoristas");
            DropTable("intranet.TransporteControleDiarioItinerarioForaMunicipio");
            DropTable("intranet.TransporteAbastecimento");
            DropTable("intranet.TransporteControleDiario");
            DropTable("intranet.GeralPatrimonios");
            DropTable("intranet.TransporteVeiculos");
            DropTable("intranet.GeralTipoEmpresa");
            DropTable("intranet.GeralEmpresasTipos");
            DropTable("intranet.GeralEmpresaContatos");
            DropTable("intranet.GeralEmpresa");
            DropTable("intranet.TransporteContratosSeguros");
            DropTable("intranet.TransporteTiposCombustivel");
            DropTable("intranet.TransporteContaCombustivelMovimentacao");
            DropTable("intranet.TransporteContaCombustivelQuota");
            DropTable("intranet.TransporteContaCombustivel");
            DropTable("intranet.RedeSemFioUsuario");
            DropTable("intranet.RedeSemFioCodigoAcesso");
            DropTable("intranet.GeralUsuarios");
            DropTable("intranet.GeralUsuarioGrupo");
            DropTable("intranet.GeralGrupos");
            DropTable("intranet.RedeSemFioCategoriaUsuario");
            DropTable("intranet.TelefoniaCatalogoItens");
            DropTable("intranet.TelefoniaCatalogo");
            DropTable("intranet.GeralSetores");
            DropTable("intranet.GeralFuncionarioContatos");
            DropTable("intranet.GeralFuncionarios");
            DropTable("intranet.GeralFuncionariosCargos");
            DropTable("intranet.GeralCargos");
            DropTable("intranet.CerimonialTratamentos");
            DropTable("intranet.cerimonialorgaos");
            DropTable("intranet.CerimonialGrupo");
            DropTable("intranet.CerimonialAutoridadeGrupos");
            DropTable("intranet.CerimonialAutoridades");
        }
    }
}
