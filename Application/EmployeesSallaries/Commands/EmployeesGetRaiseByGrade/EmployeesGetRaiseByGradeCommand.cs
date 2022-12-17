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

namespace Application.EmployeesSallaries.Commands.EmployeesGetRaiseByGrade
{
    public record EmployeesGetRaiseByGradeCommand(
            int gradeId,
            int newFinancialYearId,
            decimal? wazifiPercentage,
            decimal? wazifiAmount,
            decimal? wazifiMinAmount,
            decimal? wazifiMaxAmount,
            decimal? mokamelPercentage,
            decimal? mokamelAmount,
            decimal? mokamelMinAmount,
            decimal? mokamelMaxAmount

        ) : IRequest<Result<Unit>>;

    public class EmployeesGetRaiseByGradeCommandHandler : Handler<EmployeesGetRaiseByGradeCommand, Result<Unit>>
    {
        public EmployeesGetRaiseByGradeCommandHandler(IUOW uow) : base(uow)
        {
        }

        public async override Task<Result<Unit>> Handle(EmployeesGetRaiseByGradeCommand request, CancellationToken cancellationToken)
        {
            var employees = await _uow.EmployeeGradeRepository.GetEmployeeInSpecificGradeId(request.gradeId);
            if (employees == null)
            {
                Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            foreach (var employee in employees)
            {
             var employeeNewSallary=   await _uow.EmployeeBasicSallaryRepository.EmployeeGetRaise(employee.Id, request.newFinancialYearId, request.wazifiPercentage, request.wazifiAmount, request.wazifiMinAmount
                    , request.wazifiMaxAmount, request.mokamelPercentage, request.mokamelAmount, request.mokamelMinAmount, request.mokamelMaxAmount);

                await _uow.EmployeeBasicSallaryRepository.AddItem(employeeNewSallary);
            }
            var saveResult = await _uow.SaveChangesAsync(cancellationToken) > 0;

            if (!saveResult) {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return new Result<Unit>();
        }
    }
}
