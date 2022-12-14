using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands.RegisterEmployee
{
    public class RegisterNewEmployeeCommandValidator : AbstractValidator<EmployeeDto>
    {
        public RegisterNewEmployeeCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("لا يمكن ترك الخانه فارغه")
                .NotNull()
                .MaximumLength(150);

            RuleFor(p => p.TabCode)
            .NotEmpty()
            .NotNull();


            RuleFor(p => p.NationalId)
            .NotEmpty()
            .NotNull()
            .Length(14).WithMessage("يجب عليك ادخال 14 رقم ");



            RuleFor(p => p)
               .Must(x => x.Name != null && x.NationalId != null).WithMessage("لا يمكن ترك الخليه فارغه");
            RuleFor(p => p.Name)
                .MaximumLength(150).WithMessage("لا يمكن ان يزيد عن 150 حرف");

            RuleFor(p => p.TabCode)
               .MaximumLength(5).WithMessage("لا يمكن ان يزيد عن 5 حرف");

            RuleFor(p => p.TegaraCode)
               .MaximumLength(5).WithMessage("لا يمكن ان يزيد عن 5 حرف");

            RuleFor(p => p.CollageName)
                .MaximumLength(20).WithMessage("لا يمكن ان يزيد عن 20 حرف");

            RuleFor(p => p.Section)
              .MaximumLength(20).WithMessage("لا يمكن ان يزيد عن 20 حرف");

        }
    }
}
