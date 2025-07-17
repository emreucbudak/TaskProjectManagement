using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProjectManagement.Domain.Errors;

namespace TaskProjectManagement.Persistence.Errors
{
    public class CompanyNotFoundException : ItemNotFoundException
    {
        public CompanyNotFoundException(string message) : base(message)
        {
        }
    }
}
