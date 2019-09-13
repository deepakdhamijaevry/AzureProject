using AzureProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureProject.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult EmployeeDetail()
        {
            EmployeeContext context = new EmployeeContext();
            List<Employee> employeeList = context.employee.ToList();
            return View(employeeList);
        }
        [Authorize(Roles = "MCC")]
        [HttpGet]
        public ActionResult EmployeeHistory()
        {
            return View();
        }
    }
}