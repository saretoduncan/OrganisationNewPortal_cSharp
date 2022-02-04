using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organisationnewportal.Models;

namespace organisationnewportal.Data
{
    public interface IDataContext
    {
        DbSet<User> Users { get; set; }
        DbSet<GeneralNews> GeneralNews { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<DepartmentNews> DepartmentNews { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}