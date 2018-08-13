


using System.Collections.Generic;
using Intranet.Model.Entities.RedeSemFio;

namespace Intranet.Domain.Entities.Geral
{
    public class Grupo : CriacaoAlteracaoBasicEntity
    {
        public Grupo()
        {
            Usuarios = new List<Usuario>();
        }

        public string Nome { get; set; }
        public bool Bloqueado { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }

        public int IdCategoriaRedeSemFio { get; set; }
        public CategoriaUsuarioRedeSemFio CategoriaRedeSemFio { get; set; }
    }
}
