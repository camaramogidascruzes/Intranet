
using System;

namespace Intranet.Domain.Entities
{
    public class CriacaoAlteracaoBasicEntity : BasicEntity
    {
        public CriacaoAlteracaoBasicEntity()
        {
            DadosCriacaoRegistro = new DadosCriacaoRegistro();
            DadosAlteracaoRegistro = new DadosAlteracaoRegistro();
            Excluido = false;
        }
        
        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
        public DadosAlteracaoRegistro DadosAlteracaoRegistro { get; set; }
        public bool Excluido { get; set; }
    }
}
