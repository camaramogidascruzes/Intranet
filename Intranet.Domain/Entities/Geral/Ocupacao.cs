namespace Intranet.Domain.Entities.Geral
{
    public class Ocupacao
    {
        public int idfuncionario { get; set; }
        public Funcionario funcionario { get; set; }

        public int idcargo { get; set; }
        public Cargo cargo { get; set; }

        public int rgf { get; set; }
        public DadosCriacaoRegistro dadosCriacaoRegistro { get; set; }
        public DadosAlteracaoRegistro dadosAlteracaoRegistro { get; set; }
    }
}
