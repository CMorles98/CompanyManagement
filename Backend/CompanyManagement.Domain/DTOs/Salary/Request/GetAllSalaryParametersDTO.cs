using CompanyManagement.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Salary.Request
{
    public class GetAllSalaryParametersDTO: RequestParameters
    {
        public int? Grade { get; set; }
        public int? OfficeId { get; set; }
        public int? PositionId { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string EmployeeCode { get; set; }

    }
}
