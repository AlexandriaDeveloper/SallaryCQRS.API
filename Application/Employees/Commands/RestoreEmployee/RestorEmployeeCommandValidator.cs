using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employees.Commands.RestoreEmployee
{
    public class RestorEmployeeCommandValidator : AbstractValidator<RestorEmployeeCommand>
    {
        public RestorEmployeeCommandValidator()
        {
            RuleFor(p => p.id)
                .NotEmpty().NotNull().WithMessage("يجب ادخال كود");
        }
    }
}
