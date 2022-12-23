using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Employees.Queries.GetEmployeeById
{
    public class GetEmployeesByIdQueryValidator:AbstractValidator<GetEmployeesByIdQuery>
    {
        public GetEmployeesByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull().WithMessage("يجب ادخال كود موظف");
        }
    }
}
