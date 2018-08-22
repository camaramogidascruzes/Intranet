using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Intranet.Application.Interfaces.Geral;

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
        public ActionResult Index()
        {
            var setores = _setorservice.LerTodos();
            return View();
        }
    }
}