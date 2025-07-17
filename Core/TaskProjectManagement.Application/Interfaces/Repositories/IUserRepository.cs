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
        Task AddUser (CompanyLeader user);
        Task UpdateUser (CompanyLeader user);
        Task DeleteUser (CompanyLeader user);
        Task<IEnumerable<CompanyLeader>> GetAllUsers ();
        Task<CompanyLeader> GetUserById (int id);
    }
}
