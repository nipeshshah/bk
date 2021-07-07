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

        [Route("Home/TDetails/{tirthId}")]
        public ActionResult TDetails(int? tirthId)
        {
            if(tirthId.HasValue)
            {
                ViewBag.TirthId = tirthId;
                return View();
            }
            else
            {
                return View("Index");
            }            
        }

        public ActionResult SubmitRequest()
        {
            ViewBag.Title = "Submit Request";

            return View();
        }
    }
}
