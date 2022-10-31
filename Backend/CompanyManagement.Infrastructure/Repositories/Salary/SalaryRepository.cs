using AutoMapper;
using CompanyManagement.Domain.DTOs.Salary;
using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.DTOs.Salary.Response;
using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Repositories;
using CompanyManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Repositories
{
    public class SalaryRepository : BaseRepository<Salary>, ISalaryRepository
    {
        public SalaryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Salary>> GetAllAsync(GetAllSalaryParametersDTO parameters) =>
                await FindAll(false)
                        //.Skip((parameters.pageNumber - 1) * parameters.pageSize)
                        //.Take(parameters.pageSize)
                        .Where(s => parameters.Grade.Equals(null) ? true : s.Grade.Equals(parameters.Grade) &&
                                    parameters.OfficeId.Equals(null) ? true : s.OfficeId.Equals(parameters.OfficeId) &&
                                    parameters.PositionId.Equals(null) ? true : s.PositionId.Equals(parameters.PositionId))
                        .Include(s => s.Division)
                        .Include(s => s.Position)
                        .ToListAsync();

        public async Task<IEnumerable<Salary>> GetAllGroupedByEmployeeAsync(GetAllSalaryParametersDTO parameters) =>
            FindAll(false)
                          .Include(s => s.Division)
                          .Include(s => s.Position)
                          .ToList()
                          .OrderByDescending(s => s.Year)
                          .ThenByDescending(s => s.Month)
                          .GroupBy(s => s.EmployeeCode)
                          .Select(s => s.FirstOrDefault())
                          //.Skip((parameters.pageNumber - 1) * parameters.pageSize)
                          .Take(parameters.pageSize)
                          .Where(s => parameters.Grade.Equals(null) ? true : s.Grade.Equals(parameters.Grade) &&
                                      parameters.OfficeId.Equals(null) ? true : s.OfficeId.Equals(parameters.OfficeId) &&
                                      parameters.PositionId.Equals(null) ? true : s.PositionId.Equals(parameters.PositionId));

        public async Task<Salary> GetById(int id) =>
            await FindSingleByCondition(s => s.Id.Equals(id), false);


        public async Task<Salary> GetByCondition(string identificationNumber) =>
            await FindSingleByCondition(s => s.IdentificationNumber.Equals(identificationNumber), false);


        public async Task<int> CreateSalary(Salary input)
        {
            Create(input);
            await SaveChanges();
            return input.Id;
        }
        public async Task<bool> CheckIfExists(int year, int month, string identificationNumber, string employeeCode) =>
                await CheckAnyByCondition(o => year.Equals(null) ? true : o.Year.Equals(year) &&
                                       month.Equals(null) ? true : o.Month.Equals(month) &&
                                       string.IsNullOrEmpty(employeeCode) ? true : o.EmployeeCode.Equals(employeeCode) &&
                                       string.IsNullOrEmpty(identificationNumber) ? true : o.IdentificationNumber.Equals(identificationNumber));

        public async Task<GetSalaryRecordCounterDTO> GetCountOfSalaries() => 
            new GetSalaryRecordCounterDTO()
            {
                GroupedByEmployee = FindAll(false)
                          .Include(s => s.Division)
                          .Include(s => s.Position)
                          .ToList()
                          .OrderByDescending(s => s.Year)
                          .ThenByDescending(s => s.Month)
                          .GroupBy(s => s.EmployeeCode)
                          .Select(s => s.FirstOrDefault())
                          .Count(),
                Single = FindAll(false).Count()
            };
    }
}