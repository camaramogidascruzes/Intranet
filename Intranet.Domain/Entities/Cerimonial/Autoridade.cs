
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Cerimonial
{
    public class Autoridade : CriacaoAlteracaoBasicEntity
    {
        public Autoridade()
        {
            Grupos = new List<AutoridadeGrupoCerimonial>();
        }

        public string Nome { get; set; }
        public InformacaoEndereco Endereco { get; set; }
        public string Cargo { get; set; }
        public string Observacao { get; set; }

        public int IdTratamento { get; set; }
        public Tratamento Tratamento { get; set; }

        public int IdOrgao { get; set; }
        public Orgao Orgao { get; set; }

        public ICollection<AutoridadeGrupoCerimonial> Grupos { get; set; }        
    }
}