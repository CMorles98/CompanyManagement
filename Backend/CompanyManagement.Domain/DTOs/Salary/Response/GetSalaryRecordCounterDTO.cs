using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.DTOs.Salary.Response
{
    public class GetSalaryRecordCounterDTO
    {
        public int GroupedByEmployee { get; set; }
        public int Single { get; set; }
    }
}
