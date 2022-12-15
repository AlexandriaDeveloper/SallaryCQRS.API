using Application.Common;
using Domain.Models;

namespace Application.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear
{
    public class GetEmployeeBasicSallaryByFinancialYearSpecification : Specification<EmployeeBasicSallary>
    {
        public GetEmployeeBasicSallaryByFinancialYearSpecification(GetEmployeeBasicSallaryByFinancialYearQuery param) : base()
        {
            if (param.EmployeeId.HasValue)
            {
                AddCriteries(x => x.EmployeeId.Equals(param.EmployeeId));
            }
            if (param.FinancialYearId.HasValue)
            {
                AddCriteries(x => x.FinancialYearId.Equals(param.FinancialYearId));
            }

        }
    }


}
