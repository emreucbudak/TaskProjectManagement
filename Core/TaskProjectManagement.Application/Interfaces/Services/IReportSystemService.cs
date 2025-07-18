using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IReportSystemService
    {
        Task AddReportFromService (ReportSystem reportSystem);
        Task RemoveReportFromService (int reportSystemId);  
        Task<ReportSystem> GetReceiverReportSystemById (int reportId);
        Task UpdateReportFromService (ReportSystem reportSystem);
        Task<IEnumerable<ReportSystem>> GetSenderReportSystems (int senderId);
        Task<IEnumerable<ReportSystem>> GetAllReceiverReport(int receiverId);   
    }
}
