using System;
using System.Collections.Generic;
using Intranet.Domain.Entities.Enum;

namespace Intranet.Domain.Entities.Geral
{
    public class Funcionario : CriacaoAlteracaoBasicEntity
    {
        public string Nome { get; set; }
        public InformacaoDocumento Documento { get; set; }
        public DateTime? Nascimento { get; set; }
        public int? IdSetor { get; set; }
        public Setor Setor { get; set; }

        public ICollection<Ocupacao> Cargos { get; set; }
        public ICollection<FuncionarioContato> Contatos { get; set; }
    }

    public class FuncionarioContato : CriacaoAlteracaoBasicEntity
    {
        public InformacaoTelefone Telefone { get; set; }

        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
    }

    public class Ocupacao
    {
        public int Idfuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        public int Idcargo { get; set; }
        public Cargo Cargo { get; set; }

        public int Rgf { get; set; }

        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
        public DadosAlteracaoRegistro DadosAlteracaoRegistro { get; set; }
    }
}
