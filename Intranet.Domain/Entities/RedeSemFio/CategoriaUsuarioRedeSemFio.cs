
using System.Collections.Generic;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.Entities.RedeSemFio
{
    public class CategoriaUsuarioRedeSemFio : CriacaoAlteracaoBasicEntity
    {
        public CategoriaUsuarioRedeSemFio()
        {
            Grupos = new List<Grupo>();
        }

        public string Nome { get; set; }
        public int Validade { get; set; }
        public int Quota { get; set; }

        public ICollection<Grupo> Grupos { get; set; }
    }

}
