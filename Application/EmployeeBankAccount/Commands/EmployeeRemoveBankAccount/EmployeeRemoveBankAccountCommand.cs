using Application.Common.Messaging;
using Domain.Constants;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeBankAccount.Commands.EmployeeRemoveBankAccount
{
    public record EmployeeRemoveBankAccountCommand(int employeeId) :ICommand;
   public class EmployeeRemoveBankAccountCommandHandler : ICommandHandler<EmployeeRemoveBankAccountCommand>
    {
        private readonly IUOW _uow;

        public EmployeeRemoveBankAccountCommandHandler(IUOW uow)
        {
            _uow = uow;
        }

        public async Task<Result> Handle(EmployeeRemoveBankAccountCommand request, CancellationToken cancellationToken)
        {
            var spec =new EmployeeRemoveBankAccountCommandSpecification(request.employeeId);
            
            var employee = _uow.EmployeeRepository.GetBySingleOrDefaultAsync(spec).Result.Data.FirstOrDefault();
            if (employee == null)
            {
                return Result.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (!employee.EmployeeHasBank)
            {
                return Result.Failure(new Error("Not Found"," الموظف غير مسجل له رقم حساب لا يمكن الحذف"));
            }
          
            await _uow.EmployeeRepository.EmployeeRemoveBankAccount(employee);
          var result = await _uow.SaveChangesAsync(cancellationToken);
            if(result != SaveState.Saved)
            {
                return Result.Failure(SaveState.Saved);
            }
            return Result.Success();
        }


    }
    public class EmployeeRemoveBankAccountCommandSpecification : Specification<Employee> {
        public EmployeeRemoveBankAccountCommandSpecification(int employeeId)
        {
            AddInclude(x => x.EmployeeBank);
            AddCriteries(x => x.Id == employeeId);
        }
    
    }



}
