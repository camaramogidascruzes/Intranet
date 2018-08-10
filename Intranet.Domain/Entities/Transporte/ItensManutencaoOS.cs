namespace Intranet.Model.Entities.Transporte
{
    public class ItensManutencaoOS : BasicEntity
    {
        public string codigo { get; set; }
        public string descricao { get; set; }
        public decimal quantidade { get; set; }
        public string unidade { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorTotal { get; set; }
        public string observacao { get; set; }

        public int idManutencaoOS { get; set; }
        public ManutencaoOS manutencaoOS { get; set; }

    }
}