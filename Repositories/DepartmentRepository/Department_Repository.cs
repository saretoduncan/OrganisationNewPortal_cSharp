using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organisationnewportal.Data;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.DepartmentRepository
{
    public class Department_Repository : IDepartmentRepository
    {
        public readonly IDataContext _context;
        public Department_Repository(IDataContext context)
        {
            this._context = context;
        }
        public async Task AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDepartment(int id)
        {
            var itemToDelete = await _context.Departments.FindAsync(id);
            if (itemToDelete == null) throw new NullReferenceException();
            _context.Departments.Remove(itemToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Department> Get(int id)
        {
            return await _context.Departments.FindAsync(id);

        }

        public async Task<IEnumerable<Department>> GetAllDepartment()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task Update(Department department)
        {
            var itemToUpdate = await _context.Departments.FindAsync(department.Id);
            if (itemToUpdate == null)
            {
                throw new NullReferenceException();
            }
            itemToUpdate.DepartmentName = department.DepartmentName;
            itemToUpdate.Description = department.Description;

        }
    }
}