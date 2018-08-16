using System;

namespace Intranet.Domain.Entities
{
    public class DadosCriacaoRegistro
    {
        public DadosCriacaoRegistro()
        {
            DataCriacao = DateTime.Now;
        }

        public DateTime DataCriacao { get; set; }
        public string UsuarioCriacao { get; set; }

    }
}
