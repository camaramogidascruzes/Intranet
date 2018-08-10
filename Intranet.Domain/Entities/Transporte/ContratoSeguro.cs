using System;
using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.Transporte
{
    public class ContratoSeguro : CriacaoAlteracaoBasicEntity
    {
        public int idEmpresa { get; set; }
        public Empresa empresa { get; set; }
        public string numeroApolice { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataTermino { get; set; }
        public Decimal valorFranquia { get; set; }
        public string observacao { get; set; }

        public ICollection<Veiculo> veiculosCobertos { get; set; }
    }
}
