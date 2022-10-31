using CompanyManagement.Domain.DTOs.Salary;
using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.Repositories;
using CompanyManagement.Domain.Shared.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class SalaryValidator : BaseValidator, ISalaryValidator
    {
        private readonly IRepositoryManager _repository;
        public SalaryValidator(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<ValidationResultDataContext> ValidateOnCreate(IEnumerable<SalaryForCreationDTO> dto)
        {
            validationResult.Clear();

            foreach (var salary in dto)
            {
                var record = await _repository.SalaryRepository.CheckIfExists((int)salary.Year, (int)salary.Month, salary.IdentificationNumber, salary.EmployeeCode);

                if (record)
                {
                    validationResult.AddGlobalError($"This record already exists in the database.");
                    break;
                }
                continue;

            }

            return await Task.FromResult(ValidationResult());
        }

    }
}
