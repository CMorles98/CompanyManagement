using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class BaseValidator
    {
        protected ValidationErrorsDataContext validationResult;

        public BaseValidator()
        {
            validationResult = new ValidationErrorsDataContext();
        }

        public bool IsSuccess => validationResult.HasErrors() == false;

        public ValidationResultDataContext ValidationResult()
        {
            if (validationResult.FieldErrors.Any())
                validationResult.FieldErrors = validationResult.FieldErrors
                    .GroupBy(x => x.Field).Select(group => new FieldErrorsDataContext
                    {
                        Field = @group.Key,
                        Errors = @group.SelectMany(x => x.Errors).ToList()
                    }).ToList();


            return new ValidationResultDataContext
            {
                Success = IsSuccess,
                ValidationResult = validationResult
            };
        }
    }
}
