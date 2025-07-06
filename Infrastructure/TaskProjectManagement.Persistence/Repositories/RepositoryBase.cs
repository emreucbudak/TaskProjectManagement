using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Repositories;

namespace TaskProjectManagement.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
