


using System.Collections.Generic;
using Intranet.Domain.Entities.RedeSemFio;

namespace Intranet.Domain.Entities.Geral
{
    public class Grupo : CriacaoAlteracaoBasicEntity
    {
        public Grupo()
        {
            Usuarios = new List<UsuarioGrupo>();
            CategoriaRedeSemFio = new CategoriaUsuarioRedeSemFio();
        }

        public string Nome { get; set; }
        public bool Bloqueado { get; set; }

        public ICollection<UsuarioGrupo> Usuarios { get; set; }

        public int IdCategoriaRedeSemFio { get; set; }
        public CategoriaUsuarioRedeSemFio CategoriaRedeSemFio { get; set; }
    }
}
