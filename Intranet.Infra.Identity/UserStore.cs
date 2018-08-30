using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Intranet.Data.Repositories.Geral;

namespace Intranet.Infra.Identity
{
    public class UserStore: IUserStore<IdentityUser, int>
    {
        private readonly UsuarioRepository _usuariorepository;

        public UserStore(UsuarioRepository usuariorepository)
        {
            _usuariorepository = usuariorepository;
        }

        public Task CreateAsync(IdentityUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _usuariorepository.Novo(user);

            return _usuariorepository.Salvar();
        }

        public Task UpdateAsync(IdentityUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _usuariorepository.Alterar(user);

            return _usuariorepository.Salvar();
        }

        public Task DeleteAsync(IdentityUser user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _usuariorepository.Excluir(user);

            return _usuariorepository.Salvar();
        }

        public Task<IdentityUser> FindByIdAsync(int userId)
        {
            var usuario = _usuariorepository.LerPorID(userId);
            return Task.FromResult<IdentityUser>(IdentityUser.FromUsuario(usuario.Result));
        }

        public Task<IdentityUser> FindByNameAsync(string userName)
        {
            var usuario = _usuariorepository.BuscarPorNome(userName);
            return Task.FromResult<IdentityUser>(IdentityUser.FromUsuario(usuario.Result));
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {

                    this._usuariorepository.Dispose();
                }

                _disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}