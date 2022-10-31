using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Shared.Validations.Base
{
    public interface IValidatorCreate<E> where E : class
    {
        Task<ValidationResultDataContext> ValidateOnCreate(E entity);
    }
}
