using Employee_Management_Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Employee_Management_Api.Services
{
    public class DepartmentService : IDepartmentService
    {
        private static List<Department> departments = new List<Department>
        {
            new Department
            {
                Id = 1,
                Name = "Account",
                Code = "D1"
            },
            new Department
            {
                Id = 2,
                Name = "Finance",
                Code = "D2"
            },
            new Department
            {
                Id = 3,
                Name = "Bussiness",
                Code = "D3"
            },
            new Department
            {
                Id = 4,
                Name = "",
                Code = "D1"
            }
        };

        public List<Department> AddNewDepartments(Department department)
        {
            departments.Add(department);
            return departments;
        }

        public List<Department> DeleteDepartment(int id)
        {
            var department = departments.Find(x => x.Id == id);
            if(department == null)
            {
                return null;
            }
            else
            {
                departments.Remove(department);
            };
            return departments;
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }

        public Department GetSingleDepartment(int id)
        {
            var dept = departments.Find(x => x.Id == id);
            if (dept == null)
               return null;
            return dept;
        }

        public List<Department> UpdateDepartments(Department department, int id)
        {
            var dept = departments.Find(x => x.Id == id);
            if (dept == null)
            {
                return null;
            }
            else
            {
                dept.Id = department.Id;
                dept.Name = department.Name;
                dept.Code = department.Code;
            };
            return departments;
        }
    }
}

