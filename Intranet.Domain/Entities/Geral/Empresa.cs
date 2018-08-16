
using System.Collections.Generic;
using Intranet.Domain.Entities.Enum;

namespace Intranet.Domain.Entities.Geral
{
    public class Empresa : CriacaoAlteracaoBasicEntity
    {
        public Empresa()
        {
            DocumentoCpfCnpjTipo = TipoDocumento.CPF;
            Endereco = new InformacaoEndereco();
            Contatos = new List<EmpresaContato>();
            Tipos = new List<EmpresasTipos>();
        }

        public string Nome { get; set; }
        public TipoDocumento DocumentoCpfCnpjTipo { get; set; }
        public string DocumentoCpfCnpj { get; set; }
        public InformacaoEndereco Endereco { get; set; }
        public string Observacao { get; set; }

        public ICollection<EmpresaContato> Contatos { get; set; }
        public ICollection<EmpresasTipos> Tipos { get; set; }
    }

    public class EmpresaContato : CriacaoAlteracaoBasicEntity
    {
        public EmpresaContato()
        {
            Telefone = new InformacaoTelefone();
            Empresa = new Empresa();
        }

        public string Nome { get; set; }
        public InformacaoTelefone Telefone { get; set; }

        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
    }

    public class EmpresasTipos
    {
        public EmpresasTipos()
        {
            Empresa = new Empresa();
            TipoEmpresa = new TipoEmpresa();
            DadosCriacaoRegistro = new DadosCriacaoRegistro();
        }

        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }

        public int IdTipoEmpresa { get; set; }
        public TipoEmpresa TipoEmpresa { get; set; }

        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
    }

    public class TipoEmpresa : CriacaoAlteracaoBasicEntity
    {
        public TipoEmpresa()
        {
            Empresas = new List<EmpresasTipos>();
        }

        public string Nome { get; set; }
        
        public ICollection<EmpresasTipos> Empresas { get; set; }
    }


}