using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Intranet.Domain.Entities;
using Intranet.Domain.Interfaces;

namespace Intranet.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BasicEntity
    {
        private readonly DbContext _context;
        private DbSet<TEntity> _set;

        public RepositoryBase(DbContext context)
        {
            this._context = context;
        }

        protected DbSet<TEntity> Set
        {
            get { return _set ?? (_set = this._context.Set<TEntity>()); }
        }

        public Task<List<TEntity>> Ler(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = Set;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToListAsync<TEntity>();
            }
            else
            {
                return query.ToListAsync<TEntity>();
            }
        }

        public Task<TEntity> LerPorID(int id)
        {
            return Set.FindAsync(id);
        }

        public Task<List<TEntity>> LerTodosPagina(int numeroPagina, int itensPorPagina)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Novo(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Alterar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(TEntity entity)
        {
            throw new NotImplementedException();
        }
        
        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {

                    _context.Dispose();
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
