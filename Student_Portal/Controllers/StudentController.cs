using Student_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Portal.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        // GET: Student
        public ActionResult Manage()
        {
            return View();
        }
        // POST
        [HttpPost]
        public ActionResult Manage(Student student)
        {
            if (ModelState.IsValid)
            {
                db.student.Add(student);
                db.SaveChanges();
            }
            return View(student);

        }


    }
}