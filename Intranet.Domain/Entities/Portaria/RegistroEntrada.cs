using System;

namespace Intranet.Model.Entities.Portaria
{
    public class RegistroEntrada : BasicEntity
    {
        public int idLocalDestino { get; set; }
        public virtual LocalDestino localDestino { get; set; }

        public DateTime dataHoraRegistro { get; set; }
    }
}
