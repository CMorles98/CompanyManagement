using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class ValidationResultDataContext
    {
        public ValidationResultDataContext()
        {
            ValidationResult = new ValidationErrorsDataContext();
            AffectedIDs = new List<long>();
        }

        public ValidationErrorsDataContext ValidationResult { get; set; }

        public IList<long> AffectedIDs { get; set; }

        public bool Success { get; set; }

        public void AddAffectedId(int id)
        {
            AffectedIDs.Add(id);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
