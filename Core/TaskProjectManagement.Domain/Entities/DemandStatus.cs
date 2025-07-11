using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class DemandStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string Status {  get; set; }
        public ICollection<Demand> Demands { get; set; }

    }
}
