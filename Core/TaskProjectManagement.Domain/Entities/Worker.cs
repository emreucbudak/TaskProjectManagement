using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Demand>? Demands { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public bool IsAvailable { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<WorkerNotification> Notifications { get; set; }

    }
}
