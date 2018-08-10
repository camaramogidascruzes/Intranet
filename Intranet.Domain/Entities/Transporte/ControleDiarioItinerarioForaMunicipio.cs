using System;

namespace Intranet.Model.Entities.Transporte
{
    public class ControleDiarioItinerarioForaMunicipio : BasicEntity
    {
        
        public TimeSpan horaSaida { get; set; }
        public TimeSpan horaRetorno { get; set; }
        public string destino { get; set; }
        public string observacao { get; set; }

        public int idControleDiario { get; set; }
        public ControleDiario controleDiario { get; set; }

    }
}