using System;

namespace Intranet.Model.Entities.Transporte
{
    public class ContaCombustivelMovimentacao : BasicEntity
    {
        public DateTime data { get; set; }
        public decimal valor { get; set; }

        public int idContaCombustivelQuota { get; set; }
        public ContaCombustivelQuota quota { get; set; }
    }
}
