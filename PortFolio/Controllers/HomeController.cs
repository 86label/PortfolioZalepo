using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortFolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Something about me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Call me or write me an email, I will get back to you as soon as possible";

            return View();
        }
    }
}