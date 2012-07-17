using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lppd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Sponsor()
        {
            ViewBag.Message = "Sponsorship Opportunities Available";
            return View();
        }

        public ActionResult Merchandise(string id)
        {
            ViewBag.Message = "spread the word, you know you want to";
                       
            return View();
           
        }
    }
}
