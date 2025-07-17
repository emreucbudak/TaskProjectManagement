using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Entities
{
    public class CompanyLeader
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname   { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public ICollection<Worker>? CreatedWorkers { get; set; }
        



    }
}
