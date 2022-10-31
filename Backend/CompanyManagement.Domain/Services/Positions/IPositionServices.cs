using CompanyManagement.Domain.DTOs.Position;
using CompanyManagement.Domain.DTOs.Position.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Positions
{
    public interface IPositionServices
    {
        Task<IEnumerable<GetRequestPositionDTO>> GetAll();
    }
}
