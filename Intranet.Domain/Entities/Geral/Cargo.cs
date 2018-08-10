using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Cargo : CriacaoAlteracaoBasicEntity
    {
        public Cargo()
        {
            funcionarios = new List<Ocupacao>();
        }

        public string nome { get; set; }

        public ICollection<Ocupacao> funcionarios { get; set; }
    }
}
