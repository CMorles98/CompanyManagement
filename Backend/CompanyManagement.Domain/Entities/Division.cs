using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Entities
{
    public class Division : BaseEntity
    {
        public string DivisionName { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}
