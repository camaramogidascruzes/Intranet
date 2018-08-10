
namespace Intranet.Domain.Entities.Geral
{
    public class FuncionarioContato : CriacaoAlteracaoBasicEntity
    {
        public string telefone { get; set; }
        public TipoTelefone tipoTelefone { get; set; }
        public string operadora { get; set; }

        public int idFuncionario { get; set; }
        public Funcionario funcionario { get; set; }
    }
}
