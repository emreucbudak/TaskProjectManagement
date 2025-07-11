using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class SubTaskStatus
    {
        [Key]
        public int SubStatusId { get; set; }
        public string Status { get; set; }

    }
}
