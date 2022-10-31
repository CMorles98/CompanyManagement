using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Utils
{
    public static class MappingUtils
    {
        public static decimal GetTotalSalary( decimal baseSalary,
                                              decimal commission,
                                              decimal productionBonus,
                                              decimal compesationBonus,
                                              decimal contributions) 
        {

            var OtherIncome = (baseSalary + commission) * ((decimal)0.08) + commission;
            return baseSalary + productionBonus + (compesationBonus * (decimal)0.75) + OtherIncome - contributions;
        }
    }
}
