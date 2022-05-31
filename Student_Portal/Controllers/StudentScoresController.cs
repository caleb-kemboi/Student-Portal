using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Student_Portal;

namespace Student_Portal.Controllers

{
    [Authorize]
    public class StudentScoresController : Controller
    {
        private UnitCourses db = new UnitCourses();

        // GET: StudentScores
        public async Task<ActionResult> Index()
        {
            return View(await db.StudentScores.ToListAsync());
        }

        // GET: StudentScores/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentScore studentScore = await db.StudentScores.FindAsync(id);
            if (studentScore == null)
            {
                return HttpNotFound();
            }
            return View(studentScore);
        }

        // GET: StudentScores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentScores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,Course,Unit,Score")] StudentScore studentScore)
        {
            if (ModelState.IsValid)
            {
                db.StudentScores.Add(studentScore);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(studentScore);
        }

        // GET: StudentScores/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentScore studentScore = await db.StudentScores.FindAsync(id);
            if (studentScore == null)
            {
                return HttpNotFound();
            }
            return View(studentScore);
        }

        // POST: StudentScores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Course,Unit,Score")] StudentScore studentScore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentScore).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(studentScore);
        }

        // GET: StudentScores/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentScore studentScore = await db.StudentScores.FindAsync(id);
            if (studentScore == null)
            {
                return HttpNotFound();
            }
            return View(studentScore);
        }

        // POST: StudentScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StudentScore studentScore = await db.StudentScores.FindAsync(id);
            db.StudentScores.Remove(studentScore);
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
