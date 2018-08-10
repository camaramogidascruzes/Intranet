using System;
using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.Transporte
{
    public class ManutencaoOS : CriacaoAlteracaoBasicEntity
    {
        public string numeroNF { get; set; }
        public DateTime dataNF { get; set; }
        public decimal valorNF { get; set; }
        public string descricaoServico { get; set; }
        public decimal odometroEntrada { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataEntrega { get; set; }
        public DateTime dataLimiteGarantia { get; set; }
        public string observacao { get; set; }

        public int idVeiculo { get; set; }
        public Veiculo veiculo { get; set; }

        public int idEmpresa { get; set; }
        public Empresa empresa { get; set; }

        public ICollection<ItensManutencaoOS> itens { get; set; }
    }
}
