using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Portal.Controllers
{
    public class CRUDDemoController : Controller
    {
        //// To create View of this Action result
        //public ActionResult create()
        //{
        //    return View();
        //}

        //// Specify the type of attribute i.e.
        //// it will add the record to the database
        //[HttpPost]
        //public ActionResult create(CRUDDemo model)
        //{

        //    // To open a connection to the database
        //    using (var context = new DEMOCrudEntities())
        //    {
        //        // Add data to the particular table
        //        context.CRUDDemoes.Add(model);

        //        // save the changes
        //        context.SaveChanges();
        //    }
        //    string message = "Created the record successfully";

        //    // To display the message on the screen
        //    // after the record is created successfully
        //    ViewBag.Message = message;

        //    // write @Viewbag.Message in the created
        //    // view at the place where you want to
        //    // display the message
        //    return View();
        //}

        //[HttpGet] // Set the attribute to Read
        //public ActionResult
        //  Read()
        //{
        //    using (var context = new DEMOCrudEntities())
        //    {

        //        // Return the list of data from the database
        //        var data = context.CRUDDemoes.ToList();
        //        return View(data);
        //    }
        //}

        ////public ActionResult Update(int Studentid)
        ////{
        ////    using (var context = new DEMOCrudEntities())
        ////    {
        ////        var data = context.CRUDDemoes.Where(x => x.StudentId).SingleOrDefault();
        ////        return View(data);
        ////    }
        ////}

        ////// To specify that this will be 
        ////// invoked when post method is called
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public ActionResult Update(int StudentId, CRUDDemo model, int studentId)
        ////{
        ////    using (var context = new DEMOCrudEntities())
        ////    {

        ////        // Use of lambda expression to access
        ////        // particular record from a database



        ////        //var data = context.CRUDDemoes.FirstOrDefault(x => x.StudentNo == studentId);

        ////        // Checking if any such record exist 
        ////        if (data != null)
        ////        {
        ////            data.Name = model.Name;
        ////            data.StudentId = model.StudentId;
        ////            data.Unit = model.Unit;
        ////            data.Marks = model.Marks;
        ////            context.SaveChanges();

        ////            // It will redirect to 
        ////            // the Read method
        ////            return RedirectToAction("Read");
        ////        }
        ////        else
        ////            return View();
        ////    }
        ////}

    }
}