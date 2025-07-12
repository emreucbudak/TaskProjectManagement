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
        public bool IsConfirmed { get; set; }
        public int teamLeaderId { get; set; }
        public TeamLeader teamLeader { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
