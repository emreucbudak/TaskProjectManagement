using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface ICompanyRequestService
    {
        Task AddCompanyRequestFromService (CompanyRequest request);
        Task DeleteCompanyRequestFromService (int companyId);   
        Task UpdateCompanyRequestFromService (CompanyRequest request);
        Task<CompanyRequest> GetCompanyRequestFromService(int companyId);
        Task<IEnumerable<CompanyRequest>> GetAllCompanyRequestFromService ();
    }
}
