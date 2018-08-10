


using System.Collections.Generic;
using Intranet.Model.Entities.RedeSemFio;

namespace Intranet.Domain.Entities.Geral
{
    public class Grupo : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public bool bloqueado { get; set; }

        public ICollection<Usuario> usuarios { get; set; }
        public int idCategoriaRedeSemFio { get; set; }
        public CategoriaUsuarioRedeSemFio categoriaRedeSemFio { get; set; }
    }
}
