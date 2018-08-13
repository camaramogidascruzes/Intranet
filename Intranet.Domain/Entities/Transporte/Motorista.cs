using Intranet.Domain.Entities.Geral;
using System;


namespace Intranet.Domain.Entities.Transporte
{
    public class Motorista : CriacaoAlteracaoBasicEntity
    {
        public string CarteiraMotoristaNumero { get; set; }
        public DateTime CarteiraMotoristaDataValidade { get; set; }

        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        public int IdSetor { get; set; }
        public Setor SetorDesignado { get; set; }
    }
}
