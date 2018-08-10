
using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.RedeSemFio
{
    public class CategoriaUsuarioRedeSemFio : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public int validade { get; set; }
        public int quota { get; set; }

        public ICollection<Grupo> grupos { get; set; }
    }
}
