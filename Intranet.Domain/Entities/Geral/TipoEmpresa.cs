
using System;
using System.Collections.Generic;

namespace Intranet.Domain.Entities.Geral
{
    public class TipoEmpresa : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }

        public int idEmpresa { get; set; }
        public ICollection<EmpresasTipos> empresas { get; set; }
    }
}
