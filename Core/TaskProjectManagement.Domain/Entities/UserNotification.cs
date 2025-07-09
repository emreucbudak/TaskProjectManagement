using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class UserNotification
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int NotificationId { get; set; }
        public Notifications Notification { get; set; }

        public bool IsRead { get; set; } = false;
    }
}
