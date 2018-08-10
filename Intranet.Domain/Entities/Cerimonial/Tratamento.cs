using System.Collections.Generic;

namespace Intranet.Model.Entities.Cerimonial
{
    public class Tratamento : CriacaoAlteracaoBasicEntity
    {
        public string abreviacao { get; set; }
        public string extenso { get; set; }

        public ICollection<Autoridade> autoridades { get; set; }
    }
}