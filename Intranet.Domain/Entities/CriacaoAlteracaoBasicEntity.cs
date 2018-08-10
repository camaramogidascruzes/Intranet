
namespace Intranet.Domain.Entities
{
    public class CriacaoAlteracaoBasicEntity : BasicEntity
    {
        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
        public DadosAlteracaoRegistro DadosAlteracaoRegistro { get; set; }
        public bool Excluido { get; set; }
    }
}
