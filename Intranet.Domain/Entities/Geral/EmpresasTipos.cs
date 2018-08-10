

namespace Intranet.Domain.Entities.Geral 
{
    public class EmpresasTipos
    {
        public int idEmpresa { get; set; }
        public Empresa empresa { get; set; }
        public int idTipoEmpresa { get; set; }
        public TipoEmpresa tipoEmpresa { get; set; }
        public DadosCriacaoRegistro DadosCriacaoRegistro { get; set; }
    }
}
