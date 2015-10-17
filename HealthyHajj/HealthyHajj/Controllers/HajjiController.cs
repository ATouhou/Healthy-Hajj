using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HealthyHajj.DAL;
using HealthyHajj.Models;

namespace HealthyHajj.Controllers
{
    public class HajjiController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Hajji
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Hajjis.ToList());
        }

        // GET: Hajji/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hajji hajji = db.Hajjis.Find(id);
            if (hajji == null)
            {
                return HttpNotFound();
            }
            return View(hajji);
        }

        // GET: Hajji/Details/5
        [Authorize]
        public ActionResult CheckIn(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hajji hajji = db.Hajjis.Find(id);
            if (hajji == null)
            {
                return HttpNotFound();
            }
            return View(hajji);
        }

        [Authorize]
        // GET: Hajji/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hajji/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,DoctorName,HajjiAddress,DoctorAddress,HajjiContact,DoctorContact,HajjiMedicalInformation")] Hajji hajji)
        {
            if (ModelState.IsValid)
            {
                db.Hajjis.Add(hajji);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hajji);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        [Authorize]
        public ActionResult CheckIn()
        {
            return null;
        }

        [Authorize]
        public ActionResult AssignPage()
        {
            return null;
        }

        [Authorize]
        public ActionResult CheckOut()
        {
            return null;
        }
    }
}
