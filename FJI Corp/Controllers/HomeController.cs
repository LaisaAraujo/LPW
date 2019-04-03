using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FJI_Corp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Service()
        {
            ViewBag.Message = "Serviço";

            return View();
        }
        public ActionResult Formulario()
        {
            ViewBag.Message = "Serviço";

            return View();
        }
    }
}