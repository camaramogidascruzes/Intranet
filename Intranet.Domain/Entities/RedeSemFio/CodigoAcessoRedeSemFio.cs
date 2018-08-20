using System;

namespace Intranet.Domain.Entities.RedeSemFio
{
    public class CodigoAcessoRedeSemFio : BasicEntity
    {
        public CodigoAcessoRedeSemFio()
        {
            Usuario = new UsuarioRedeSemFio();
            DataEmissao = DateTime.MinValue;
        }

        public string Codigo { get; set; }
        public DateTime DataEmissao { get; set; }
        public int Validade { get; set; }
        public int Quota { get; set; }

        public int IdUsuarioRedeSemFio { get; set; }
        public UsuarioRedeSemFio Usuario { get; set; }

    }
}
