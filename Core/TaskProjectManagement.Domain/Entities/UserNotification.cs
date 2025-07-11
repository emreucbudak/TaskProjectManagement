using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class UserNotification
    {
        [Key]
        public int UserId { get; set; }
        public User User { get; set; }

        public int NotificationId { get; set; }
        public Notifications Notification { get; set; }

       
    }
}
