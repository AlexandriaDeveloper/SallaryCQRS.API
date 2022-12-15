using Application.Common;
using Application.DTOS.EmploueeOrdersDtos;
using Application.EmployeeOrders.Queries.GetEmployeeOrderData;
using Application.Employees.Commands.UpdateEmployeeInfo;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary
{
    public record UpdateEmployeeBasicSallaryCommand(int Id, int? FinancialYearId, decimal? BasicSallary, decimal? Wazifi, decimal? Mokamel, decimal? Ta3widi) : IRequest<Result<Unit?>>;

    public class UpdateEmployeeBasicSallaryCommandHandler : Handler<UpdateEmployeeBasicSallaryCommand, Result<Unit?>?>
    {
        public UpdateEmployeeBasicSallaryCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<Unit?>> Handle(UpdateEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {

            var validation = new UpdateEmployeeBasicSallaryCommandValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<Unit?>.Failure(validate.Errors.First().ErrorMessage);
            }
            EmployeeBasicSallary currentEmployeeSallaryData = await _uow.EmployeeBasicSallaryRepository.GetByIdAsync(request.Id);
            if (currentEmployeeSallaryData == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (request.FinancialYearId.HasValue)
            {
                currentEmployeeSallaryData.FinancialYearId = request.FinancialYearId.Value;
            }
            if (request.BasicSallary.HasValue)
            {
                currentEmployeeSallaryData.BasicSallary = request.BasicSallary.Value;
            }
            if (request.Wazifi.HasValue)
            {
                currentEmployeeSallaryData.Wazifi = request.Wazifi.Value;
            }
            if (request.Mokamel.HasValue)
            {
                currentEmployeeSallaryData.Mokamel = request.Mokamel.Value;
            }
            if (request.Ta3widi.HasValue)
            {
                currentEmployeeSallaryData.Ta3widi = request.Ta3widi.Value;
            }
            await _uow.EmployeeBasicSallaryRepository.Update(currentEmployeeSallaryData);
            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!result)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit?>.Success(Unit.Value);
        }
    }


}
