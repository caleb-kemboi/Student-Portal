using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Student_Portal.Models;

namespace Student_Portal.Controllers
{
    public class UnitDetailsController : Controller
    {
        private EntityModel db = new EntityModel();

        // GET: UnitDetails
        public async Task<ActionResult> Index()
        {
            return View(await db.UnitDetails.ToListAsync());
        }

        // GET: UnitDetails/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitDetail unitDetail = await db.UnitDetails.FindAsync(id);
            if (unitDetail == null)
            {
                return HttpNotFound();
            }
            return View(unitDetail);
        }

        // GET: UnitDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UnitDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UnitName,UnitCode,Year,Semester")] UnitDetail unitDetail)
        {
            if (ModelState.IsValid)
            {
                db.UnitDetails.Add(unitDetail);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(unitDetail);
        }

        // GET: UnitDetails/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitDetail unitDetail = await db.UnitDetails.FindAsync(id);
            if (unitDetail == null)
            {
                return HttpNotFound();
            }
            return View(unitDetail);
        }

        // POST: UnitDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UnitName,UnitCode,Year,Semester")] UnitDetail unitDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unitDetail).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(unitDetail);
        }

        // GET: UnitDetails/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UnitDetail unitDetail = await db.UnitDetails.FindAsync(id);
            if (unitDetail == null)
            {
                return HttpNotFound();
            }
            return View(unitDetail);
        }

        // POST: UnitDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            UnitDetail unitDetail = await db.UnitDetails.FindAsync(id);
            db.UnitDetails.Remove(unitDetail);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
