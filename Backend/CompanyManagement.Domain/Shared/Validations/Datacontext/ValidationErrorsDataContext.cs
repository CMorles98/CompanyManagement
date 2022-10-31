using CompanyManagement.Domain.Shared.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations
{
    public class ValidationErrorsDataContext
    {
        public ValidationErrorsDataContext()
        {
            FieldErrors = new List<FieldErrorsDataContext>();
            GlobalErrors = new List<KeyValueDataContext>();
        }

        public IList<FieldErrorsDataContext> FieldErrors { get; set; }

        public IList<KeyValueDataContext> GlobalErrors { get; set; }

        public void AddFieldError(string field, string key, IList<string> value = null)
        {
            var fieldErrors = new FieldErrorsDataContext
            {
                Field = field.ToCamelCase(),
                Errors = new List<KeyValueDataContext>
                        {
                            new KeyValueDataContext
                            {
                                Key = key,
                                Value = value
                            }
                        }
            };

            FieldErrors.Add(fieldErrors);
        }

        public void AddGlobalError(string key, IList<string> value = null)
        {
            GlobalErrors.Add(new KeyValueDataContext
            {
                Key = key,
                Value = value
            });
        }

        public void Clear()
        {
            FieldErrors.Clear();
            GlobalErrors.Clear();
        }

        public bool HasErrors()
        {
            return FieldErrors.Any() || GlobalErrors.Any();
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
