using Application.Common.Messaging;
using Domain.Constants;
using Domain.Interfaces;
using Domain.Shared;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.EmployeeBankAccount.Commands.EmployeeAddBankAccount
{
    public record EmployeeAddBankAccountCommand(EmployeeBankAccountDto employeeAccount) : ICommand;

    public class EmployeeAddBankAccountCommandHandler : ICommandHandler<EmployeeAddBankAccountCommand>
    {
        private readonly IUOW _uow;
        private readonly IAuthService _authService;

        public EmployeeAddBankAccountCommandHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            _authService = authService;
        }
        public async Task<Result> Handle(EmployeeAddBankAccountCommand request, CancellationToken cancellationToken)
        {
            var emp = await _uow.EmployeeRepository.GetByIdAsync(request.employeeAccount.EmployeeId);
            if (emp is null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (!await _uow.EmployeeRepository.CheckExistAsync(request.employeeAccount.BranchId))
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (emp.EmployeeHasBank) {
                return Result.Failure(new Error("Account Exist","الموظف مسجل له رقم حساب بالفعل لا يمكن ادخال اكثر من رقم حساب"));
            }
           await _uow.EmployeeRepository.EmployeeAddBankAccount( request.employeeAccount.EmployeeId, 
               new EmployeeBank() { BranchId = request.employeeAccount.BranchId,AccountNumber= request.employeeAccount.AccountNumber,CreatedBy=_authService.GetCurrentLoggedInUser(),CreatedDate=DateTime.Now });

            var result =await _uow.SaveChangesAsync(cancellationToken);
            if(result!= SaveState.Saved)
            {
              return  Result.Failure(result);

            }
            return Result.Success();
        }
    }
}
