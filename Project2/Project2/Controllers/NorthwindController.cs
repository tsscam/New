using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class NorthwindController : Controller
    {
        // GET: Northwind
        public ActionResult Index()
        {
            return View();
        }
    }
    public ActionResult SearchCustomersbyShipCity(string City)
    {
        NorthwindEntities NE = new NorthwindEntities();


        List<Customer> CustomerList = NE.Customers.Where(x => x.
        City.ToUpper().
        Contains(ShipCity.ToUpper())).ToList();


        ViewBag.ShipCities = GetAllCities();
        ViewBag.CustomerList = CustomerList;

        return View("ListAllCustomers");
    }
    public ActionResult DeleteStudents(string StudentID)
    {
        try
        {
            if (StudentID== null)

            {
                ViewBag.ErrorMessage("Customer ID incorect");
                return View("ErrorMessage");
            }

            NorthwindEntities NE = new NorthwindEntities();
            //step #1 "find the custoemr that I need to delete....//
            StudentID ToDelete = NE.Customers.Find(StudentID);
            if (ToDelete == null)
            {
                ViewBag.ErrorMessage = "Unavailable";
                return View("ErrorMessage");
            }

            //removes OBJECTS from DATABASE

            NE.StudentID.Remove(ToDelete);

            //to SAVE EVERYTHING TO DATABASE.....
            NE.SaveChanges();

            //REDIRECT....after DELETE...GO TO LIST ALL CUSTOMER ..
            //EXECUTE the LISTALLCUSTOMER action
            return RedirectToAction("ListAllCustomers", "Northwind");
        }
        catch (System.Data.Entity.Infrastructure.DbUpdateException)
        {

            ViewBag.ErrorMessage = "You Cannot delete a student";
            return View("ErrorMessage");
        }
        catch (Exception)
        {
            ViewBag.ErrorMessage = "OOOOPS....Something happened unexpected. Try Again!";
            return View("ErrorMessage");
        }
    }
}