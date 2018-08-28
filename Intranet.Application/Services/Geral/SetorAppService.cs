using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Intranet.Application.Interfaces.Geral;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.Interfaces;
using Intranet.Domain.ViewModels.Geral;

namespace Intranet.Application.Services.Geral
{
    public class SetorAppService : ISetorAppService
    {
        private readonly IRepositoryBase<Setor> _repository;

        public SetorAppService(IRepositoryBase<Setor> repository)
        {
            this._repository = repository;
        }

        public Task<Setor> LerPorId(int id)
        {
            return _repository.LerPorID(id);
        }

        public async  Task<SetorViewModel> LerPorIdViewModel(int id)
        {
            var setor = await _repository.LerPorID(id);
            return SetorViewModel.SetorToViewModel(setor);
        }

        public Task<List<Setor>> LerTodos(Expression<Func<Setor, bool>> filter = null, Func<IQueryable<Setor>, IOrderedQueryable<Setor>> orderBy = null, string includeProperties = "")
        {
            return _repository.Ler(filter, orderBy, includeProperties);
        }

        public Task<List<Setor>> LerTodosPorPagina(int numeroPagina, int itensPorPagina, Func<IQueryable<Setor>, IOrderedQueryable<Setor>> orderBy = null)
        {
            if (numeroPagina <= 0)
            {
                throw new ArgumentException("Numero de página Inválido");
            }
            if (itensPorPagina <1)
            {
                throw new ArgumentException("Quantidade de Itens por Página Inválido");
            }

            return _repository.LerTodosPagina(numeroPagina, itensPorPagina, orderBy);
        }

        public async Task<List<SetorViewModel>> LerTodosPorPaginaViewModel(int numeroPagina, int itensPorPagina, Func<IQueryable<Setor>, IOrderedQueryable<Setor>> orderBy = null)
        {
            if (numeroPagina <= 0)
            {
                throw new ArgumentException("Numero de página Inválido");
            }
            if (itensPorPagina < 1)
            {
                throw new ArgumentException("Quantidade de Itens por Página Inválido");
            }

            var setores = await _repository.LerTodosPagina(numeroPagina, itensPorPagina, orderBy);

            var setoresVM = new List<SetorViewModel>();
            foreach (var s in setores)
            {
                setoresVM.Add(SetorViewModel.SetorToViewModel(s));
            }

            return setoresVM;

        }

        public Task<List<SetorViewModel>> LerTodosViewModel(Expression<Func<SetorViewModel, bool>> filter = null, Func<IQueryable<SetorViewModel>, IOrderedQueryable<SetorViewModel>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public async Task<List<SetorViewModel>> LerTodosViewModel(Expression<Func<Setor, bool>> filter = null, Func<IQueryable<Setor>, IOrderedQueryable<Setor>> orderBy = null, string includeProperties = "")
        {
            var setores = await _repository.Ler(filter, orderBy, includeProperties);
            var setoresVM = new List<SetorViewModel>();
            foreach (var s in setores)
            {
                setoresVM.Add(SetorViewModel.SetorToViewModel(s));
            }

            return setoresVM;
        }

        public Setor Novo(SetorViewModel entity, string usuario)
        {
            var setor = new Setor();
            setor.DadosCriacaoRegistro.UsuarioCriacao = usuario;
            setor.DadosAlteracaoRegistro.UsuarioUltimaAlteracao = usuario;

            return _repository.Novo(setor);
        }

        public Setor Alterar(SetorViewModel entity, string usuario)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(SetorViewModel entity)
        {
            throw new NotImplementedException();
        }

    }
}