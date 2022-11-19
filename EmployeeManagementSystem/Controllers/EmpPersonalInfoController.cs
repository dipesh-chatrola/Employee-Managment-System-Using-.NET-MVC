using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmpPersonalInfoController : Controller
    {
        ProjectEMSEntities1 db = new ProjectEMSEntities1();
        // GET: EmpPersonalInfo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmpPersonalInformations([Bind(Include = "Id,Employee_ID,PassportNo,Passport_Exp_Date,Tel,Nationality,Religion,Maritalstatus")] t_EmpPersonalInformations t_EmpPersonalInformations)
        {
            if (ModelState.IsValid)
            {
                db.t_EmpPersonalInformations.Add(t_EmpPersonalInformations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult EmpPersonalInformations()
        {
            return View();
        }

        // GET: EmpPersonalInfo/Details/5
        public ActionResult EmpEmergencyContact(int id)
        {
            return View();
        }

        // GET: EmpPersonalInfo/Create
        public ActionResult EmpBankInformations()
        {
            return View();
        }

        // POST: EmpPersonalInfo/Create
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

        // GET: EmpPersonalInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpPersonalInfo/Edit/5
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

        // GET: EmpPersonalInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpPersonalInfo/Delete/5
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
