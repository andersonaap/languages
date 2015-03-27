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
        private ITipoC _tipoC;

        public HomeController(ITipoC tipoC)
        {
            _tipoC = tipoC;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}