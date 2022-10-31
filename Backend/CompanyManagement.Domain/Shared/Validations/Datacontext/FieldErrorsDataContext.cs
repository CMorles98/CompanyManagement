using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class FieldErrorsDataContext
    {
        public FieldErrorsDataContext()
        {
            Errors = new List<KeyValueDataContext>();
        }

        public string Field { get; set; }

        public IEnumerable<KeyValueDataContext> Errors { get; set; }
    }
}
