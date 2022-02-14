using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.DepartmentNewsRepository
{
    public interface IDepartmentNews_Repository
    {
        Task AddDepartmentNews(DepartmentNews departmentNews);
        Task GetDepartmentNewsById(int id);
        Task GetAllDepartmentsNewsByDepartmentId(int id);
        Task<IEnumerable<DepartmentNews>> GetAllDepartmentNews();
        Task DeleteDepartmentNews(int id);
        Task updateDepartmentNews(DepartmentNews departmentNews);

    }
}