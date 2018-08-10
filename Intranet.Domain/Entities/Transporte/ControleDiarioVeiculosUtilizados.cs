
using System;
using System.Security.AccessControl;

namespace Intranet.Model.Entities.Transporte
{
    public class ControleDiarioVeiculosUtilizados : BasicEntity
    {
        public DateTime saida { get; set; }
        public DateTime retorno { get; set; }
        public decimal odometroSaida { get; set; }
        public decimal odometroRetorno { get; set; }

        public int idVeiculo { get; set; }
        public Veiculo veiculo { get; set; }

        public int idControleDiario { get; set; }
        public ControleDiario controleDiario { get; set; }
    }
}
