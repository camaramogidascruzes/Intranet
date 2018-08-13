using System;

namespace Intranet.Domain.Entities.Geral
{
    public class Patrimonio : CriacaoAlteracaoBasicEntity
    {
        public int Numero { get; set; }
        public DateTime? DataAquisicao { get; set; }
        public string NumeroProcessoAquisicao { get; set; }
        public DateTime? DataLimiteGarantia { get; set; }
        public string Observacao { get; set; }
    }
}
