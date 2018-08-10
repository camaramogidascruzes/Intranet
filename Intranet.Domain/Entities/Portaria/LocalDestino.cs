
using System;
using System.Collections.Generic;

namespace Intranet.Model.Entities.Portaria
{
    public class LocalDestino: CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public string atalho { get; set; }
        public CategoriaLocalDestino categoria { get; set; }
        public int? sala { get; set; }
        public DateTime dataVencimento { get; set; }

        public virtual ICollection<RegistroEntrada> entradas { get; set; }
    }
}
