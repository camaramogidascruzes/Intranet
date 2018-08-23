using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Intranet.Application.Interfaces
{
    public interface IAppServiceBaseViewModel<TEntity, TEntityViewModel> 
        where TEntity: class  
        where TEntityViewModel : class
    {
        Task<TEntity> LerPorId(int id);
        Task<TEntityViewModel> LerPorIdViewModel(int id);

        Task<List<TEntity>> LerTodos(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<List<TEntityViewModel>> LerTodosViewModel(Expression<Func<TEntityViewModel, bool>> filter = null, Func<IQueryable<TEntityViewModel>, IOrderedQueryable<TEntityViewModel>> orderBy = null, string includeProperties = "");

        Task<List<TEntity>> LerTodosPorPagina(int numeroPagina, int itensPorPagina, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        Task<List<TEntityViewModel>> LerTodosPorPaginaViewModel(int numeroPagina, int itensPorPagina, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        TEntity Novo(TEntityViewModel entity, string usuario);
        TEntity Alterar(TEntityViewModel entity, string usuario);
        void Excluir(TEntityViewModel entity);
        void Excluir(int id);
    }
}