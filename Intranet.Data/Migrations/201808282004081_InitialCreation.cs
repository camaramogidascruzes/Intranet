namespace Intranet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CerimonialAutoridades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        logradouro = c.String(maxLength: 255, storeType: "nvarchar"),
                        numero = c.String(maxLength: 10, storeType: "nvarchar"),
                        complemento = c.String(maxLength: 255, storeType: "nvarchar"),
                        bairro = c.String(maxLength: 255, storeType: "nvarchar"),
                        cidade = c.String(maxLength: 255, storeType: "nvarchar"),
                        uf = c.String(maxLength: 10, storeType: "nvarchar"),
                        cargo = c.String(maxLength: 255, storeType: "nvarchar"),
                        observacao = c.String(unicode: false),
                        IdTratamento = c.Int(),
                        IdOrgao = c.Int(),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cerimonialorgaos", t => t.IdOrgao)
                .ForeignKey("dbo.CerimonialTratamentos", t => t.IdTratamento)
                .Index(t => t.IdTratamento)
                .Index(t => t.IdOrgao);
            
            CreateTable(
                "dbo.CerimonialAutoridadeGrupos",
                c => new
                    {
                        IdAutoridade = c.Int(nullable: false),
                        IdGrupoCerimonial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdAutoridade, t.IdGrupoCerimonial })
                .ForeignKey("dbo.CerimonialGrupo", t => t.IdGrupoCerimonial, cascadeDelete: true)
                .ForeignKey("dbo.CerimonialAutoridades", t => t.IdAutoridade, cascadeDelete: true)
                .Index(t => t.IdAutoridade)
                .Index(t => t.IdGrupoCerimonial);
            
            CreateTable(
                "dbo.CerimonialGrupo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.cerimonialorgaos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        logradouro = c.String(maxLength: 255, storeType: "nvarchar"),
                        numero = c.String(maxLength: 10, storeType: "nvarchar"),
                        complemento = c.String(maxLength: 255, storeType: "nvarchar"),
                        bairro = c.String(maxLength: 255, storeType: "nvarchar"),
                        cidade = c.String(maxLength: 255, storeType: "nvarchar"),
                        uf = c.String(maxLength: 10, storeType: "nvarchar"),
                        observacao = c.String(unicode: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CerimonialTratamentos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        abreviacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        extenso = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.GeralCargos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 255, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.GeralFuncionariosCargos",
                c => new
                    {
                        idcargo = c.Int(nullable: false),
                        idfuncionario = c.Int(nullable: false),
                        rgf = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.idcargo, t.idfuncionario })
                .ForeignKey("dbo.GeralFuncionarios", t => t.idfuncionario)
                .ForeignKey("dbo.GeralCargos", t => t.idcargo)
                .Index(t => t.idcargo)
                .Index(t => t.idfuncionario);
            
            CreateTable(
                "dbo.GeralFuncionarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 255, storeType: "nvarchar"),
                        documentocpf = c.String(maxLength: 30, storeType: "nvarchar"),
                        documentoidentidadenumero = c.String(maxLength: 30, storeType: "nvarchar"),
                        documentoidentidadeorgaoemissor = c.String(maxLength: 30, storeType: "nvarchar"),
                        datanascimento = c.DateTime(precision: 0),
                        IdSetor = c.Int(),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "dbo.GeralFuncionarioContatos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        operadoratelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        IdFuncionario = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralFuncionarios", t => t.IdFuncionario)
                .Index(t => t.IdFuncionario);
            
            CreateTable(
                "dbo.GeralSetores",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TelefoniaCatalogo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        PermissaoVisualizacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TelefoniaCatalogoItens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        local = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        operadoratelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        PermissaoVisualizacao = c.Int(nullable: false),
                        IdCatalogo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TelefoniaCatalogo", t => t.IdCatalogo)
                .Index(t => t.IdCatalogo);
            
            CreateTable(
                "dbo.RedeSemFioCategoriaUsuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        validade = c.Int(nullable: false),
                        quota = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.GeralGrupos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, unicode: false),
                        bloqueado = c.Boolean(nullable: false),
                        IdCategoriaRedeSemFio = c.Int(),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RedeSemFioCategoriaUsuario", t => t.IdCategoriaRedeSemFio)
                .Index(t => t.IdCategoriaRedeSemFio);
            
            CreateTable(
                "dbo.GeralUsuarioGrupo",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false),
                        IdGrupo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.IdUsuario, t.IdGrupo })
                .ForeignKey("dbo.GeralUsuarios", t => t.IdUsuario)
                .ForeignKey("dbo.GeralGrupos", t => t.IdGrupo)
                .Index(t => t.IdUsuario)
                .Index(t => t.IdGrupo);
            
            CreateTable(
                "dbo.GeralUsuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        passwordhHash = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        dataultimologin = c.DateTime(precision: 0),
                        terminobloqueio = c.DateTime(precision: 0),
                        bloqueado = c.Boolean(),
                        quantidadefalhasacesso = c.Int(),
                        ipultimoacesso = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        necessarioalterarsenha = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.RedeSemFioCodigoAcesso",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        dataEmissao = c.DateTime(nullable: false, precision: 0),
                        validade = c.Int(nullable: false),
                        Quota = c.Int(nullable: false),
                        IdUsuarioRedeSemFio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.RedeSemFioUsuario", t => t.IdUsuarioRedeSemFio)
                .Index(t => t.IdUsuarioRedeSemFio);
            
            CreateTable(
                "dbo.RedeSemFioUsuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        documentocpf = c.String(maxLength: 30, storeType: "nvarchar"),
                        documentoidentidadenumero = c.String(maxLength: 30, storeType: "nvarchar"),
                        documentoidentidadeorgaoemissor = c.String(maxLength: 30, storeType: "nvarchar"),
                        datanascimento = c.DateTime(nullable: false, precision: 0),
                        cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        logradouro = c.String(maxLength: 255, storeType: "nvarchar"),
                        numero = c.String(maxLength: 10, storeType: "nvarchar"),
                        complemento = c.String(maxLength: 255, storeType: "nvarchar"),
                        bairro = c.String(maxLength: 255, storeType: "nvarchar"),
                        cidade = c.String(maxLength: 255, storeType: "nvarchar"),
                        uf = c.String(maxLength: 10, storeType: "nvarchar"),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        operadoratelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        IdFuncionarioCadastrante = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralFuncionarios", t => t.IdFuncionarioCadastrante)
                .Index(t => t.IdFuncionarioCadastrante);
            
            CreateTable(
                "dbo.TransporteContaCombustivel",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        IdSetor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "dbo.TransporteContaCombustivelQuota",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        saldo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdTipoCombustivel = c.Int(nullable: false),
                        IdContaCombustivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TransporteTiposCombustivel", t => t.IdTipoCombustivel)
                .ForeignKey("dbo.TransporteContaCombustivel", t => t.IdContaCombustivel)
                .Index(t => t.IdTipoCombustivel)
                .Index(t => t.IdContaCombustivel);
            
            CreateTable(
                "dbo.TransporteContaCombustivelMovimentacao",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false, precision: 0),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdContaCombustivelQuota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TransporteContaCombustivelQuota", t => t.IdContaCombustivelQuota)
                .Index(t => t.IdContaCombustivelQuota);
            
            CreateTable(
                "dbo.TransporteTiposCombustivel",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TransporteContratosSeguros",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdEmpresa = c.Int(nullable: false),
                        numeroapolice = c.String(maxLength: 255, storeType: "nvarchar"),
                        dataInicio = c.DateTime(precision: 0),
                        dataTermino = c.DateTime(precision: 0),
                        valorFranquia = c.Decimal(precision: 18, scale: 2),
                        observacao = c.String(unicode: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralEmpresa", t => t.IdEmpresa)
                .Index(t => t.IdEmpresa);
            
            CreateTable(
                "dbo.GeralEmpresa",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        documentotipodocumentocpfcnpj = c.Int(),
                        documentocpfcnpj = c.String(maxLength: 20, storeType: "nvarchar"),
                        cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        logradouro = c.String(maxLength: 255, storeType: "nvarchar"),
                        numero = c.String(maxLength: 10, storeType: "nvarchar"),
                        complemento = c.String(maxLength: 255, storeType: "nvarchar"),
                        bairro = c.String(maxLength: 255, storeType: "nvarchar"),
                        cidade = c.String(maxLength: 255, storeType: "nvarchar"),
                        uf = c.String(maxLength: 10, storeType: "nvarchar"),
                        observacao = c.String(unicode: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.GeralEmpresaContatos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        tipotelefone = c.Int(),
                        numerotelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        operadoratelefone = c.String(maxLength: 255, storeType: "nvarchar"),
                        IdEmpresa = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralEmpresa", t => t.IdEmpresa)
                .Index(t => t.IdEmpresa);
            
            CreateTable(
                "dbo.GeralEmpresasTipos",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false),
                        IdTipoEmpresa = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        TipoEmpresa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdEmpresa, t.IdTipoEmpresa })
                .ForeignKey("dbo.GeralTipoEmpresa", t => t.TipoEmpresa_Id)
                .ForeignKey("dbo.GeralEmpresa", t => t.IdEmpresa)
                .Index(t => t.IdEmpresa)
                .Index(t => t.TipoEmpresa_Id);
            
            CreateTable(
                "dbo.GeralTipoEmpresa",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        Excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TransporteVeiculos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        modelo = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        placa = c.String(nullable: false, maxLength: 12, storeType: "nvarchar"),
                        cor = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        anofrabricacao = c.Int(nullable: false),
                        anomodelo = c.Int(nullable: false),
                        chassi = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        renavam = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        numeromotor = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        observacao = c.String(nullable: false, unicode: false),
                        IdEmpresaCompra = c.Int(nullable: false),
                        IdPatrimonio = c.Int(nullable: false),
                        IdContratoSeguro = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralEmpresa", t => t.IdEmpresaCompra)
                .ForeignKey("dbo.GeralPatrimonios", t => t.IdPatrimonio)
                .ForeignKey("dbo.TransporteContratosSeguros", t => t.IdContratoSeguro)
                .Index(t => t.IdEmpresaCompra)
                .Index(t => t.IdPatrimonio)
                .Index(t => t.IdContratoSeguro);
            
            CreateTable(
                "dbo.GeralPatrimonios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numero = c.Int(nullable: false),
                        dataaquisicao = c.DateTime(precision: 0),
                        numeroprocessoaquisicao = c.String(maxLength: 255, storeType: "nvarchar"),
                        datalimitegarantia = c.DateTime(precision: 0),
                        observacao = c.String(unicode: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TransporteControleDiario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false, precision: 0),
                        numero = c.Int(nullable: false),
                        termoresponsabilidadedestino = c.String(unicode: false),
                        termoresponsabilidadefinalidade = c.String(unicode: false),
                        Observacao = c.String(unicode: false),
                        IdMotorista = c.Int(nullable: false),
                        IdFuncionarioRequisitante = c.Int(),
                        IdParlamentarRequisitante = c.Int(),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GeralFuncionarios", t => t.IdFuncionarioRequisitante)
                .ForeignKey("dbo.TransporteMotoristas", t => t.IdMotorista)
                .ForeignKey("dbo.GeralParlamentares", t => t.IdParlamentarRequisitante)
                .Index(t => t.IdMotorista)
                .Index(t => t.IdFuncionarioRequisitante)
                .Index(t => t.IdParlamentarRequisitante);
            
            CreateTable(
                "dbo.TransporteAbastecimento",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numerorequisicao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        numeronotafiscal = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        odometro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdControleDiario = c.Int(nullable: false),
                        IdTipoCombustivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TransporteTiposCombustivel", t => t.IdTipoCombustivel)
                .ForeignKey("dbo.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdControleDiario)
                .Index(t => t.IdTipoCombustivel);
            
            CreateTable(
                "dbo.TransporteControleDiarioItinerarioForaMunicipio",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        horasaida = c.Time(nullable: false, precision: 0),
                        horaretorno = c.Time(nullable: false, precision: 0),
                        destino = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        observacao = c.String(unicode: false),
                        IdControleDiario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdControleDiario);
            
            CreateTable(
                "dbo.TransporteMotoristas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        carteiramotoristanumero = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        carteiramotoristadatavalidade = c.DateTime(nullable: false, precision: 0),
                        IdFuncionario = c.Int(nullable: false),
                        IdSetor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralFuncionarios", t => t.IdFuncionario)
                .ForeignKey("dbo.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdFuncionario)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "dbo.GeralParlamentares",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        nomecompleto = c.String(maxLength: 255, storeType: "nvarchar"),
                        IdSetor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralSetores", t => t.IdSetor)
                .Index(t => t.IdSetor);
            
            CreateTable(
                "dbo.TransporteControleDiarioPedagio",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        local = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        numero = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        datahora = c.DateTime(nullable: false, precision: 0),
                        valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        observacao = c.String(unicode: false),
                        IdControleDiario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdControleDiario);
            
            CreateTable(
                "dbo.TransporteControleDiarioVeiculosUtilizados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        saida = c.DateTime(nullable: false, precision: 0),
                        retorno = c.DateTime(nullable: false, precision: 0),
                        odometroraida = c.Decimal(nullable: false, precision: 18, scale: 2),
                        odometroretorno = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdVeiculo = c.Int(nullable: false),
                        IdControleDiario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransporteVeiculos", t => t.IdVeiculo)
                .ForeignKey("dbo.TransporteControleDiario", t => t.IdControleDiario)
                .Index(t => t.IdVeiculo)
                .Index(t => t.IdControleDiario);
            
            CreateTable(
                "dbo.PortariaLocalDestino",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        atalho = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        categoria = c.Int(nullable: false),
                        sala = c.Int(nullable: false),
                        DataVencimento = c.DateTime(nullable: false, precision: 0),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.PortariaRegistroEntrada",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IdLocalDestino = c.Int(nullable: false),
                        datahoraregistro = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.PortariaLocalDestino", t => t.IdLocalDestino)
                .Index(t => t.IdLocalDestino);
            
            CreateTable(
                "dbo.TransporteOrdensServico",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numeronotafiscal = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        datanotafiscal = c.DateTime(nullable: false, precision: 0),
                        valornotafiscal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        descricaoservico = c.String(nullable: false, unicode: false),
                        odometroentrada = c.Decimal(precision: 18, scale: 2),
                        dataentrada = c.DateTime(precision: 0),
                        dataentrega = c.DateTime(precision: 0),
                        datalimitegarantia = c.DateTime(precision: 0),
                        observacao = c.String(unicode: false),
                        IdVeiculo = c.Int(nullable: false),
                        IdEmpresa = c.Int(),
                        DataCriacao = c.DateTime(nullable: false, precision: 0),
                        UsuarioCriacao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DataUltimaAlteracao = c.DateTime(nullable: false, precision: 0),
                        UsuarioUltimaAlteracao = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        excluido = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.GeralEmpresa", t => t.IdEmpresa)
                .ForeignKey("dbo.TransporteVeiculos", t => t.IdVeiculo)
                .Index(t => t.IdVeiculo)
                .Index(t => t.IdEmpresa);
            
            CreateTable(
                "dbo.TransporteOrdensServicoItens",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        descricao = c.String(unicode: false),
                        quantidade = c.Decimal(precision: 18, scale: 2),
                        unidade = c.String(unicode: false),
                        valorunitario = c.Decimal(precision: 18, scale: 2),
                        valortotal = c.Decimal(precision: 18, scale: 2),
                        observacao = c.String(unicode: false),
                        IdManutencaoOS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TransporteOrdensServico", t => t.IdManutencaoOS, cascadeDelete: true)
                .Index(t => t.IdManutencaoOS);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransporteOrdensServico", "IdVeiculo", "dbo.TransporteVeiculos");
            DropForeignKey("dbo.TransporteOrdensServicoItens", "IdManutencaoOS", "dbo.TransporteOrdensServico");
            DropForeignKey("dbo.TransporteOrdensServico", "IdEmpresa", "dbo.GeralEmpresa");
            DropForeignKey("dbo.PortariaRegistroEntrada", "IdLocalDestino", "dbo.PortariaLocalDestino");
            DropForeignKey("dbo.TransporteControleDiarioVeiculosUtilizados", "IdControleDiario", "dbo.TransporteControleDiario");
            DropForeignKey("dbo.TransporteControleDiarioVeiculosUtilizados", "IdVeiculo", "dbo.TransporteVeiculos");
            DropForeignKey("dbo.TransporteControleDiarioPedagio", "IdControleDiario", "dbo.TransporteControleDiario");
            DropForeignKey("dbo.TransporteControleDiario", "IdParlamentarRequisitante", "dbo.GeralParlamentares");
            DropForeignKey("dbo.GeralParlamentares", "IdSetor", "dbo.GeralSetores");
            DropForeignKey("dbo.TransporteControleDiario", "IdMotorista", "dbo.TransporteMotoristas");
            DropForeignKey("dbo.TransporteMotoristas", "IdSetor", "dbo.GeralSetores");
            DropForeignKey("dbo.TransporteMotoristas", "IdFuncionario", "dbo.GeralFuncionarios");
            DropForeignKey("dbo.TransporteControleDiarioItinerarioForaMunicipio", "IdControleDiario", "dbo.TransporteControleDiario");
            DropForeignKey("dbo.TransporteControleDiario", "IdFuncionarioRequisitante", "dbo.GeralFuncionarios");
            DropForeignKey("dbo.TransporteAbastecimento", "IdControleDiario", "dbo.TransporteControleDiario");
            DropForeignKey("dbo.TransporteAbastecimento", "IdTipoCombustivel", "dbo.TransporteTiposCombustivel");
            DropForeignKey("dbo.TransporteVeiculos", "IdContratoSeguro", "dbo.TransporteContratosSeguros");
            DropForeignKey("dbo.TransporteVeiculos", "IdPatrimonio", "dbo.GeralPatrimonios");
            DropForeignKey("dbo.TransporteVeiculos", "IdEmpresaCompra", "dbo.GeralEmpresa");
            DropForeignKey("dbo.TransporteContratosSeguros", "IdEmpresa", "dbo.GeralEmpresa");
            DropForeignKey("dbo.GeralEmpresasTipos", "IdEmpresa", "dbo.GeralEmpresa");
            DropForeignKey("dbo.GeralEmpresasTipos", "TipoEmpresa_Id", "dbo.GeralTipoEmpresa");
            DropForeignKey("dbo.GeralEmpresaContatos", "IdEmpresa", "dbo.GeralEmpresa");
            DropForeignKey("dbo.TransporteContaCombustivel", "IdSetor", "dbo.GeralSetores");
            DropForeignKey("dbo.TransporteContaCombustivelQuota", "IdContaCombustivel", "dbo.TransporteContaCombustivel");
            DropForeignKey("dbo.TransporteContaCombustivelQuota", "IdTipoCombustivel", "dbo.TransporteTiposCombustivel");
            DropForeignKey("dbo.TransporteContaCombustivelMovimentacao", "IdContaCombustivelQuota", "dbo.TransporteContaCombustivelQuota");
            DropForeignKey("dbo.RedeSemFioCodigoAcesso", "IdUsuarioRedeSemFio", "dbo.RedeSemFioUsuario");
            DropForeignKey("dbo.RedeSemFioUsuario", "IdFuncionarioCadastrante", "dbo.GeralFuncionarios");
            DropForeignKey("dbo.GeralGrupos", "IdCategoriaRedeSemFio", "dbo.RedeSemFioCategoriaUsuario");
            DropForeignKey("dbo.GeralUsuarioGrupo", "IdGrupo", "dbo.GeralGrupos");
            DropForeignKey("dbo.GeralUsuarioGrupo", "IdUsuario", "dbo.GeralUsuarios");
            DropForeignKey("dbo.TelefoniaCatalogoItens", "IdCatalogo", "dbo.TelefoniaCatalogo");
            DropForeignKey("dbo.GeralFuncionariosCargos", "idcargo", "dbo.GeralCargos");
            DropForeignKey("dbo.GeralFuncionarios", "IdSetor", "dbo.GeralSetores");
            DropForeignKey("dbo.GeralFuncionarioContatos", "IdFuncionario", "dbo.GeralFuncionarios");
            DropForeignKey("dbo.GeralFuncionariosCargos", "idfuncionario", "dbo.GeralFuncionarios");
            DropForeignKey("dbo.CerimonialAutoridades", "IdTratamento", "dbo.CerimonialTratamentos");
            DropForeignKey("dbo.CerimonialAutoridades", "IdOrgao", "dbo.cerimonialorgaos");
            DropForeignKey("dbo.CerimonialAutoridadeGrupos", "IdAutoridade", "dbo.CerimonialAutoridades");
            DropForeignKey("dbo.CerimonialAutoridadeGrupos", "IdGrupoCerimonial", "dbo.CerimonialGrupo");
            DropIndex("dbo.TransporteOrdensServicoItens", new[] { "IdManutencaoOS" });
            DropIndex("dbo.TransporteOrdensServico", new[] { "IdEmpresa" });
            DropIndex("dbo.TransporteOrdensServico", new[] { "IdVeiculo" });
            DropIndex("dbo.PortariaRegistroEntrada", new[] { "IdLocalDestino" });
            DropIndex("dbo.TransporteControleDiarioVeiculosUtilizados", new[] { "IdControleDiario" });
            DropIndex("dbo.TransporteControleDiarioVeiculosUtilizados", new[] { "IdVeiculo" });
            DropIndex("dbo.TransporteControleDiarioPedagio", new[] { "IdControleDiario" });
            DropIndex("dbo.GeralParlamentares", new[] { "IdSetor" });
            DropIndex("dbo.TransporteMotoristas", new[] { "IdSetor" });
            DropIndex("dbo.TransporteMotoristas", new[] { "IdFuncionario" });
            DropIndex("dbo.TransporteControleDiarioItinerarioForaMunicipio", new[] { "IdControleDiario" });
            DropIndex("dbo.TransporteAbastecimento", new[] { "IdTipoCombustivel" });
            DropIndex("dbo.TransporteAbastecimento", new[] { "IdControleDiario" });
            DropIndex("dbo.TransporteControleDiario", new[] { "IdParlamentarRequisitante" });
            DropIndex("dbo.TransporteControleDiario", new[] { "IdFuncionarioRequisitante" });
            DropIndex("dbo.TransporteControleDiario", new[] { "IdMotorista" });
            DropIndex("dbo.TransporteVeiculos", new[] { "IdContratoSeguro" });
            DropIndex("dbo.TransporteVeiculos", new[] { "IdPatrimonio" });
            DropIndex("dbo.TransporteVeiculos", new[] { "IdEmpresaCompra" });
            DropIndex("dbo.GeralEmpresasTipos", new[] { "TipoEmpresa_Id" });
            DropIndex("dbo.GeralEmpresasTipos", new[] { "IdEmpresa" });
            DropIndex("dbo.GeralEmpresaContatos", new[] { "IdEmpresa" });
            DropIndex("dbo.TransporteContratosSeguros", new[] { "IdEmpresa" });
            DropIndex("dbo.TransporteContaCombustivelMovimentacao", new[] { "IdContaCombustivelQuota" });
            DropIndex("dbo.TransporteContaCombustivelQuota", new[] { "IdContaCombustivel" });
            DropIndex("dbo.TransporteContaCombustivelQuota", new[] { "IdTipoCombustivel" });
            DropIndex("dbo.TransporteContaCombustivel", new[] { "IdSetor" });
            DropIndex("dbo.RedeSemFioUsuario", new[] { "IdFuncionarioCadastrante" });
            DropIndex("dbo.RedeSemFioCodigoAcesso", new[] { "IdUsuarioRedeSemFio" });
            DropIndex("dbo.GeralUsuarioGrupo", new[] { "IdGrupo" });
            DropIndex("dbo.GeralUsuarioGrupo", new[] { "IdUsuario" });
            DropIndex("dbo.GeralGrupos", new[] { "IdCategoriaRedeSemFio" });
            DropIndex("dbo.TelefoniaCatalogoItens", new[] { "IdCatalogo" });
            DropIndex("dbo.GeralFuncionarioContatos", new[] { "IdFuncionario" });
            DropIndex("dbo.GeralFuncionarios", new[] { "IdSetor" });
            DropIndex("dbo.GeralFuncionariosCargos", new[] { "idfuncionario" });
            DropIndex("dbo.GeralFuncionariosCargos", new[] { "idcargo" });
            DropIndex("dbo.CerimonialAutoridadeGrupos", new[] { "IdGrupoCerimonial" });
            DropIndex("dbo.CerimonialAutoridadeGrupos", new[] { "IdAutoridade" });
            DropIndex("dbo.CerimonialAutoridades", new[] { "IdOrgao" });
            DropIndex("dbo.CerimonialAutoridades", new[] { "IdTratamento" });
            DropTable("dbo.TransporteOrdensServicoItens");
            DropTable("dbo.TransporteOrdensServico");
            DropTable("dbo.PortariaRegistroEntrada");
            DropTable("dbo.PortariaLocalDestino");
            DropTable("dbo.TransporteControleDiarioVeiculosUtilizados");
            DropTable("dbo.TransporteControleDiarioPedagio");
            DropTable("dbo.GeralParlamentares");
            DropTable("dbo.TransporteMotoristas");
            DropTable("dbo.TransporteControleDiarioItinerarioForaMunicipio");
            DropTable("dbo.TransporteAbastecimento");
            DropTable("dbo.TransporteControleDiario");
            DropTable("dbo.GeralPatrimonios");
            DropTable("dbo.TransporteVeiculos");
            DropTable("dbo.GeralTipoEmpresa");
            DropTable("dbo.GeralEmpresasTipos");
            DropTable("dbo.GeralEmpresaContatos");
            DropTable("dbo.GeralEmpresa");
            DropTable("dbo.TransporteContratosSeguros");
            DropTable("dbo.TransporteTiposCombustivel");
            DropTable("dbo.TransporteContaCombustivelMovimentacao");
            DropTable("dbo.TransporteContaCombustivelQuota");
            DropTable("dbo.TransporteContaCombustivel");
            DropTable("dbo.RedeSemFioUsuario");
            DropTable("dbo.RedeSemFioCodigoAcesso");
            DropTable("dbo.GeralUsuarios");
            DropTable("dbo.GeralUsuarioGrupo");
            DropTable("dbo.GeralGrupos");
            DropTable("dbo.RedeSemFioCategoriaUsuario");
            DropTable("dbo.TelefoniaCatalogoItens");
            DropTable("dbo.TelefoniaCatalogo");
            DropTable("dbo.GeralSetores");
            DropTable("dbo.GeralFuncionarioContatos");
            DropTable("dbo.GeralFuncionarios");
            DropTable("dbo.GeralFuncionariosCargos");
            DropTable("dbo.GeralCargos");
            DropTable("dbo.CerimonialTratamentos");
            DropTable("dbo.cerimonialorgaos");
            DropTable("dbo.CerimonialGrupo");
            DropTable("dbo.CerimonialAutoridadeGrupos");
            DropTable("dbo.CerimonialAutoridades");
        }
    }
}
