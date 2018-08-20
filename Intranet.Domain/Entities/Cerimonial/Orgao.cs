using System.Collections.Generic;

namespace Intranet.Domain.Entities.Cerimonial
{
    public class Orgao : CriacaoAlteracaoBasicEntity
    {
        public Orgao()
        {
            Autoridades = new List<Autoridade>();
            Endereco = new InformacaoEndereco();
        }

        public string Nome { get; set; }
        public InformacaoEndereco Endereco { get; set; }
        public string Observacao { get; set; }

        public ICollection<Autoridade> Autoridades { get; set; }
    }
}