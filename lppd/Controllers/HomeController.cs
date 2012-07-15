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

        public ActionResult Donate()
        {
            ViewBag.Message = "Donate";
            return View();
        }

        public ActionResult Merchandise()
        {
            ViewBag.Message = "spread the word, you know you want to";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";
            return View();
        }
    }
}
