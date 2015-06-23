﻿using HelloCodeFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelloCodeFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

      

        [Authorize]
        public ActionResult Hrms()
        {
            return View();
        }
    }
}
