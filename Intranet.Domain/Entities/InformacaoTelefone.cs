
using Intranet.Domain.Entities.Enum;

namespace Intranet.Domain.Entities
{
    public class InformacaoTelefone
    {
        public InformacaoTelefone()
        {
            TipoTelefone = TipoTelefone.FIXO;
        }

        public TipoTelefone TipoTelefone { get; set; }
        public string Numero { get; set; }
        public string Operadora { get; set; }
    }
}
