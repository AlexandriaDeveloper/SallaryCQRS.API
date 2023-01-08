using Domain.Shared;
using Domain.Constants;
using Domain.Employees.Queries;
using Domain.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;

namespace Domain.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear
{
    public record GetEmployeeBasicSallaryQuery(int? EmployeeId, int? FinancialYearId) : IQuery<PagedList< EmployeeBasicSallary>>;
    public class GetEmployeeBasicSallaryByFinancialYearQueryHandler : IQueryHandler<GetEmployeeBasicSallaryQuery, PagedList<EmployeeBasicSallary>>
    {
        private readonly IUOW _uow;

        public GetEmployeeBasicSallaryByFinancialYearQueryHandler(IUOW uow)
        {
            _uow = uow;
        }

        public  async Task<Result<PagedList<EmployeeBasicSallary>>> Handle(GetEmployeeBasicSallaryQuery request, CancellationToken cancellationToken)
        {
            ISpecification<EmployeeBasicSallary> spec = new GetEmployeeBasicSallaryByFinancialYearSpecification(request);


            var result = await _uow.EmployeeBasicSallaryRepository.GetBySingleOrDefaultAsync(spec);
            if (result == null) {

                return Result<PagedList<EmployeeBasicSallary>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            return Result<EmployeeBasicSallary>.Success(result);
        }
    }


}
