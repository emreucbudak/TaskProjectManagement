using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Entities;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IReportSystemRepository
    {
        Task AddReportFromRepo(ReportSystem reportSystem);
        Task CloseReportFromRepo (ReportSystem reportSystem);
        Task DeleteReportFromRepo (ReportSystem reportSystem);
        Task UpdateReportFromRepo (ReportSystem reportSystem);
        Task<IEnumerable<ReportSystem>> GetSenderReportFromRepo(int userId);
        Task<ReportSystem> GetReceiverReportFromRepo(int reportId,int receiverId);
        Task<IEnumerable<ReportSystem>> GetAllReportsFromRepo(int receiverId);
        Task<ReportSystem> GetPostForDeleteFromRepository(int postId);
        Task<ReportSystem> GetPostForUpdateFromRepository(int postId);
    }
}
