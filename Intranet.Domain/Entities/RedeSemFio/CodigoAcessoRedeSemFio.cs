using System;

namespace Intranet.Model.Entities.RedeSemFio
{
    public class CodigoAcessoRedeSemFio : BasicEntity
    {
        public string codigo { get; set; }
        public DateTime dataEmissao { get; set; }
        public int validade { get; set; }
        public int quota { get; set; }

        public int idUsuarioRedeSemFio { get; set; }
        public virtual UsuarioRedeSemFio usuario { get; set; }

    }
}
