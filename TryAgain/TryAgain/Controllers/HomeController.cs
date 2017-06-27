using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TryAgain.Controllers
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
        public ActionResult GetQuote()
        {
            
            string[] QuoteArray = { "Don't cry because it's over, smile because it happened - Dr.Seuss", "Be yourself; everyone else is already taken ― Oscar Wilde", "You've gotta dance like there's nobody watching-Love like you'll never be hurt, Sing like there's nobody listening, And live like it's heaven on earth ― William W. Purkey" };
            Random randomString = new Random();
            string getQuote = QuoteArray[randomString.Next(QuoteArray.Length)];
            ViewBag.GetQuoteArray = getQuote;

            //
            return View();
        }
    }
}