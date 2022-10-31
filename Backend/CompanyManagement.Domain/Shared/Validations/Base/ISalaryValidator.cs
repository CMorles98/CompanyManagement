using CompanyManagement.Domain.DTOs.Salary;
using CompanyManagement.Domain.DTOs.Salary.Request;
using CompanyManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations.Base
{
    public interface ISalaryValidator : IValidatorCreate<IEnumerable<SalaryForCreationDTO>>
    {
    }
}
