using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Funcionario : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public string documentoCpf { get; set; }
        public string documentoIdentidadeNumero { get; set; }
        public string documentoIdentidadeOrgaoEmissor { get; set; }
        public DateTime nascimento { get; set; }
        public int? idSetor { get; set; }
        public Setor setor { get; set; }

        public ICollection<Ocupacao> cargos { get; set; }
        public ICollection<FuncionarioContato> contatos { get; set; }
    }
}
