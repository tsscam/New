using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public object HomeControllerEntities { get; private set; }

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
        public ActionResult welcome()
        {
            return View();
        }
        public ActionResult GetReceipt()
        {
            for (int i = 20000; i < 50000; i++)
            {

                Random randomObject = new Random();
                Console.WriteLine($"{i}", randomObject);
               
                ViewBag.Message = ("View");
                return View();
            }

        }
    }
}
    }

   