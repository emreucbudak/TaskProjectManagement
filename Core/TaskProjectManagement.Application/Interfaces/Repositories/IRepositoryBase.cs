using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IRepositoryBase <T> where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> GetById (int id);
        Task <IEnumerable<T>> GetAll ();
    }
}
