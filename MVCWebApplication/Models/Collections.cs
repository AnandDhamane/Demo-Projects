using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApplication.Models
{
    public class Collections
    {
        public static List<Department> departments = new List<Department>()
        {
            new Department { Id = 1, Name = "Arts" },
            new Department { Id = 2, Name = "Commerce" },
            new Department { Id = 3, Name = "Science" }
        };

        public static List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Anand", Age = 34, DepartmentId = 1 },
            new Student { Id = 2, Name = "Tanuja", Age = 32, DepartmentId = 2 },
            new Student { Id = 3, Name = "Aarya", Age = 16, DepartmentId = 1 },
            new Student { Id = 4, Name = "Mansi", Age = 30, DepartmentId = 3 }
        };
    }
}