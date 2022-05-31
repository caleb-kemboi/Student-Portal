using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Portal.Controllers
{
    public class UnitPickerController : Controller
    {
        // GET: UnitPicker
        public ActionResult Manage()
        {
            return View();
        }

        // GET: UnitPicker/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UnitPicker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitPicker/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitPicker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UnitPicker/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UnitPicker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UnitPicker/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
