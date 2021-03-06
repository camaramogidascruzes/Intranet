﻿
using Intranet.Domain.Entities.Geral;
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.RedeSemFio
{
    public class UsuarioRedeSemFio : CriacaoAlteracaoBasicEntity
    {
        public UsuarioRedeSemFio()
        {
            Documento = new InformacaoDocumento();
            Endereco = new InformacaoEndereco();
            Telefone = new InformacaoTelefone();
            FuncionarioCadastrante = new Funcionario();
        }

        public string Nome { get; set; }
        public InformacaoDocumento Documento { get; set; }
        public DateTime Nascimento { get; set; }
        public InformacaoEndereco Endereco { get; set; }
        public InformacaoTelefone Telefone { get; set; }

        public int IdFuncionarioCadastrante { get; set; }
        public Funcionario FuncionarioCadastrante { get; set; }

        public ICollection<CodigoAcessoRedeSemFio> Codigos { get; set; }
    }


}
