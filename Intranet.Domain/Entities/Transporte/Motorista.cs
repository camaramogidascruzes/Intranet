using System;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.Transporte
{
    public class Motorista : CriacaoAlteracaoBasicEntity
    {
        public string carteiraMotoristaNumero { get; set; }
        public DateTime carteiraMotoristaDataValidade { get; set; }

        public int idFuncionario { get; set; }
        public Funcionario funcionario { get; set; }
        public int idSetor { get; set; }
        public Setor setorDesignado { get; set; }
    }
}
