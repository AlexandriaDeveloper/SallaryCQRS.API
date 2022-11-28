using Application.Common;
using Application.Employees.Queries;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Queries
{
    public record GetEmployeeBasicSallaryByFinancialYearQuery (Guid? EmployeeId,Guid? FinancialYearId) :IRequest<EmployeeBasicSallary>;
    public class GetEmployeeBasicSallaryByFinancialYearQueryHandler : Handler<GetEmployeeBasicSallaryByFinancialYearQuery, EmployeeBasicSallary>
    {
        public GetEmployeeBasicSallaryByFinancialYearQueryHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<EmployeeBasicSallary> Handle(GetEmployeeBasicSallaryByFinancialYearQuery request, CancellationToken cancellationToken)
        {
            ISpecification<EmployeeBasicSallary> spec = new GetEmployeeBasicSallaryByFinancialYearSpecification(request);
            
            return await _uow.EmployeeBasicSallaryRepository.GetBySingleOrDefaultAsync(spec) ;
        }
    }


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
