using System;
using System.Collections.Generic;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.Entities.Transporte
{
    public class ContratoSeguro : CriacaoAlteracaoBasicEntity
    {
        public ContratoSeguro()
        {
            Empresa = new Empresa();
            DataInicio = DateTime.MinValue;
            DataTermino = DateTime.MinValue;
            VeiculosCobertos = new List<Veiculo>();
        }


        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

        public string NumeroApolice { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public decimal ValorFranquia { get; set; }
        public string Observacao { get; set; }

        public ICollection<Veiculo> VeiculosCobertos { get; set; }
    }
}
