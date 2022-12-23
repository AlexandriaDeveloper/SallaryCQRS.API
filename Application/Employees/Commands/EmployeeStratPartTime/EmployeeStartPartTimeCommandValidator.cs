using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employees.Commands.EmployeeStratPartTime
{
    public class EmployeeStartPartTimeCommandValidator : AbstractValidator<EmployeeStartPartTimeCommand>
    {
        public EmployeeStartPartTimeCommandValidator()
        {
            RuleFor(p =>p.EmployeeId).NotNull().NotEmpty().WithMessage("يجب ادخال كود الموظف");
            RuleFor(p => p.StartPartTime).NotNull().NotEmpty().WithMessage("يجب ادخال تاريح بدء جزء من الوقت");
        }
    }
}
