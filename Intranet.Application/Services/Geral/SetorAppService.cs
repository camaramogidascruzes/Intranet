using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Intranet.Application.Interfaces.Geral;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.Interfaces;

namespace Intranet.Application.Services.Geral
{
    public class SetorAppService : ISetorAppService
    {
        private IRepositoryBase<Setor> _repository;

        public SetorAppService(IRepositoryBase<Setor> repository)
        {
            this._repository = repository;
        }

        public Task<Setor> Alterar(Setor entity, string usuario)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Setor entity)
        {
            throw new NotImplementedException();
        }

        public Task<Setor> LerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Setor>> LerTodos(Expression<Func<Setor, bool>> filter = null, Func<IQueryable<Setor>, IOrderedQueryable<Setor>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Task<List<Setor>> LerTodosPorPagina(int numeroPagina, int itensPorPagina)
        {
            throw new NotImplementedException();
        }

        public Task<Setor> Novo(Setor entity, string usuario)
        {
            throw new NotImplementedException();
        }
    }
}