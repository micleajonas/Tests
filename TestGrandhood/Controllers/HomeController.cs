using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGrandhood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var numar1 = 1;
            var numar2 = 2;

            var total = numar1 + numar2;

            ViewBag.test2 = numar1;

            return View();
        }

        public ActionResult About()
        {
            var numar1 = 1;
            var numar2 = 2;

            ViewBag.testTest = (numar1 + numar2) / 3; 

            return View();
        }

        public ActionResult Contact()
        {


            return View();
        }

        public ActionResult Test()
        {


            return View();
        }

    }
}