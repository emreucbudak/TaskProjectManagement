using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Application.Interfaces.Services;
using TaskProjectManagement.Domain.Entities;
using TaskProjectManagement.Persistence.Errors.NotFoundExceptions;

using TaskProjectManagement.Persistence.Repositories;

namespace TaskProjectManagement.Persistence.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly RepositoryManager _repositoryManager;

        public CompanyService(RepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddCompanyFromService(Company company)
        {

            await _repositoryManager.companyRepository.AddCompany(company); 
            await _repositoryManager.saveChangesAsync();
        }

        public async Task DeleteCompanyFromService(int companyId)
        {
            var getCompanyForDelete = await _repositoryManager.companyRepository.GetCompanyById(companyId);
            if (getCompanyForDelete is null)
            {
                throw new CompanyNotFoundException(companyId);
                
            }
            await _repositoryManager.companyRepository.DeleteCompany(getCompanyForDelete);
            await _repositoryManager.saveChangesAsync();
        }

        public async Task<IEnumerable<Company>> GetAll()
        {
            return await _repositoryManager.companyRepository.GetAll();
        }

        public async Task<Company> GetCompanyById(int companyId)
        {
            var getCompanyForList =  await GetCompanyById(companyId); 
            if (getCompanyForList is null)
            {
                throw new CompanyNotFoundException(companyId);
            }
            return getCompanyForList;
        }

        public async Task UpdateCompany(Company company)
        {
            var getCompanyForUpdate = await _repositoryManager.companyRepository.GetCompanyById(company.Id);
            if (getCompanyForUpdate is null)
            {
                throw new CompanyNotFoundException(company.Id);
            }
            getCompanyForUpdate.CompanyName = company.CompanyName;
            getCompanyForUpdate.CompanyLogo = company.CompanyLogo;
            if (company.CompanyMemberCount == 0) {
                getCompanyForUpdate.CompanyMemberCount = 0;
            }
            else
            {
                getCompanyForUpdate.CompanyMemberCount = company.CompanyMemberCount;
            }
            await _repositoryManager.companyRepository.UpdateCompany(getCompanyForUpdate);
            await _repositoryManager.saveChangesAsync();


        }
    }
}
