﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorld.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult ShowInfo()
        {
            return View();
        }
    }
}