using System;
using System.Collections.Generic;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.Entities.Transporte
{
    public class ControleDiario : CriacaoAlteracaoBasicEntity
    {
        public ControleDiario()
        {
            VeiculosUtilizados = new List<ControleDiarioVeiculosUtilizados>();
            Pedagios = new List<ControleDiarioPedagio>();
            Abastecimentos = new List<Abastecimento>();
            ItinerariosForaMunicipio = new List<ControleDiarioItinerarioForaMunicipio>();
        }


        public DateTime Data { get; set; }
        public int Numero { get; set; }
        public string TermoResponsabilidadeDestino { get; set; }
        public string TermoResponsabilidadeFinalidade { get; set; }
        public string Observacao { get; set; }

        public int IdMotorista { get; set; }
        public Motorista Motorista { get; set; }
        public int IdFuncionarioRequisitante { get; set; }
        public Funcionario FuncionarioRequisitante { get; set; }
        public int IdParlamentarRequisitante { get; set; }
        public Parlamentar ParlamentarRequisitante { get; set; }


        public ICollection<ControleDiarioVeiculosUtilizados> VeiculosUtilizados { get; set; }
        public ICollection<ControleDiarioPedagio> Pedagios { get; set; }
        public ICollection<Abastecimento> Abastecimentos { get; set; }
        public ICollection<ControleDiarioItinerarioForaMunicipio> ItinerariosForaMunicipio { get; set; }
    }

    public class ControleDiarioVeiculosUtilizados : BasicEntity
    {
        public DateTime Saida { get; set; }
        public DateTime Retorno { get; set; }
        public decimal OdometroSaida { get; set; }
        public decimal OdometroRetorno { get; set; }

        public int IdVeiculo { get; set; }
        public Veiculo Veiculo { get; set; }

        public int IdControleDiario { get; set; }
        public ControleDiario ControleDiario { get; set; }
    }

    public class ControleDiarioPedagio : BasicEntity
    {
        public string Local { get; set; }
        public string Numero { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }

        public int IdControleDiario { get; set; }
        public ControleDiario ControleDiario { get; set; }
    }

    public class Abastecimento : BasicEntity
    {
        public string NumeroRequisicao { get; set; }
        public string NumeroNotaFiscal { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Odometro { get; set; }

        public int IdControleDiario { get; set; }
        public ControleDiario ControleDiario { get; set; }

        public int IdTipoCombustivel { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
    }

    public class ControleDiarioItinerarioForaMunicipio : BasicEntity
    {

        public TimeSpan HoraSaida { get; set; }
        public TimeSpan HoraRetorno { get; set; }
        public string Destino { get; set; }
        public string Observacao { get; set; }

        public int IdControleDiario { get; set; }
        public ControleDiario ControleDiario { get; set; }

    }

    public class ControleDiarioDiariaForaMunicipio
    {
        public TimeSpan HoraSaida { get; set; }
        public TimeSpan HoraRetorno { get; set; }
        public string Destino { get; set; }
        public string Observacao { get; set; }
        public TimeSpan TempoTotal { get; set; }
        public int ReferenciaValor { get; set; }
        public decimal Valor { get; set; }

        public ControleDiario ControleDiario { get; set; }
    }
}
