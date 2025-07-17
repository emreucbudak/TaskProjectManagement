using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task AddCompany (Company company);  
        Task DeleteCompany (Company company);
        Task<Company> GetCompanyById (int id);
        Task<IEnumerable<Company>> GetAll();
        Task UpdateCompany (Company company);

    }
}
