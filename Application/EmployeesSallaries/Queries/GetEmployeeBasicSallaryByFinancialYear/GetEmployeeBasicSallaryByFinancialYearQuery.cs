using Domain.Shared;
using Domain.Employees.Queries;
using Domain.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary;
using Domain.Interfaces;
using Domain.Common;
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
    public record GetEmployeeBasicSallaryByFinancialYearQuery(int? EmployeeId, int? FinancialYearId) : IQuery<EmployeeBasicSallary>;
    public class GetEmployeeBasicSallaryByFinancialYearQueryHandler : IQueryHandler<GetEmployeeBasicSallaryByFinancialYearQuery, EmployeeBasicSallary>
    {
        private readonly IUOW _uow;

        public GetEmployeeBasicSallaryByFinancialYearQueryHandler(IUOW uow)
        {
            _uow = uow;
        }

        public  async Task<Result<EmployeeBasicSallary>> Handle(GetEmployeeBasicSallaryByFinancialYearQuery request, CancellationToken cancellationToken)
        {


            //var validation = new GetEmployeeBasicSallaryByFinancialYearQueryValidator();
            //var validate = await validation.ValidateAsync(request, cancellationToken);
            //if (!validate.IsValid)
            //{
            //    return Result<EmployeeBasicSallary>.Failure(validate.Errors.First().ErrorMessage);
            //}
            ISpecification<EmployeeBasicSallary> spec = new GetEmployeeBasicSallaryByFinancialYearSpecification(request);


            var result = await _uow.EmployeeBasicSallaryRepository.GetBySingleOrDefaultAsync(spec);
            if (result == null) {

                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            return Result<EmployeeBasicSallary>.Success(result);
        }
    }


}
