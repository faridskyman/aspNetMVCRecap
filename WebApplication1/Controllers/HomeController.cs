using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Demo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            // return Content(serial);
            // return new HttpStatusCodeResult(403);
            return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);

           // full list of action results
        }
    }
}