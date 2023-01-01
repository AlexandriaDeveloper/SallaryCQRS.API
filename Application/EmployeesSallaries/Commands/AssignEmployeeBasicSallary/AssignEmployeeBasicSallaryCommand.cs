using Domain.Shared;
using Domain.DTOS.EmploueeOrdersDtos;
using Domain.EmployeeOrders.Queries.GetEmployeeOrderData;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;
using Domain.Constants;

namespace Domain.EmployeesSallaries.Commands.AssignEmployeeBasicSallary
{

    public record AssignEmployeeBasicSallaryCommand(int EmployeeId, int FinancialYearId, decimal BasicSallary, decimal Wazifi=0, decimal Mokamel=0, decimal Ta3widi=0) : ICommand<int>;

    public class AssignEmployeeBasicSallaryCommandHandler : ICommandHandler<AssignEmployeeBasicSallaryCommand, int>
    {
        private readonly IUOW _uow;

        public AssignEmployeeBasicSallaryCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
        public   async Task<Result<int>> Handle(AssignEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {

            //var validation = new AssignEmployeeBasicSallaryCommandValidator();
            //var validate = await validation.ValidateAsync(request, cancellationToken);
            //if (!validate.IsValid)
            //{
            //    return Result<int>.Failure(validate.Errors.First().ErrorMessage);
            //}

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
            var result = await _uow.SaveChangesAsync(cancellationToken) ;
            if (result == Enums.SaveState.SqlDublicateException)
            {
               // return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_DUBLICATION_EXCEPTION);
            }
            if (result != Enums.SaveState.Saved)
                return Result<int>.Failure( Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            return Result<int>.Success(employeeBasicSallary.EmployeeId);

        }


    }


}
