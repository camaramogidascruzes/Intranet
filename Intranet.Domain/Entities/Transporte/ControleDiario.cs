

using System;
using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.Transporte
{
    public class ControleDiario : CriacaoAlteracaoBasicEntity
    {
        public DateTime data { get; set; }
        public int numero { get; set; }
        public string termoResponsabilidadeDestino { get; set; }
        public string termoResponsabilidadeFinalidade { get; set; }
        public string observacao { get; set; }

        public int idMotorista { get; set; }
        public Motorista motorista { get; set; }
        public int idFuncionarioRequisitante { get; set; }
        public Funcionario requisitanteFuncionario { get; set; }
        public int idParlamentarRequisitante { get; set; }
        public Parlamentar requisitanteParlamentar { get; set; }


        public ICollection<ControleDiarioVeiculosUtilizados> veiculosUtilizados { get; set; }
        public ICollection<ControleDiarioPedagio> pedagios { get; set; }
        public ICollection<Abastecimento> abastecimentos { get; set; }
        public ICollection<ControleDiarioItinerarioForaMunicipio> itinerariosForaMunicipio { get; set; }
    }
}
