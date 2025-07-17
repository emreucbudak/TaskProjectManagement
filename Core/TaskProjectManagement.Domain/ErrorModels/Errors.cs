using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.ErrorModels
{
    public class Errors
    {
        public int ErrorStatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
