

using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.Transporte
{
    public class ContaCombustivel : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }

        public int idSetor { get; set; }
        public Setor setor { get; set; }

        public ICollection<ContaCombustivelQuota> quota { get; set; }

    }
}
