using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Intranet.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        Task<TEntity> LerPorId(int id);
        Task<List<TEntity>> LerTodos(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<List<TEntity>> LerTodosPorPagina(int numeroPagina, int itensPorPagina);
        Task<TEntity> Novo(TEntity entity, string usuario);
        Task<TEntity> Alterar(TEntity entity, string usuario);
        Task Excluir(TEntity entity);
        Task Excluir(int id);
    }
}