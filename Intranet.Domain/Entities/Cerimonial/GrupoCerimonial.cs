using System.Collections.Generic;

namespace Intranet.Model.Entities.Cerimonial
{
    public class GrupoCerimonial : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }

        public virtual ICollection<Autoridade> autoridades { get; set; }
    }
}
