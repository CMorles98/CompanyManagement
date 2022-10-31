using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Entities
{
    public class Position: BaseEntity
    {
        public string PositionName { get; set; }

        public int? DivisionId { get; set; }

        public Division Division { get; set; }
    }
}
