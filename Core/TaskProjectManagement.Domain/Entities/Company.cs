using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName   { get; set; }
        public string CompanyLogo { get; set; }
        public int CompanyMemberCount { get; set; }
        public ICollection<Worker>? Worker { get; set; }
        public ICollection<TeamLeader>? TeamLeader { get; set; }
        public ICollection<CompanyLeader>? User { get; set; }
        public ICollection<OtherWorker>? Other { get; set; }


    }
}
