using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Utils
{
    public static class RuleBuilderExtension
    {
        public static IRuleBuilder<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder, int minimumLength = 14)
        {
            var options = ruleBuilder
                .NotEmpty();

            return options;
        }


    }
}
