using Application.Common;
using Application.Employees.Queries;
using Application.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear
{
    public record GetEmployeeBasicSallaryByFinancialYearQuery(int? EmployeeId, int? FinancialYearId) : IRequest<Result<EmployeeBasicSallary>>;
    public class GetEmployeeBasicSallaryByFinancialYearQueryHandler : Handler<GetEmployeeBasicSallaryByFinancialYearQuery, Result<EmployeeBasicSallary>>
    {
        public GetEmployeeBasicSallaryByFinancialYearQueryHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<EmployeeBasicSallary>> Handle(GetEmployeeBasicSallaryByFinancialYearQuery request, CancellationToken cancellationToken)
        {


            var validation = new GetEmployeeBasicSallaryByFinancialYearQueryValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<EmployeeBasicSallary>.Failure(validate.Errors.First().ErrorMessage);
            }
            ISpecification<EmployeeBasicSallary> spec = new GetEmployeeBasicSallaryByFinancialYearSpecification(request);


            var result = await _uow.EmployeeBasicSallaryRepository.GetBySingleOrDefaultAsync(spec);
            if (result == null) {

                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            return Result<EmployeeBasicSallary>.Success(result);
        }
    }


}
