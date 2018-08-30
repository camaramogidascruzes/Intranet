using Intranet.Domain.Entities;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Intranet.Data.Context.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Intranet.Data.Context.MigrationContext context)
        {
            var usuariopadrao = "fernando.komura";
            var dadoscriacao = new DadosCriacaoRegistro() {DataCriacao = DateTime.Now, UsuarioCriacao = usuariopadrao};
            var dadosalteracao = new DadosAlteracaoRegistro() { DataUltimaAlteracao = DateTime.Now, UsuarioUltimaAlteracao = usuariopadrao };


            /* Setores */
            var nomesetorTI = "Divisão de T.I";
            var nomesetorSecAdm = "Secretaria Geral Administrativa";
            var nomesetorProtocolo = "Protocolo";
            var nomesetorSecLeg = "Secretaria Geral Legislativa";

            context.Setores.AddOrUpdate(s => s.Nome, new Setor()
            {
                Nome = nomesetorTI,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            context.Setores.AddOrUpdate(s => s.Nome, new Setor()
            {
                Nome = nomesetorSecAdm,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            context.Setores.AddOrUpdate(s => s.Nome, new Setor()
            {
                Nome = nomesetorProtocolo,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            context.Setores.AddOrUpdate(s => s.Nome, new Setor()
            {
                Nome = nomesetorSecLeg,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            /* Cargos */

            var nomecargoChefeDivisão = "Chefe de Divisão";
            var nomecargoDiretorDepartamento = "Diretor de Departamento";
            var nomecargoChefeAssLegislativa = "Chefe de Assessoria Legislativa";
            var nomecargoAssPolLeg = "Assessor para Assuntos Politico-Legilsativos";

            context.Cargos.AddOrUpdate(c => c.Nome, new Cargo()
            {
                Nome = nomecargoChefeDivisão,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            context.Cargos.AddOrUpdate(c => c.Nome, new Cargo()
            {
                Nome = nomecargoDiretorDepartamento,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            context.Cargos.AddOrUpdate(c => c.Nome, new Cargo()
            {
                Nome = nomecargoChefeAssLegislativa,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

            context.Cargos.AddOrUpdate(c => c.Nome, new Cargo()
            {
                Nome = nomecargoAssPolLeg,
                DadosCriacaoRegistro = dadoscriacao,
                DadosAlteracaoRegistro = dadosalteracao
            });

        }
    }
}
