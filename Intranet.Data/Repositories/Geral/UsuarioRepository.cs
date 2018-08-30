using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.Interfaces.Repositories.Geral;

namespace Intranet.Data.Repositories.Geral
{
    public class UsuarioRepository: RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DbContext context) : base(context)
        {
            if (context == null) throw new ArgumentNullException();
        }

        public async Task<Usuario> BuscarPorNome(string username)
        {
            return await Set.AsNoTracking().SingleOrDefaultAsync(e => e.Login == username);
        }
    }
}