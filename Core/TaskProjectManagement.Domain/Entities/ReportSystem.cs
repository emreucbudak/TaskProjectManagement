using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class ReportSystem
    {
        public int ReportId { get; set; }
        public string ReportTitle   { get; set; }
        public string ReportTopic { get; set; }
        public string ReportDescription { get; set; }
        public bool IsClosed { get; set; }
        public int OtherWorkerId { get; set; }
        public OtherWorker OtherWorker { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; } 

    }
}
