using Intranet.Application.Interfaces.Geral;
using Intranet.Application.Services.Geral;
using Intranet.Data.Context;
using Intranet.Data.Repositories.Geral;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.Interfaces;
using SimpleInjector;
using SimpleInjector.Integration.Web;

namespace Intranet.Infra.Ioc
{
    public class Bootstrap
    {
        public static void RegisterServices(Container container)
        {
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<GeralContext>(Lifestyle.Scoped);
            // Repositories
            container.Register<IRepositoryBase<Setor>,SetorRepository >(Lifestyle.Scoped);
            //Services
            container.Register<ISetorAppService, SetorAppService>(Lifestyle.Scoped);
        }
    }
}