using CompanyManagement.Domain.DTOs.Division;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Position
{
    public class PositionDTO: BaseEntityDTO
    {
        public string PositionName { get; set; }
        public int DivisionId { get; set; }
    }
}
