using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProjectManagement.Domain.DTOS
{
    public record CompanyDTO
    {
        public string CompanyName { get; init; }
        public string CompanyLogo { get; init; }
        public bool IsClosed { get; init; }
        public int CompanyMemberCount { get; init; }
    }
}
