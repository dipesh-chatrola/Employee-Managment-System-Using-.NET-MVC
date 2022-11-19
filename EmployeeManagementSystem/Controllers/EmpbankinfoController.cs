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
    public class EmpbankinfoController : Controller
    {
        private ProjectEMSEntities1 db = new ProjectEMSEntities1();

        // GET: Empbankinfo
        public ActionResult Index()
        {
            var t_EmpBankInformations = db.t_EmpBankInformations.Include(t => t.t_Employees);
            return View(t_EmpBankInformations.ToList());
        }

        // GET: Empbankinfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_EmpBankInformations t_EmpBankInformations = db.t_EmpBankInformations.Find(id);
            if (t_EmpBankInformations == null)
            {
                return HttpNotFound();
            }
            return View(t_EmpBankInformations);
        }

        // GET: Empbankinfo/Create
        public ActionResult Create()
        {
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname");
            return View();
        }

        // POST: Empbankinfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Employee_ID,Bankname,Bankaccno,IFSCCode,Panno")] t_EmpBankInformations t_EmpBankInformations)
        {
            if (ModelState.IsValid)
            {
                db.t_EmpBankInformations.Add(t_EmpBankInformations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_EmpBankInformations.Employee_ID);
            return View(t_EmpBankInformations);
        }

        // GET: Empbankinfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_EmpBankInformations t_EmpBankInformations = db.t_EmpBankInformations.Find(id);
            if (t_EmpBankInformations == null)
            {
                return HttpNotFound();
            }
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_EmpBankInformations.Employee_ID);
            return View(t_EmpBankInformations);
        }

        // POST: Empbankinfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Employee_ID,Bankname,Bankaccno,IFSCCode,Panno")] t_EmpBankInformations t_EmpBankInformations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(t_EmpBankInformations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Employee_ID = new SelectList(db.t_Employees, "Employee_ID", "Firstname", t_EmpBankInformations.Employee_ID);
            return View(t_EmpBankInformations);
        }

        // GET: Empbankinfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            t_EmpBankInformations t_EmpBankInformations = db.t_EmpBankInformations.Find(id);
            if (t_EmpBankInformations == null)
            {
                return HttpNotFound();
            }
            return View(t_EmpBankInformations);
        }

        // POST: Empbankinfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            t_EmpBankInformations t_EmpBankInformations = db.t_EmpBankInformations.Find(id);
            db.t_EmpBankInformations.Remove(t_EmpBankInformations);
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
