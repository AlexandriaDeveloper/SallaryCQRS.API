using Application.Common;
using Application.DTOS.EmploueeOrdersDtos;
using Application.EmployeeOrders.Queries.GetEmployeeOrderData;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands.AssignEmployeeBasicSallary
{

    public record AssignEmployeeBasicSallaryCommand(int EmployeeId, int FinancialYearId, decimal BasicSallary, decimal Wazifi=0, decimal Mokamel=0, decimal Ta3widi=0) : IRequest<Result<int>>;

    public class AssignEmployeeBasicSallaryCommandHandler : Handler<AssignEmployeeBasicSallaryCommand, Result<int>>
    {


        public AssignEmployeeBasicSallaryCommandHandler(IUOW uow) : base(uow)
        {

        }
        public override async Task<Result<int>> Handle(AssignEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {

            var validation = new AssignEmployeeBasicSallaryCommandValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<int>.Failure(validate.Errors.First().ErrorMessage);
            }

            EmployeeBasicSallary employeeBasicSallary = new EmployeeBasicSallary()
            {
                EmployeeId = request.EmployeeId,
                BasicSallary = request.BasicSallary,
                Wazifi = request.Wazifi,
                Mokamel = request.Mokamel,
                Ta3widi = request.Ta3widi,
                FinancialYearId = request.FinancialYearId,
            };
            await _uow.EmployeeBasicSallaryRepository.AddItem(employeeBasicSallary);
            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!result)
                return Result<int>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            return Result<int>.Success(employeeBasicSallary.EmployeeId);

        }


    }


}
