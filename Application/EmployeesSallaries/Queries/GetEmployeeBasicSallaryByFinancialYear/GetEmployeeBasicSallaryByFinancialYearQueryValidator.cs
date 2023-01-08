using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear
{
    public class GetEmployeeBasicSallaryByFinancialYearQueryValidator :AbstractValidator<GetEmployeeBasicSallaryQuery>
    {
        public GetEmployeeBasicSallaryByFinancialYearQueryValidator()
        {
            RuleFor(p => p.EmployeeId).NotNull().NotEmpty();
         //   RuleFor(p => p.FinancialYearId).NotNull().NotEmpty();
        }
    }
}
