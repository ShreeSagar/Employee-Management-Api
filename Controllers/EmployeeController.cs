using Employee_Management_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Pranamya",
                LastName = "Sirsi",
                Address = "Sirsi, Uttara Kannada",
                Gender = "Female",
                Salary = 40000
            },
             new Employee
            {
                Id = 2,
                FirstName = "Pragathi",
                LastName = "Sirsi",
                Address = "Sirsi, Uttara Kannada",
                Gender = "Female",
                Salary = 40000
            },
              new Employee
            {
                Id = 3,
                FirstName = "Pramathi",
                LastName = "Sirsi",
                Address = "Sirsi, Uttara Kannada",
                Gender = "Female",
                Salary = 40000
            },
               new Employee
            {
                Id = 4,
                FirstName = "Prathima",
                LastName = "Sirsi",
                Address = "Sirsi, Uttara Kannada",
                Gender = "Female",
                Salary = 40000
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetAllEmployees()
        {
            return Ok(employees);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Employee>>> GetSingleEmployee(int id)
        {
            var employee = employees.Find(x => x.Id == id);
            if(employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return NotFound("No such employee found");
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> AddNewEmployees(Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployees(Employee request, int id)
        {
            var emp = employees.Find(x => x.Id == id);
            if (emp == null)
            {
                return NotFound("No such employee found");
            }
            emp.Id = request.Id;
            emp.FirstName = request.FirstName;
            emp.LastName = request.LastName;
            emp.Address = request.Address;
            emp.Gender = request.Gender;
            emp.Salary = request.Salary;

            return Ok(emp);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Employee>>> RemoveEmployees(int id)
        {
            var emp = employees.Find(x => x.Id == id);
            if (emp == null)
            {
                return NotFound("No such employee found");
            }
            employees.Remove(emp);
            return Ok(emp);
        }
    }
}
