

using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Setor : CriacaoAlteracaoBasicEntity
    {
        public Setor()
        {
            Funcionarios = new List<Funcionario>();
        }

        public string Nome { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
