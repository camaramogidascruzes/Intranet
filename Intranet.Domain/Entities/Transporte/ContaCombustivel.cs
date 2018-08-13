

using Intranet.Domain.Entities.Geral;
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Transporte
{
    public class ContaCombustivel : CriacaoAlteracaoBasicEntity
    {
        public ContaCombustivel()
        {
            Quota = new List<ContaCombustivelQuota>();
        }

        public string Nome { get; set; }

        public int IdSetor { get; set; }
        public Setor Setor { get; set; }

        public ICollection<ContaCombustivelQuota> Quota { get; set; }

    }

    public class ContaCombustivelQuota : BasicEntity
    {
        public ContaCombustivelQuota()
        {
            Movimentacao = new List<ContaCombustivelMovimentacao>();
        }

        public decimal Quantidade { get; set; }
        public decimal Saldo { get; set; }

        public int IdTipoCombustivel { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }

        public int IdContaCombustivel { get; set; }
        public ContaCombustivel ContaCombustivel { get; set; }

        public ICollection<ContaCombustivelMovimentacao> Movimentacao { get; set; }
    }

    public class ContaCombustivelMovimentacao : BasicEntity
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        public int IdContaCombustivelQuota { get; set; }
        public ContaCombustivelQuota Quota { get; set; }
    }

}
