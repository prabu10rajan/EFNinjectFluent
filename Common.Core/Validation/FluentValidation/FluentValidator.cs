using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.Validation.FluentValidation
{
    public static class FluentValidator
    {
        public static void FluentValidate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if(!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
