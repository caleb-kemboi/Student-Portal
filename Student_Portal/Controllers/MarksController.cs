﻿using Student_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Portal.Controllers
{
    public class MarksController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Marks
        [Authorize]

        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult Manage()
        {
            return View();
        }

       

        
    }
}