using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Intranet.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        Task<List<TEntity>> Ler(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<List<TEntity>> LerTodosPagina(int numeroPagina, int itensPorPagina);
        Task<TEntity> LerPorID(int id);

        Task<TEntity> Novo(TEntity entity);
        Task<TEntity> Alterar(TEntity entity);
        Task Excluir(TEntity entity);
        Task Excluir(int id);

    }
}