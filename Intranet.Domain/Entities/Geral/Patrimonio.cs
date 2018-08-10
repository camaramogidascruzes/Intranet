
using System;

namespace Intranet.Domain.Entities.Geral
{
    public class Patrimonio : CriacaoAlteracaoBasicEntity
    {
        public int numero { get; set; }
        public DateTime dataAquisicao { get; set; }
        public string numeroProcessoAquisicao { get; set; }
        public DateTime dataLimiteGarantia { get; set; }
        public string observacao { get; set; }
    }
}
