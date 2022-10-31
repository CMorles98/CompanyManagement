using CompanyManagement.Domain.DTOs.Office;
using CompanyManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Offices
{
    public interface IOfficeServices
    {
        Task<IEnumerable<OfficeDTO>> GetAll();
    }
}
