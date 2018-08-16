
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Usuario : BasicEntity
    {
        public Usuario()
        {
            DataUltimoLogin = DateTime.MinValue;
            TerminoBloqueio = DateTime.MinValue;
            Grupos = new List<UsuarioGrupo>();
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

        public ICollection<UsuarioGrupo> Grupos { get; set; }
        
    }


    public class UsuarioGrupo
    {
        public UsuarioGrupo()
        {
            Usuario = new Usuario();
            Grupo = new Grupo();
            DadosCriacaoRegistro = new DadosCriacaoRegistro();
        }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public int IdGrupo { get; set; }
        public Grupo Grupo { get; set; }

        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
    }
}
