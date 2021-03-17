using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HPoc.Web.Validators
{
    public class FluentValueValidator<T> : AbstractValidator<T>
    {
        public FluentValueValidator(Action<IRuleBuilderInitial<T, T>> rule)
        {
            rule(RuleFor(x => x));
        }

        private IEnumerable<string> ValidateValue(T arg)
        {
            if (arg != null)
            {
                var result = Validate(arg);
                if (result.IsValid)
                    return Array.Empty<string>();
                return result.Errors.Select(e => e.ErrorMessage);
            }
            return Enumerable.Empty<string>();
        }

        public Func<T, IEnumerable<string>> Validation => ValidateValue;
    }


    public static class ValidatorExtension
    {

    }
}
