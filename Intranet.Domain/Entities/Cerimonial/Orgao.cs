using System.Collections.Generic;

namespace Intranet.Model.Entities.Cerimonial
{
    public class Orgao : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string observacao { get; set; }

        public ICollection<Autoridade> autoridades { get; set; }
    }
}