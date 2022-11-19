using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmpAccountController : Controller
    {
        ProjectEMSEntities1 database = new ProjectEMSEntities1();
        // GET: EmpAccount
        public ActionResult Emplogin(t_Employees log)
        {
            HR_SignUp HRdata = new HR_SignUp();
             
            var credentials = database.t_Employees.Where(query => query.Email.Equals(log.Email) && query.Password.Equals(log.Password)).FirstOrDefault();
           
            if (credentials == null)
            {
                ViewBag.ErrorMessage = "Login Failed";


            }
            else

            {
                //int sessionid = credentials.emai;
                //Session["HRid"] = sessionid;
                Session["EMPID"] = credentials.Employee_ID.ToString();
                Session["EmpUsername"] = credentials.Username.ToString();
                return RedirectToAction("Index", "Empdashboard");
            }
            return View();
        }

        // GET: EmpAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpAccount/Create
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

        // GET: EmpAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpAccount/Edit/5
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

        // GET: EmpAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpAccount/Delete/5
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
