﻿using Domain.Interfaces;
using Domain.Models;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    internal class UOW : IUOW
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;


        private Lazy<IEmployeeRepository> _employeeRepository;
        private Lazy< IEmployeeBasicSallaryRepository> _employeeSallaryRepository;
        private Lazy<IEmployeePartTimeRepository> _employeePartTimeRrepository;
        private Lazy<IOrderRepository> _orderRepository;
        private Lazy<IBudgetItemRepository> _budgetItemRepository;
        private  Lazy<IEmployeeOrderRepository> _employeeOrderRepository;
        private Lazy< IEmployeeOrderExecuationRepository> _employeeOrderExecuationRepository;
        private Lazy<IEmployeeOrderDeductionRepository> _employeeOrderDeductionRepository;
        private  Lazy<IEmployeeOrderDeductionExecuationRepository> _employeeOrderDeductionExecuationRepository;
        private Lazy<IEmployeeGradeRepository> _employeeGradeRepository;
        private Lazy<IGradeRepository> _gradeRepository;

        private Lazy<ISubscriptionRepository> _subscriptionRepository;
        private Lazy<IEmployeeSubscriptionRepository> _employeeSubscriptionRepository;
        public UOW(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._context = context;
            this._authService = authService;
            LazyInitializer(context,authService);

        }

        public IEmployeePartTimeRepository EmployeePartTimeRepository => _employeePartTimeRrepository.Value;
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;
        public IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository => _employeeSallaryRepository.Value;
        public IOrderRepository OrderRepository => _orderRepository.Value;
        public IEmployeeOrderExecuationRepository EmployeeOrderExecuationRepository => _employeeOrderExecuationRepository.Value;
        public IBudgetItemRepository BudgetItemRepository => _budgetItemRepository.Value;
        public IEmployeeOrderRepository EmployeeOrderRepository => _employeeOrderRepository.Value;
        public IEmployeeOrderDeductionRepository EmployeeOrderDeductionRepository => _employeeOrderDeductionRepository.Value;
        public IEmployeeOrderDeductionExecuationRepository EmployeeOrderDeductionExecuationRepository => _employeeOrderDeductionExecuationRepository.Value;
        public IEmployeeGradeRepository EmployeeGradeRepository => _employeeGradeRepository.Value;
        public ISubscriptionRepository SubscriptionRepository => _subscriptionRepository.Value;
        public IEmployeeSubscriptionRepository EmployeeSubscriptionRepository => _employeeSubscriptionRepository.Value;
        public IGradeRepository GradeRepository => _gradeRepository.Value;

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }


        private void LazyInitializer(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._employeeRepository= this._employeeRepository??  new Lazy<IEmployeeRepository>(() => new EmployeeRepository(context, authService));
            this._employeePartTimeRrepository = this._employeePartTimeRrepository ?? new Lazy<IEmployeePartTimeRepository>(() => new EmployeePartTimeRepository(context, authService)); 
            this._orderRepository = this._orderRepository ?? new Lazy<IOrderRepository>(() => new OrderRepository(context, authService));
            this._employeeOrderExecuationRepository = this._employeeOrderExecuationRepository ?? new Lazy<IEmployeeOrderExecuationRepository>(() => new EmployeeOrderExecuationRepository(context, authService));
            this._budgetItemRepository = this._budgetItemRepository ?? new Lazy<IBudgetItemRepository>(() => new BudgetItemRepository(context, authService));
            this._employeeOrderRepository = this._employeeOrderRepository ?? new Lazy<IEmployeeOrderRepository>(() => new EmployeeOrderRepository(context, authService));
            this._employeeOrderDeductionRepository = this._employeeOrderDeductionRepository ?? new Lazy<IEmployeeOrderDeductionRepository>(() => new EmployeeOrderDeductionRepository(context, authService));
            this._employeeOrderDeductionExecuationRepository = this._employeeOrderDeductionExecuationRepository ?? new Lazy<IEmployeeOrderDeductionExecuationRepository>(() => new EmployeeOrderDeductionExecuationRepository(context, authService));
            this._employeeGradeRepository = this._employeeGradeRepository ?? new Lazy<IEmployeeGradeRepository>(() => new EmployeeGradeRepository(context, authService));
            this._gradeRepository = this._gradeRepository ?? new Lazy<IGradeRepository>(() => new GradeRepository(context, authService));
            this._employeeSallaryRepository = this._employeeSallaryRepository ?? new Lazy<IEmployeeBasicSallaryRepository>(() => new EmployeeBasicSallaryRepository(context, authService));
            this._subscriptionRepository = this._subscriptionRepository ?? new Lazy<ISubscriptionRepository>(() => new SubscriptionRepository(context, authService));
            this._employeeSubscriptionRepository = this._employeeSubscriptionRepository ?? new Lazy<IEmployeeSubscriptionRepository>(() => new EmployeeSubscriptionRepository(context, authService));
        }
      
    }
}
