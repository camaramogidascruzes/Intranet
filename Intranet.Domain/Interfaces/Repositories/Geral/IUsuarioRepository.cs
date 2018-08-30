using System.Threading.Tasks;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Domain.Interfaces.Repositories.Geral
{
    public interface IUsuarioRepository
    {
        Task<Usuario> BuscarPorNome(string username);
    }
}