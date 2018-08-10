
using System;
using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.Transporte
{
    public class Veiculo : CriacaoAlteracaoBasicEntity
    {
        public string modelo { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }
        public int anoFabricao { get; set; }
        public int anoModelo { get; set; }
        public string chassi { get; set; }
        public string renavam { get; set; }
        public string numeroMotor { get; set; }
        public string observacao { get; set; }

        public int idEmpresaCompra { get; set; }
        public virtual Empresa empresaCompra { get; set; }

        public int numeroPatrimonio { get; set; }
        public virtual Patrimonio patrimonio { get; set; }

        public int idContratoSeguro { get; set; }
        public ContratoSeguro seguro { get; set; }
    }
}