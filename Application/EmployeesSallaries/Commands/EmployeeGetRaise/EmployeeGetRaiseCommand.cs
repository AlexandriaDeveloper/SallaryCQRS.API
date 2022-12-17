using Application.Common;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands.EmployeeGetRaise
{
    public record EmployeeGetRaisedCommand(
             int employeeId,
             int newFinancialYear,
            decimal? wazifiPercentage,
            decimal? wazifiAmount,
            decimal? wazifiMinAmount,
            decimal? wazifiMaxAmount,
            decimal? mokamelPercentage,
            decimal? mokamelAmount,
            decimal? mokamelMinAmount,
            decimal? mokamelMaxAmount

        ) : IRequest<Result<EmployeeBasicSallary>>;
    public class EmployeeGetRaisedCommandHandler : Handler<EmployeeGetRaisedCommand, Result<EmployeeBasicSallary>>
    {
        public EmployeeGetRaisedCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<EmployeeBasicSallary>> Handle(EmployeeGetRaisedCommand request, CancellationToken cancellationToken)
        {
            var result = await _uow.EmployeeBasicSallaryRepository.EmployeeGetRaise(
                request.employeeId,
                 request.newFinancialYear,
                 request.wazifiPercentage,
                 request.wazifiAmount,
                 request.wazifiMinAmount,
                 request.wazifiMaxAmount,
                 request.mokamelPercentage, request.mokamelAmount, request.mokamelMinAmount, request.mokamelMaxAmount);


            await _uow.EmployeeBasicSallaryRepository.AddItem(result);
                  var saveResult = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!saveResult) {

                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }

            if (result == null)
            {
                return Result<EmployeeBasicSallary>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            return Result<EmployeeBasicSallary>.Success(result);
        }
    }
}
