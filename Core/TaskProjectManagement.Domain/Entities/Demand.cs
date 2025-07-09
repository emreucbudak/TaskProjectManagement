using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Demand
    {
        public int DemandId { get; set; }
        public string DemandTitle { get; set; }
        public string DemandDescription { get; set; }
        public int StatusId { get; set; }
        public DemandStatus Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
