using System.Threading.Tasks;
using System.Web.Mvc;
using Intranet.Application.Interfaces.Geral;
using Intranet.Domain.Entities.Geral;
using Intranet.Domain.ViewModels.Geral;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Intranet.UI.Web.Areas.Geral.Controllers
{
    public class SetorController : Controller
    {
        private readonly ISetorAppService _setorservice;

        public SetorController(ISetorAppService setorservice)
        {
            _setorservice = setorservice;
        }

        // GET: Geral/Setor
        public async Task<ActionResult> Index()
        {
            var setores = await _setorservice.LerTodos();
            return View();
        }

        public async Task<ActionResult> LerTodos([DataSourceRequest]DataSourceRequest request)
        {
            var setores = await _setorservice.LerTodos();
            return Json(setores.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public async Task<ActionResult> Criar([DataSourceRequest] DataSourceRequest request, SetorViewModel setorVM)
        {
            if (setorVM != null && ModelState.IsValid)
            {
                await _setorservice.Novo(setorVM.ToSetor(), User.Identity.Name);
            }

            return Json(new[] { setorVM }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public async Task<ActionResult> Alterar([DataSourceRequest] DataSourceRequest request, SetorViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {
                _setorservice.Alterar();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public async Task<ActionResult> Excluir([DataSourceRequest] DataSourceRequest request, SetorViewModel product)
        {
            if (product != null)
            {
                await _setorservice.Excluir();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
    }
}