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
    public class EmpemergencycontactController : Controller
    {
        private ProjectEMSEntities1 db = new ProjectEMSEntities1();

        // GET: Empemergencycontact
        public ActionResult Index()
        {
            var t_EmpEmergencyContact = db.t_EmpEmergencyContact.Include(t => t.t_Employees);
            return View(t_EmpEmergencyContact.ToList());
        }

        // GET: Empemergencycontact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_EmpEmergencyContact t_EmpEmergencyContact = db.t_EmpEmergencyContact.Find(id);
            if (t_EmpEmergencyContact == null)
            {
                return HttpNotFound();
            }
            return View(t_EmpEmergencyContact);
        }

        // GET: Empemergencycontact/Create
        public ActionResult Create()
        {
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname");
            return View();
        }

        // POST: Empemergencycontact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Employee_ID,EmrName1,EmrRelation1,EmrPhone11,EmrPhone12,EmrName2,EmrRelation2,EmrPhone21,EmrPhone22")] t_EmpEmergencyContact t_EmpEmergencyContact)
        {
            if (ModelState.IsValid)
            {
                db.t_EmpEmergencyContact.Add(t_EmpEmergencyContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_EmpEmergencyContact.Employee_ID);
            return View(t_EmpEmergencyContact);
        }

        // GET: Empemergencycontact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_EmpEmergencyContact t_EmpEmergencyContact = db.t_EmpEmergencyContact.Find(id);
            if (t_EmpEmergencyContact == null)
            {
                return HttpNotFound();
            }
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_EmpEmergencyContact.Employee_ID);
            return View(t_EmpEmergencyContact);
        }

        // POST: Empemergencycontact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Employee_ID,EmrName1,EmrRelation1,EmrPhone11,EmrPhone12,EmrName2,EmrRelation2,EmrPhone21,EmrPhone22")] t_EmpEmergencyContact t_EmpEmergencyContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_EmpEmergencyContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_EmpEmergencyContact.Employee_ID);
            return View(t_EmpEmergencyContact);
        }

        // GET: Empemergencycontact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_EmpEmergencyContact t_EmpEmergencyContact = db.t_EmpEmergencyContact.Find(id);
            if (t_EmpEmergencyContact == null)
            {
                return HttpNotFound();
            }
            return View(t_EmpEmergencyContact);
        }

        // POST: Empemergencycontact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            t_EmpEmergencyContact t_EmpEmergencyContact = db.t_EmpEmergencyContact.Find(id);
            db.t_EmpEmergencyContact.Remove(t_EmpEmergencyContact);
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
    }
}
