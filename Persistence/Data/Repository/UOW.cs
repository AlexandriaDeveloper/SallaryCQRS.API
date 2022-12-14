using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    internal class UOW : IUOW
    {

        private  IEmployeeRepository _employeeRepository;
        private IEmployeeBasicSallaryRepository _employeeSallaryRepository;
        private IEmployeePartTimeRepository _employeePartTimeRrepository;
        private IOrderRepository _orderRepository;
   
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;
        private IBudgetItemRepository _budgetItemRepository;

        private IEmployeeOrderRepository _employeeOrderRepository;
        private IEmployeeOrderExecuationRepository _employeeOrderExecuationRepository;


        private IEmployeeOrderDeductionRepository _employeeOrderDeductionRepository;
        private IEmployeeOrderDeductionExecuationRepository _employeeOrderDeductionExecuationRepository;
        public UOW(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._context = context;
            this._authService = authService;
        }


      

        public IEmployeePartTimeRepository EmployeePartTimeRepository => _employeePartTimeRrepository = _employeePartTimeRrepository ?? new EmployeePartTimeRepository(_context, _authService);

        public IEmployeeRepository EmployeeRepository => _employeeRepository = _employeeRepository ?? new EmployeeRepository(_context, _authService);
       // public IEmployeeBasicSallaryRepository EmployeeSallaryRepository => _employeeSallaryRepository = _employeeSallaryRepository ?? new EmployeeBasicSallaryRepository(_context, _authService);

        public IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository => _employeeSallaryRepository = _employeeSallaryRepository ?? new EmployeeBasicSallaryRepository(_context, _authService);
        public IOrderRepository OrderRepository => _orderRepository = _orderRepository ?? new OrderRepository(_context, _authService);
        public IEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository => _employeeOrderExecuationRepository = _employeeOrderExecuationRepository ?? new EmployeeOrderExecuationRepository(_context, _authService);
        public IBudgetItemRepository BudgetItemRepository => _budgetItemRepository = _budgetItemRepository ?? new BudgetItemRepository(_context, _authService);
        public IEmployeeOrderRepository EmployeeOrderRepository => _employeeOrderRepository = _employeeOrderRepository ?? new EmployeeOrderRepository(_context, _authService);

        public IEmployeeOrderDeductionRepository EmployeeOrderDeductionRepository => _employeeOrderDeductionRepository = _employeeOrderDeductionRepository ?? new EmployeeOrderDeductionRepository(_context, _authService);
        public IEmployeeOrderDeductionExecuationRepository EmployeeOrderDeductionExecuationRepository => _employeeOrderDeductionExecuationRepository = _employeeOrderDeductionExecuationRepository ?? new EmployeeOrderDeductionExecuationRepository(_context, _authService);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

      
    }
}
