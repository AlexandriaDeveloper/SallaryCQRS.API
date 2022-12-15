using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands.EmployeeGetRaise
{
    public class EmployeeGetRaiseCommandValidator:AbstractValidator<EmployeeGetRaisedCommand>
    {
        public EmployeeGetRaiseCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(p => p.newFinancialYear).NotEmpty().NotNull();
            RuleFor(p=>p.EmployeeSallaryId).NotEmpty().NotNull();
        }
    }
}
