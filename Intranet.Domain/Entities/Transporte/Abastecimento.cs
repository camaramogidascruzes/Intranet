using System;

namespace Intranet.Model.Entities.Transporte
{
    public class Abastecimento : BasicEntity
    {

        public string numeroRequisicao { get; set; }
        public string numeroNotaFiscal { get; set; }
        public decimal quantidade { get; set; }
        public decimal odometro { get; set; }

        public int idControleDiario { get; set; }
        public ControleDiario controleDiario { get; set; }

        public int idTipoCombustivel { get; set; }
        public TipoCombustivel tipoCombustivel { get; set; }
    }
}