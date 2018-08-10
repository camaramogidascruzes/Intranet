
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Usuario : BasicEntity
    {
        public string usuario { get; set; }
        public string nome { get; set; }
        public string passwordHash { get; set; }
        public DateTime? dataUltimoLogin { get; set; }
        public DateTime? terminoBloqueio { get; set; }
        public bool bloqueado { get; set; }
        public int quantidadeFalhasAcesso { get; set; }
        public string IP { get; set; }
        public bool necessarioAlterarSenha { get; set; }

        public ICollection<Grupo> grupos { get; set; }
        
    }
}
