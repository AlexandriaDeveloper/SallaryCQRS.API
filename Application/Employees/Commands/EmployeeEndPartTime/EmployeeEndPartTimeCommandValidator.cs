using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employees.Commands.EmployeeEndPartTime
{
    public class EmployeeEndPartTimeCommandValidator:AbstractValidator<EmployeeEndPartTimeCommand>
    {
        public EmployeeEndPartTimeCommandValidator()
        {
            RuleFor(p => p.PartTimeId).NotEmpty().NotNull();
            RuleFor(p => p.EndPartTimeDate).NotEmpty().NotNull();
            RuleFor(p => p.Details).MaximumLength(200);
        }
    }
}
