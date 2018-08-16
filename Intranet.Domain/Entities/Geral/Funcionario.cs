using System;
using System.Collections.Generic;
using Intranet.Domain.Entities.Enum;

namespace Intranet.Domain.Entities.Geral
{
    public class Funcionario : CriacaoAlteracaoBasicEntity
    {
        public Funcionario()
        {
            Documento = new InformacaoDocumento();
            Nascimento = DateTime.MinValue;
            Setor = new Setor();
            Cargos = new List<Ocupacao>();
            Contatos = new List<FuncionarioContato>();

        }

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
        public FuncionarioContato()
        {
            Telefone = new InformacaoTelefone();
            Funcionario = new Funcionario();
        }

        public InformacaoTelefone Telefone { get; set; }

        public int IdFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
    }

    public class Ocupacao
    {
        public Ocupacao()
        {
            Funcionario = new Funcionario();
            Cargo = new Cargo();
            DadosAlteracaoRegistro = new DadosAlteracaoRegistro();
            DadosAlteracaoRegistro = new DadosAlteracaoRegistro();
        }

        public int Idfuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        public int Idcargo { get; set; }
        public Cargo Cargo { get; set; }

        public int Rgf { get; set; }

        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
        public DadosAlteracaoRegistro DadosAlteracaoRegistro { get; set; }
    }
}
