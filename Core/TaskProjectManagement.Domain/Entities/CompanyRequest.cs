using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class CompanyRequest
    {
        public int RequestId    { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public int CompanyLeaderId {  get; set; }
        public CompanyLeader CompanyLeader { get; set; }


    }
}
