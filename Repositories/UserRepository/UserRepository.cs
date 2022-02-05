using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organisationnewportal.Data;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.UserRepository
{

    public class UserRepository : IUserRepository
    {
        private readonly IDataContext _context;
        public UserRepository(IDataContext context)
        {
            this._context = context;
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int id)
        {
            var itemToDelete = await _context.Users.FindAsync(id);

        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);

        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task UpdateUser(User user)
        {
            var itemToUpdate = await _context.Users.FindAsync(user.Id);
            if (itemToUpdate == null) throw new NullReferenceException();
            itemToUpdate.Name = user.Name;
            itemToUpdate.DepartmentId = user.DepartmentId;
            itemToUpdate.Role = user.Role;
            itemToUpdate.Position = user.Position;
            await _context.SaveChangesAsync();
        }


    }
}