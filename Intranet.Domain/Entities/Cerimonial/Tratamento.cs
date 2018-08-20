using System.Collections.Generic;

namespace Intranet.Domain.Entities.Cerimonial
{
    public class Tratamento : CriacaoAlteracaoBasicEntity
    {
        public Tratamento()
        {
            Autoridades = new List<Autoridade>();
        }

        public string Abreviacao { get; set; }
        public string Extenso { get; set; }

        public ICollection<Autoridade> Autoridades { get; set; }
    }
}