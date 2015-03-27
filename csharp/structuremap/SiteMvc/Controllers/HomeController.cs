using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Implementacoes;
using Interfaces;


namespace SiteMvc.Controllers
{
    public class HomeController : Controller
    {
        private ITipoE _tipoE;

        public HomeController(ITipoE tipoE)
        {
            _tipoE = tipoE;
        }

        public ActionResult Index()
        {
            ViewBag.Mensagem = _tipoE.MetodoE();
            return View();
        }
    }
}