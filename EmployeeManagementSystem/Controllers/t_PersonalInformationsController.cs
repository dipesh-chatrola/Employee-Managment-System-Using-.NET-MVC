using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeManagementSystem;

namespace EmployeeManagementSystem.Controllers
{
    public class t_PersonalInformationsController : Controller
    {
        private ProjectEMSEntities1 db = new ProjectEMSEntities1();

        // GET: t_PersonalInformations
        public ActionResult Index()
        {
            var t_PersonalInformations = db.t_PersonalInformations.Include(t => t.t_Employees);
            return View(t_PersonalInformations.ToList());
        }
        public ActionResult PersonalDetailsform()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PersonalDetailsform([Bind(Include = "Id,Employee_ID,PassportNo,Passport_Exp_Date,Tel,Nationality,Religion,Maritalstatus,EmrName1,EmrRelation1,EmrPhone11,EmrPhone12,EmrName2,EmrRelation2,EmrPhone21,EmrPhone22,Bankname,Bankaccno,IFSCCode,Panno")] t_PersonalInformations t_PersonalInformations)
        {
            return View();
        }
            // GET: t_PersonalInformations/Details/5
            public ActionResult Details(int? id)
        {
            return View();
           /* if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_PersonalInformations t_PersonalInformations = db.t_PersonalInformations.Find(id);
            if (t_PersonalInformations == null)
            {
                return HttpNotFound();
            }
            return View(t_PersonalInformations); */
        }

        // GET: t_PersonalInformations/Create
        public ActionResult Create()
        {
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname");
            return View();
        }

        // POST: t_PersonalInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Employee_ID,PassportNo,Passport_Exp_Date,Tel,Nationality,Religion,Maritalstatus,EmrName1,EmrRelation1,EmrPhone11,EmrPhone12,EmrName2,EmrRelation2,EmrPhone21,EmrPhone22,Bankname,Bankaccno,IFSCCode,Panno")] t_PersonalInformations t_PersonalInformations)
        {
            if (ModelState.IsValid)
            {
                db.t_PersonalInformations.Add(t_PersonalInformations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_PersonalInformations.Employee_ID);
            return View(t_PersonalInformations);
        }

        // GET: t_PersonalInformations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_PersonalInformations t_PersonalInformations = db.t_PersonalInformations.Find(id);
            if (t_PersonalInformations == null)
            {
                return HttpNotFound();
            }
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_PersonalInformations.Employee_ID);
            return View(t_PersonalInformations);
        }

        // POST: t_PersonalInformations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Employee_ID,PassportNo,Passport_Exp_Date,Tel,Nationality,Religion,Maritalstatus,EmrName1,EmrRelation1,EmrPhone11,EmrPhone12,EmrName2,EmrRelation2,EmrPhone21,EmrPhone22,Bankname,Bankaccno,IFSCCode,Panno")] t_PersonalInformations t_PersonalInformations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_PersonalInformations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_PersonalInformations.Employee_ID);
            return View(t_PersonalInformations);
        }

        // GET: t_PersonalInformations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_PersonalInformations t_PersonalInformations = db.t_PersonalInformations.Find(id);
            if (t_PersonalInformations == null)
            {
                return HttpNotFound();
            }
            return View(t_PersonalInformations);
        }

        // POST: t_PersonalInformations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            t_PersonalInformations t_PersonalInformations = db.t_PersonalInformations.Find(id);
            db.t_PersonalInformations.Remove(t_PersonalInformations);
            db.SaveChanges();
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





        public ActionResult Testingbeta()
        {
            return View();
        }
    }
}
