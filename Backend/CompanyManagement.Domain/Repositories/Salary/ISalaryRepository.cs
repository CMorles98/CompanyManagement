using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.DTOs.Salary.Response;
using CompanyManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace CompanyManagement.Domain.Repositories
{
    public interface ISalaryRepository: IBaseRepository<Salary>
    {
        Task<IEnumerable<Salary>> GetAllAsync(GetAllSalaryParametersDTO parameters);

        Task<IEnumerable<Salary>> GetAllGroupedByEmployeeAsync(GetAllSalaryParametersDTO parameters);

        Task<Salary> GetByCondition(string identificationNumber);

        Task<Salary> GetById(int id);

        Task<int> CreateSalary(Salary input);

        Task<bool> CheckIfExists(int year, int month, string identificationNumber, string employeeCode);

        Task<GetSalaryRecordCounterDTO> GetCountOfSalaries();

    }
}
