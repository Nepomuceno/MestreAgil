using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MestreAgil.Corporate.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Principal()
        {
            return View();
        }
        [Route("Funcionalidades")]
        public ActionResult Funcionalidades()
        {
            return View();
        }
        [Route("Contato")]
        public ActionResult Contato()
        {
            return View();
        }
	}
}