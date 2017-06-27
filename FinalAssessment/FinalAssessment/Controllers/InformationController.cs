using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalAssessment.Controllers
{
    public class InformationController : Controller
    {
        // Welcome Controller
        public ActionResult Welcome()
        {
            ViewBag.Message = "Thank you for visiting.";

            return View();
        }
        public void Main (string[] PurchaseReceipt)
        {
            Random num = new Random();
            string a ="";
            for (int i = 20000; i < 50000; i++)
            {
                a += num.Next(0);
            }
            Console.WriteLine("Order#" + a);
        }
    }
}