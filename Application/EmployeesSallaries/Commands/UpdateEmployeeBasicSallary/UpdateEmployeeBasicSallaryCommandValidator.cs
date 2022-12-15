using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary
{
    public class UpdateEmployeeBasicSallaryCommandValidator:AbstractValidator<UpdateEmployeeBasicSallaryCommand>
    {
        public UpdateEmployeeBasicSallaryCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(P => P.FinancialYearId).NotEmpty().NotNull();
            RuleFor(P => P.Id).NotEmpty().NotNull();
           
        }
    }
}
