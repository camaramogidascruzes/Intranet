using Intranet.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Intranet.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private DbContext _context;
        private DbSet<TEntity> _set;

        public RepositoryBase(DbContext context)
        {
            this._context = context;
        }

        protected DbSet<TEntity> Set
        {
            get { return _set ?? (_set = this._context.Set<TEntity>()); }
        }

        public async Task<List<TEntity>> Ler(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = Set;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync<TEntity>();
            }
            else
            {
                return await query.ToListAsync<TEntity>();
            }
        }

        public async Task<List<TEntity>> LerTodosPagina(int numeroPagina, int itensPorPagina)
        {
            return await Set.Skip((numeroPagina - 1) * itensPorPagina).Take(itensPorPagina).ToListAsync<TEntity>();
        }

        public async Task<TEntity> LerPorID(int id)
        {
            return await Set.FindAsync(id);
        }

        public async Task<TEntity> Novo(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TEntity> Alterar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task Excluir(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                    _context.Dispose();
                }

                disposedValue = true;
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