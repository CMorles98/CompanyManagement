using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Salary.Response
{
    public class GetRequestSalaryDTO: BaseEntityDTO
    {
        public string EmployeeFullName { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeDivision { get; set; }
        public string EmployeePosition { get; set; }
        public int Grade { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime Birthday { get; set; }
        public string IdentificationNumber { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
