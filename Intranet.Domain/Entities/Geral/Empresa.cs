
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Empresa : CriacaoAlteracaoBasicEntity
    {
        public Empresa()
        {
            contatos = new List<EmpresaContato>();
            tipos = new List<EmpresasTipos>();
        }


        public string nome { get; set; }
        public TipoDocumento documentoCpfCnpjTipo { get; set; }
        public string documentoCpfCnpj { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string observacao { get; set; }

        public ICollection<EmpresaContato> contatos { get; set; }
        public ICollection<EmpresasTipos> tipos { get; set; }
    }
}