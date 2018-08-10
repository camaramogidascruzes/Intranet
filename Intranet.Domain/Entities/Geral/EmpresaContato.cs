
namespace Intranet.Domain.Entities.Geral
{
    public class EmpresaContato : CriacaoAlteracaoBasicEntity
    {
        public string nome { get; set; }
        public TipoTelefone tipoTelefone { get; set; }
        public string telefone { get; set; }
        public string operadora { get; set; }

        public int idEmpresa { get; set; }
        public Empresa empresa { get; set; }
    }
}
