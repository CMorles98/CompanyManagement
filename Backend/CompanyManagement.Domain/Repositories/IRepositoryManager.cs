using CompanyManagement.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Repositories
{
    public interface IRepositoryManager
    {
        IDivisionRepository DivisionRepository { get; }
        IOfficeRepository   OfficeRepository { get; }
        IPositionRepository PositionRepository { get; }
        ISalaryRepository   SalaryRepository { get; }
    }
}
