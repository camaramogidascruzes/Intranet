using System.Collections.Generic;

namespace Intranet.Model.Entities.Transporte
{
    public class ContaCombustivelQuota : BasicEntity
    {
        public decimal quantidade { get; set; }
        public decimal saldo { get; set; }

        public int idTipoCombustivel { get; set; }
        public TipoCombustivel tipo { get; set; }

        public int idContaCombustivel { get; set; }
        public ContaCombustivel contaCombustivel { get; set; }

        public ICollection<ContaCombustivelMovimentacao> movimentacao { get; set; }
    }
}