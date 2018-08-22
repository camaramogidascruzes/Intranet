using System.Collections.Generic;
using Intranet.Domain.Entities.Enum;

namespace Intranet.Domain.Entities.Telefonia
{
    public class CatalogoTelefonico //: CriacaoAlteracaoBasicEntity
    {
        public CatalogoTelefonico()
        {
            Itens = new List<ItensCatalogoTelefonico>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public PermissaoCatalogoTelefonicoEnum PermissaoVisualizacao { get; set; }

        public ICollection<ItensCatalogoTelefonico> Itens { get; set; }

    }

    public class ItensCatalogoTelefonico //: BasicEntity
    {
        public ItensCatalogoTelefonico()
        {
            Telefone = new InformacaoTelefone();
        }
        public int Id { get; set; }
        public string Local { get; set; }
        public InformacaoTelefone Telefone { get; set; }
        public PermissaoCatalogoTelefonicoEnum PermissaoVisualizacao { get; set; }

        public int IdCatalogo { get; set; }
        public CatalogoTelefonico CatalogoTelefonico { get; set; }
    }
}