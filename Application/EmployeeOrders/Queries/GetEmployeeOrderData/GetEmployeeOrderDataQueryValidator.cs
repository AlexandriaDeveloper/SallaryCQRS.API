using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeOrders.Queries.GetEmployeeOrderData
{
    public class GetEmployeeOrderDataQueryValidator :AbstractValidator<GetEmployeeOrdersDataQuery>
    {
        public GetEmployeeOrderDataQueryValidator()
        {
            RuleFor(x => x.EmployeeId).NotNull().NotEmpty();
            RuleFor(x => x.OrderId).NotNull().NotEmpty();
        }
    }
}
