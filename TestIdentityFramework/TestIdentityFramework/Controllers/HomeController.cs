using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestIdentityFramework.Models;

using Microsoft.AspNet.Identity;

namespace TestIdentityFramework.Controllers
{
    [Authorize]// (Roles = "Admin,HR")]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    
        
        public ActionResult About()
        {
            //if (User.Identity.IsAuthenticated == false)
            //    return View("../Account/Login");

            ViewBag.Message = $"The User ID is{User.Identity.GetUserId()}, user name is {User.Identity.GetUserName()}";

            return View();
        }

        public ActionResult Contact()
        {
            // ORM for the Identity database 
            ApplicationDbContext UserDB = new ApplicationDbContext();

            ApplicationUser CurrentUserInfo = UserDB.Users.Find(User.Identity.GetUserId());

            ViewBag.Message = $"Your contact page. Welcome: {CurrentUserInfo.FirstName} {CurrentUserInfo.LastName} "; 

            return View();
        }
    }
}