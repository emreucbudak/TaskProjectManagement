using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Notifications
    {
        public int NotificationId { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationTopic { get; set; }
        public string NotificationText { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
