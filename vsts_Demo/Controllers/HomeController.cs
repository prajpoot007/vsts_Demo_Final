﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vsts_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            /*
             * added comments 
             */
            return View();
        }

        public ActionResult Demo()
        {
            ViewBag.Title = "Home Page";

            /*
             * added comments 
             */
            return View();
        }
    }
}
