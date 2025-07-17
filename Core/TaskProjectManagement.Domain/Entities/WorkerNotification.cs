using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class WorkerNotification
    {
        public int WorkerNotificationId { get; set; }
        public int UserId { get; set; }
        public CompanyLeader User { get; set; }
        public int NotificationsId { get; set; }
        public Notifications Notifications { get; set; }
    }
}
