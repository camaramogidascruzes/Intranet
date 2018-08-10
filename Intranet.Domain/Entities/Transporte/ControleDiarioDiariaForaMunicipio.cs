using System;
using System.Security.AccessControl;

namespace Intranet.Model.Entities.Transporte
{
    public class ControleDiarioDiariaForaMunicipio
    {
        public TimeSpan horaSaida { get; set; }
        public TimeSpan horaRetorno { get; set; }
        public string destino { get; set; }
        public string observacao { get; set; }
        public TimeSpan tempoTotal { get; set; }
        public int referenciaValor { get; set; }
        public decimal valor { get; set; }

        public ControleDiario controleDiario { get; set; }
    }
}
