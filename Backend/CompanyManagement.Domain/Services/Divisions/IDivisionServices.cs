using CompanyManagement.Domain.DTOs.Division;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Divisions
{
    public interface IDivisionServices
    {
        Task<IEnumerable<DivisionDTO>> GetAll();
    }
}
