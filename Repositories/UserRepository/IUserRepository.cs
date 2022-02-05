using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using organisationnewportal.Models;

namespace organisationnewportal.Repositories.UserRepository
{
    public interface IUserRepository
    {
        Task<User> Get(int id);
        Task<IEnumerable<User>> GetAllUser();
        Task AddUser(User user);
        Task UpdateUser(User user);

       
        Task DeleteUser(int id);

    }
}