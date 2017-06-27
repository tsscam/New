using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yoda_Finance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "YODA+Finance";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetQuote()
        {
            string[] QuoteArray = { };
            Random Q = new Random();
            int index = Q.Next(0, QuoteArray.Length);
            ViewBag.Quote = QuoteArray[index];

            return View();
        }
    }
}