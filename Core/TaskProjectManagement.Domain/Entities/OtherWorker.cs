using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class OtherWorker
    {
        public int OtherWorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerPassword { get; set; }
        public int RolesId  { get; set; }
        public Roles Roles { get; set; }
        public ICollection<ReportSystem>? ReportSystems { get; set; }
        public int CompanyId { get; set; }
        public Company Company  { get; set; }
    }
}
