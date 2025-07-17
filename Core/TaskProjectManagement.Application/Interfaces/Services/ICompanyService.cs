using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ICompanyService
    {
        Task AddCompanyFromService(Company company);    
        Task DeleteCompanyFromService(int companyId);
        Task<Company> GetCompanyById(int companyId);
        Task<IEnumerable<Company>> GetAll();    
        Task UpdateCompany (Company company);
    }
}
