using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Position.Response
{
    public class GetRequestPositionDTO: BaseEntityDTO
    {
        public string PositionName { get; set; }
    }
}
