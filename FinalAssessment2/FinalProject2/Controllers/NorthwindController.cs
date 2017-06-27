using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject2.Controllers
{
    public class NorthwindController : Controller
    {
        // GET: Northwind
        public ActionResult Index()
        {
            NorthwindEntities NE = new NorthwindEntities();


            List<Orders> OrdersList = NE.Orders.Where(x => x.
            ShipCity.ToUpper().
            Contains(London.ToUpper())).ToList();

            ViewBag.ShipCity = GetAllShipCity();
            ViewBag.OrdersList = OrdersList;

            return View("ListAllCustomers");
        }
    }
}