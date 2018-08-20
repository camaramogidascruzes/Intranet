
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Portaria
{
    public enum CategoriaLocalDestino
    {
        GABINETE = 1,
        ADMINISTRATIVO = 2
    }

    public class LocalDestino: CriacaoAlteracaoBasicEntity
    {
        public LocalDestino()
        {
            Entradas = new List<RegistroEntrada>();
            DataVencimento = DateTime.MinValue;
        }

        public string Nome { get; set; }
        public string Atalho { get; set; }
        public CategoriaLocalDestino Categoria { get; set; }
        public int? Sala { get; set; }
        public DateTime DataVencimento { get; set; }

        public ICollection<RegistroEntrada> Entradas { get; set; }
    }
}
