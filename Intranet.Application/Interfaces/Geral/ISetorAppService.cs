using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.ViewModels.Geral;

namespace Intranet.Application.Interfaces.Geral
{
    public interface ISetorAppService : IAppServiceBaseViewModel<Setor, SetorViewModel>
    {
        
    }
}