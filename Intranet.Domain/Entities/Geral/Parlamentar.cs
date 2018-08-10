
namespace Intranet.Domain.Entities.Geral
{
    public class Parlamentar : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public string nomeCompleto { get; set; }
        public int idSetor { get; set; }
        public Setor setor { get; set; }
    }
}
