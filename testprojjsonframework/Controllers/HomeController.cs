using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testprojjsonframework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Title = "Search Page";

            return View();
        }

        public ActionResult TDetails()
        {
            ViewBag.Title = "Tirth Details";

            return View();
        }

        public ActionResult SubmitRequest()
        {
            ViewBag.Title = "Submit Request";

            return View();
        }
    }
}
