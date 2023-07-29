using Employee_Management_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using Employee_Management_Api.Models;

namespace Employee_Management_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetAllDepartment()
        {
            var result = _departmentService.GetAllDepartments();
            if(result == null)
            {
                return NotFound("Departments not found");
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<List<Department>>> GetSingleDepartment(int id)
        {
            var result = _departmentService.GetSingleDepartment(id);
            if (result == null)
            {
                return NotFound("No such department found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Department>>> AddNewDepartments(Department department)
        {
            var result = _departmentService.AddNewDepartments(department);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<List<Department>>> UpdateDepartments(Department department, int id)
        {
            var result = _departmentService.UpdateDepartments(department, id);
            if(result == null)
            {
                return NotFound("No department");
            }
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<List<Department>>> DeleteDepartments(int id)
        {
            var result = _departmentService.DeleteDepartment(id);
            if (result == null)
            {
                return NotFound("No such department found");
            }
            return Ok(result);
        }
    }
}
