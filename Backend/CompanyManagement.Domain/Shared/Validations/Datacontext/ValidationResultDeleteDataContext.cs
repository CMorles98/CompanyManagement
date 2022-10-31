using CompanyManagement.Domain.Shared.Validations.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class ValidationResultDeleteDataContext : ValidationResultDeleteDataContextBase<long>
    {
        public ValidationResultDeleteDataContext(ValidationResultDataContext validationResult) : base(validationResult)
        {
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
