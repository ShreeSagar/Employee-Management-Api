using Employee_Management_Api.Models;

namespace Employee_Management_Api.Services
{
    public interface IDepartmentService
    {
        public List<Department> GetAllDepartments();
        public Department GetSingleDepartment(int id);
        public List<Department> AddNewDepartments(Department department);
        public List<Department> UpdateDepartments(Department departments, int id);
        public List<Department> DeleteDepartment(int id);
    }
}
