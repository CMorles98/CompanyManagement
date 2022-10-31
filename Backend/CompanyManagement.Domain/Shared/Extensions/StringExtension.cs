using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Extensions
{
    public static class StringExtension
    {
        public static string ToCamelCase(this string item)
        {
            if (item.Length > 1)
            {
                return char.ToLowerInvariant(item[0]) + item.Substring(1);
            }

            return item;
        }
    }
}
