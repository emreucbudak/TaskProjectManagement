using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Application.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
       public IDemandRepository demandRepository { get; }
       public IMissionRepository missionRepository { get; }
       public INotificationRepository notificationRepository { get; }
        public ISubTaskRepository subTaskRepository { get; }
        public ITeamRepository teamRepository { get; }
        public ICompanyRepository companyRepository { get; }
        public ICompanyRequestRepository companyRequestRepository { get; }
        public IOtherWorkerRepository otherWorkerRepository { get; }
        public IReportSystemRepository reportSystemRepository { get; }  
        public ISystemOwnerRepository systemOwnerRepository { get; }
        public ITeamLeaderRepository eamLeaderRepository { get; }
        public IWorkerNotificationRepository workerNotificationRepository { get; }
        public IWorkerRepository   workerRepository { get; }
        public IUserRepository userRepository { get; }
        public Task saveChangesAsync();
    }
}
