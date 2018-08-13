

using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.Entities.Transporte
{
    public class Veiculo : CriacaoAlteracaoBasicEntity
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int AnoFabricao { get; set; }
        public int AnoModelo { get; set; }
        public string Chassi { get; set; }
        public string Renavam { get; set; }
        public string NumeroMotor { get; set; }
        public string Observacao { get; set; }

        public int IdEmpresaCompra { get; set; }
        public virtual Empresa EmpresaCompra { get; set; }

        public int NumeroPatrimonio { get; set; }
        public virtual Patrimonio Patrimonio { get; set; }

        public int IdContratoSeguro { get; set; }
        public ContratoSeguro Seguro { get; set; }
    }
}