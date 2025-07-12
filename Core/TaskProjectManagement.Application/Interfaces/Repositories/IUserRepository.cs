using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task AddUser (User user);
        Task UpdateUser (User user);
        Task DeleteUser (User user);
        Task<IEnumerable<User>> GetAllUsers (bool v);
        Task<User> GetUserById (int id);
    }
}
