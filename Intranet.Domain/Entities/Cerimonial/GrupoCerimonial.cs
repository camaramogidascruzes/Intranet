using System.Collections.Generic;

namespace Intranet.Domain.Entities.Cerimonial
{
    public class GrupoCerimonial : CriacaoAlteracaoBasicEntity
    {
        public GrupoCerimonial()
        {
            Autoridades = new List<AutoridadeGrupoCerimonial>();
        }

        public string Nome { get; set; }

        public ICollection<AutoridadeGrupoCerimonial> Autoridades { get; set; }
    }
}
