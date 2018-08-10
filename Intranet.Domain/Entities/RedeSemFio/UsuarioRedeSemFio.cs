
using System;
using System.Collections.Generic;
using Intranet.Model.Entities.Geral;

namespace Intranet.Model.Entities.RedeSemFio
{
    public class UsuarioRedeSemFio : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public string documentoCpf { get; set; }
        public string documentoIdentidadeNumero { get; set; }
        public string documentoIdentidadeOrgaoEmissor { get; set; }
        public DateTime nascimento { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }

        public int idFuncionario { get; set; }
        public Funcionario funcionarioCadastrante { get; set; }

        public ICollection<CodigoAcessoRedeSemFio> codigos { get; set; }
    }
}
