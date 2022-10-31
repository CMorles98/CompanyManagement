using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class KeyValueDataContext
    {
        public string Key { get; set; }

        public IEnumerable<string> Value { get; set; }
    }
}
