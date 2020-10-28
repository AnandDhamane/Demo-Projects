using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = Collections.students.ToList();
            return View(students);
        }

        public ActionResult StudentList(int departmentId)
        {
            List<Student> students = Collections.students.Where(S => S.DepartmentId == departmentId).ToList();
            return View(students);
        }

        public ActionResult Details(int id)
        {
            Student student = Collections.students.First(Student => Student.Id == id);
            return View(student);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            Collections.students.Add(student);
            return RedirectToAction("Index");
        }
    }
}