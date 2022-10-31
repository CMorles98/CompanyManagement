using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations.Base
{
    public class ValidationResultDeleteDataContextBase<T> where T : IComparable
    {
        private readonly ValidationResultDataContext validationResult;

        public ValidationResultDeleteDataContextBase(ValidationResultDataContext validationResult)
        {
            this.validationResult = validationResult;
            AffectedDeleteIDs = new List<T>();
        }

        public ValidationErrorsDataContext ValidationResult => validationResult.ValidationResult;

        public IList<T> AffectedDeleteIDs { get; set; }

        public bool Success
        {
            get
            {
                return validationResult.Success;
            }
        }

        public void AddAffectedDeleteId(T id)
        {
            AffectedDeleteIDs.Add(id);
        }
    }
}
