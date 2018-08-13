
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Usuario : BasicEntity
    {
        public Usuario()
        {
            Grupos = new List<Grupo>();
        }

        public string Login { get; set; }
        public string Nome { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? DataUltimoLogin { get; set; }
        public DateTime? TerminoBloqueio { get; set; }
        public bool Bloqueado { get; set; }
        public int QuantidadeFalhasAcesso { get; set; }
        public string Ip { get; set; }
        public bool NecessarioAlterarSenha { get; set; }

        public ICollection<Grupo> Grupos { get; set; }
        
    }
}
