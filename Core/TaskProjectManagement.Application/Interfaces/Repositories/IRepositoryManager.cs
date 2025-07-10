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
        public ITeamMemberRepository teamMemberRepository { get; }
        public ITeamRepository teamRepository { get; }
        public IUserNotificationRepository userNotificationRepository { get; }
        public IUserRepository userRepository { get; }
        public Task saveChangesAsync();
    }
}
