using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.DepartmentRepository
{
    public interface IDepartmentRepository
    {
        Task AddDepartment(Department department);
        Task<Department> Get(int id);
        Task<IEnumerable<Department>> GetAllDepartment();
        Task DeleteDepartment(int id);
        Task Update(Department department);
    }
}