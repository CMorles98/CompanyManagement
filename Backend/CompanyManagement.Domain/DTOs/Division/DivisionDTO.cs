using CompanyManagement.Domain.DTOs.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Division
{
    public class DivisionDTO: BaseEntityDTO
    {
        public string DivisionName { get; set; }
        public IEnumerable<PositionDTO> Positions { get; set; }
    }
}
