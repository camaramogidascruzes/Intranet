using System;

namespace Intranet.Domain.Entities.Portaria
{
    public class RegistroEntrada : BasicEntity
    {
        public int IdLocalDestino { get; set; }
        public LocalDestino LocalDestino { get; set; }

        public DateTime DataHoraRegistro { get; set; }
    }
}
