using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.Errors
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string? message) : base(message)
        {
        }
    }
}
