﻿using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
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
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
