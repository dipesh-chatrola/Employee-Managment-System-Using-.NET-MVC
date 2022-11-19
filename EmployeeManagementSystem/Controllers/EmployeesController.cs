using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {
        ProjectEMSEntities1 database = new ProjectEMSEntities1();
        // GET: Employees
        public ActionResult AddEmp()
        {

            return View();
        }
        
        

        // GET: Employees/Details/5
        public ActionResult Empdetails(int id)

        {

            var data = database.t_Employees.FirstOrDefault(x => x.Employee_ID == id);
            var personaldata = database.t_EmpPersonalInformations.FirstOrDefault(x => x.Employee_ID == id);
            var Emergencydata = database.t_EmpEmergencyContact.FirstOrDefault(x => x.Employee_ID == id);
            var Bankinformation = database.t_EmpBankInformations.FirstOrDefault(x => x.Employee_ID == id);

            ViewBag.Employeedata = data;
            ViewBag.personaldata = personaldata;
            ViewBag.emergencydata = Emergencydata;
            ViewBag.bankinformation = Bankinformation;
            //ViewData["Employeedata"] = data;
            return View();
        }
        public ActionResult Employees()
        {
            t_Employees empdata = new t_Employees();
            var data = from employees in database.t_Employees select employees;
            ViewBag.Employee = data;
            return View();

            //return View(empdata);
        }

        // GET: Employees/Create
        [HttpPost]
        public ActionResult Employees(EmployeesModel AddEmployee)
        {
            
                // TODO: Add insert logic here
                t_Employees EmployeesData = new t_Employees();
            //EmployeesData.Employee_ID = 1;
            if (ModelState.IsValid)
            {
                using (ProjectEMSEntities1 database = new ProjectEMSEntities1())
                {
                    var email = database.t_Employees.FirstOrDefault(u => u.Email.ToLower() == AddEmployee.Email.ToLower());
                    var username = database.t_Employees.FirstOrDefault(u => u.Username == AddEmployee.Username);
                    try
                    {
                        // Check if email already exists
                        if (username != null)
                        {
                            ModelState.AddModelError("UserName", "Username already exists");

                        }
                        else if (email != null)
                        {
                            ModelState.AddModelError("Email", "Email address already exists. Enter different email address.");
                        }

                        else
                        {
                            EmployeesData.RefHRID = Convert.ToInt32(Session["HRID"]);
                            EmployeesData.Firstname = AddEmployee.Firstname;
                            EmployeesData.Lastname = AddEmployee.Lastname;
                            EmployeesData.Username = AddEmployee.Username;
                            EmployeesData.Email = AddEmployee.Email;
                            EmployeesData.Mobileno = AddEmployee.Mobileno;
                            string dateString = AddEmployee.JoiningDate;
                            EmployeesData.JoiningDate = DateTime.Parse(dateString);
                            EmployeesData.Department = AddEmployee.Department;
                            EmployeesData.Designation = AddEmployee.Designation;
                            EmployeesData.Password = AddEmployee.Password;
                            database.t_Employees.Add(EmployeesData);
                            database.SaveChanges();
                        }
                    }
                    catch (MembershipCreateUserException e)
                    {

                        ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                    }
                }
                         

                //return RedirectToAction("Employees", "Employees");
            }
            return View();
               

            //EmployeesData.JoiningDate = Convert.ToDateTime(AddEmployee.JoiningDate);

            //EmployeesData.RefHRID = int.Parse(Session["HRID"]);



        }

        private Exception ErrorCodeToString(MembershipCreateStatus statusCode)
        {
            throw new NotImplementedException();
        }

        // POST: Employees/Create
        //FormCollection collection

        public ActionResult Create()
        {
            return View();
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            var data = database.t_Employees.FirstOrDefault(x => x.Employee_ID == id);
            //ViewBag.Employeedata = data;
            return View();
        }

        // POST: Employees/Edit/5
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

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
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
