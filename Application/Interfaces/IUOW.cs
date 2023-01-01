using Application.Interfaces.Repository;
using Domain;
using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUOW:IDisposable
    {
      //  IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository { get; }
       
        IEmployeePartTimeRepository EmployeePartTimeRepository { get; }
        IOrderRepository OrderRepository { get; }
      
        IEmployeeOrderRepository EmployeeOrderRepository { get; }
        IEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository { get; }

        IEmployeeOrderDeductionRepository EmployeeOrderDeductionRepository { get; }
        IEmployeeOrderDeductionExecuationRepository EmployeeOrderDeductionExecuationRepository { get; }
        IBudgetItemRepository BudgetItemRepository { get; }

        IEmployeeGradeRepository EmployeeGradeRepository { get; }
        IGradeRepository GradeRepository { get; }

        IBankRepository BankRepository { get; }
        IBranchRepository BranchRepository { get; }

        IEmployeeBankRepository EmployeeBankRepository { get; }
        IEmployeeSubscriptionRepository EmployeeSubscriptionRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }
        Task<SaveState> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
