﻿using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class Cargo : CriacaoAlteracaoBasicEntity
    {
        public Cargo()
        {
            Funcionarios = new List<Ocupacao>();
        }

        public string Nome { get; set; }

        public ICollection<Ocupacao> Funcionarios { get; set; }
    }
}
