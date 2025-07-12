using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Application.Interfaces.Services
{
    public interface IServiceManager
    {
        public IDemandServices demand { get; }
        public IMissionService mission { get; }
        public INotificationsService notificationsService { get; }
        public ISubtaskServices subtask { get; }
        public ITeamService teamService { get; }
    
        public IUserServices users { get; }
    }
}
