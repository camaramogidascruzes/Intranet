using System;

namespace Intranet.Model.Entities.Transporte
{
    public class ControleDiarioPedagio : BasicEntity
    {
        public string local { get; set; }
        public string numero { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
        public string observacao { get; set; }

        public int idControleDiario { get; set; }
        public ControleDiario controleDiario { get; set; }
    }
}
