using MVCWebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{ Id = 1, Name = "Anand", Age = 34, Gender = "Male" },
            new Employee{ Id = 2, Name = "Tanuja", Age = 32, Gender = "Female" }
        };

        // GET: Employee
        public ActionResult EmployeesList()
        {
            return View(employees);
        }

        public ActionResult EmployeeDetails(int id)
        {
            Employee employee = employees.Single(Emp => Emp.Id == id);
            return View(employee);
        }

        public ActionResult HyperLinks()
        {
            return View(employees);
        }
    }
}