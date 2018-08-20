using System;
using System.Collections.Generic;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.Entities.Transporte
{
    public class ManutencaoOS : CriacaoAlteracaoBasicEntity
    {
        public ManutencaoOS()
        {
            DataNF = DateTime.MinValue;
            DataEntrada = DateTime.MinValue;
            DataEntrega = DateTime.MinValue;
            DataLimiteGarantia = DateTime.MinValue;
            Itens = new List<ItensManutencaoOS>();
        }


        public string NumeroNF { get; set; }
        public DateTime DataNF { get; set; }
        public decimal ValorNF { get; set; }
        public string DescricaoServico { get; set; }
        public decimal OdometroEntrada { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataLimiteGarantia { get; set; }
        public string Observacao { get; set; }

        public int IdVeiculo { get; set; }
        public Veiculo Veiculo { get; set; }

        public int? IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

        public ICollection<ItensManutencaoOS> Itens { get; set; }
    }

    public class ItensManutencaoOS : BasicEntity
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public string Observacao { get; set; }

        public int IdManutencaoOS { get; set; }
        public ManutencaoOS ManutencaoOS { get; set; }

    }
}
