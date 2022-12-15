using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeOrders.Queries.EmployeeOrderDeductionBalance
{
    public class EmployeeOrderDeductionBalanceQueryValidator:AbstractValidator<EmployeeOrderDeductionBalanceQuery>
    {
        public EmployeeOrderDeductionBalanceQueryValidator()
        {
            RuleFor(p => p.employeeId).NotEmpty().NotNull();
        }
    }
}
