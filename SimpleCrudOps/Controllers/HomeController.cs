using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCrudOps.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Title = "Users Page";

            return View();
        }

        public ActionResult WcfUsers()
        {
            ViewBag.Title = "Wcf Users Page";

            return View();
        }
    }
}
