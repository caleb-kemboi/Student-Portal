using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Student_Portal.Models;
using System.ComponentModel;

namespace Student_Portal.Controllers
{
    
    public class UnitsController : Controller
    {
        string connectionString = @"Data Source = AGILE-LPT15\MSSQLSERVER01;initial catalog=Student_Portal;integrated security=True";
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dtblUnits = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM UnitsSchool", sqlCon);
                sqlDa.Fill(dtblUnits);
            }
            return View(dtblUnits);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new UnitsModel());
        }

        // POST: Units/Create
        [HttpPost]
        public ActionResult Create(UnitsModel unitsModel, FormCollection form)
        {



            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "INSERT INTO UnitsSchool VALUES(@Course,@Units,@Year,@Semester,@AttachId)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                sqlCmd.Parameters.AddWithValue("@Course", unitsModel.Course);
                sqlCmd.Parameters.AddWithValue("@Units", unitsModel.Units);
                sqlCmd.Parameters.AddWithValue("@Year", unitsModel.Year);
                sqlCmd.Parameters.AddWithValue("@Semester", unitsModel.Semester);
                sqlCmd.Parameters.AddWithValue("@AttachId", unitsModel.AttachId);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        // GET: Units/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Units/Edit/5
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

        // GET: Units/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Units/Delete/5
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
