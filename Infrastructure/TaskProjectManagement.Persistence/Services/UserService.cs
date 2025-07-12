using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Persistence.Services
{
    public class UserService : IUserServices
    {
        private readonly IRepositoryManager _rp;

        public UserService(IRepositoryManager rp)
        {
            _rp = rp;
        }

        public async Task AddUserFromService(User user)
        {
            user.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
            await _rp.userRepository.AddUser(user);
            await _rp.saveChangesAsync();
        }

        public async Task DeleteUserFromService(int id)
        {
            var getDeleteFromUser = await _rp.userRepository.GetUserById(id);
            await _rp.userRepository.DeleteUser(getDeleteFromUser);
            await _rp.saveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _rp.userRepository.GetAllUsers();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _rp.userRepository.GetUserById(id);
        }

        public async Task UpdateUserFromService(User user)
        {
            var getUserForUpdate = await _rp.userRepository.GetUserById(user.UserId);
            getUserForUpdate.Surname = user.Surname;
            getUserForUpdate.Email = user.Email;
            getUserForUpdate.Name = user.Name;
            getUserForUpdate.Password = BCrypt.Net.BCrypt.EnhancedHashPassword(user.Password);
            await _rp.userRepository.UpdateUser(getUserForUpdate);
            await _rp.saveChangesAsync();

        }
    }
}
