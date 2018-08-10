﻿
using System.Collections.Generic;

namespace Intranet.Model.Entities.Cerimonial
{
    public class Autoridade : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public string cargo { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string observacao { get; set; }

        public int idTratamento { get; set; }
        public virtual Tratamento tratamento { get; set; }

        public int idOrgao { get; set; }
        public virtual Orgao orgao { get; set; }

        public virtual ICollection<GrupoCerimonial> grupos { get; set; }        
    }
}