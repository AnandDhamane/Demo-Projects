using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public interface IEmployeesController
    {
        Task<ActionResult<Employee>> DeleteEmployee(int id);
        Task<ActionResult<IEnumerable<Employee>>> GetEmployee();
        Task<ActionResult<Employee>> GetEmployee(int id);
        Task<ActionResult<Employee>> PostEmployee(Employee employee);
        Task<IActionResult> PutEmployee(int id, Employee employee);
    }
}