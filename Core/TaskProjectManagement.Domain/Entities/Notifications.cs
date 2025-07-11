using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Notifications
    {
        [Key]
        public int NotificationId { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationText { get; set; }

        public ICollection<UserNotification> UserNotifications { get; set; }
    }
}
