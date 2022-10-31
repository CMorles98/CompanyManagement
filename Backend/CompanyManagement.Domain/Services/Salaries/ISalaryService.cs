using CompanyManagement.Domain.DTOs.Salary;
using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.DTOs.Salary.Response;
using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Shared.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Services.Salaries
{
    public interface ISalaryService
    {
        Task<IEnumerable<GetRequestSalaryDTO>> GetAll(GetAllSalaryParametersDTO parameters);
        Task<IEnumerable<GetRequestSalaryDTO>> GetAllGroupedByEmployee(GetAllSalaryParametersDTO parameters);
        Task<GetByIdRequestSalaryDTO> GetById(int id);
        Task<GetSalaryRecordCounterDTO> GetCountOfSalaries();
        Task<ValidationResultDataContext> Create(IEnumerable<SalaryForCreationDTO> dto);
    }
}
