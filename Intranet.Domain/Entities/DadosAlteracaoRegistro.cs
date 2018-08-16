using System;

namespace Intranet.Domain.Entities
{
    public class DadosAlteracaoRegistro
    {
        public DadosAlteracaoRegistro()
        {
            DataUltimaAlteracao = DateTime.Now;
        }

        public DateTime DataUltimaAlteracao { get; set; }
        public string UsuarioUltimaAlteracao { get; set; }
    }
}
