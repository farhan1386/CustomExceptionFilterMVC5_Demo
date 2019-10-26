using CustomExceptionFilter_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomExceptionFilter_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcDemoContext db = new MvcDemoContext();

        public ActionResult Index()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Position == "Software Engineer" && employee.Salary < 50000)
                {
                    throw new Exception("Salary is not matching with Software Engineer position.");
                }
                else if (employee.Position == "Accountant" && employee.Salary < 40000)
                {
                    throw new Exception("Salary is not matching with Accountant position.");
                }
                else if (employee.Position == "Senior Sales Executive" && employee.Salary < 40000)
                {
                    throw new Exception("Salary is not matching with Senior Sales Executive position.");
                }
                else
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}