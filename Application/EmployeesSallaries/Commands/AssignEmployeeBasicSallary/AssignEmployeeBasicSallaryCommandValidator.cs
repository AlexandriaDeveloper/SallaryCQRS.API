using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands.AssignEmployeeBasicSallary
{
    public class AssignEmployeeBasicSallaryCommandValidator:AbstractValidator<AssignEmployeeBasicSallaryCommand>
    {
        public AssignEmployeeBasicSallaryCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(p => p.EmployeeId).NotNull().NotEmpty();
            RuleFor(p => p.FinancialYearId).NotNull().NotEmpty();
            RuleFor(p => p.Wazifi).NotNull().NotEmpty();
            RuleFor(p => p.Mokamel).NotNull().NotEmpty();
            RuleFor(p => p.Ta3widi).NotNull().NotEmpty();
        }
    }
}
