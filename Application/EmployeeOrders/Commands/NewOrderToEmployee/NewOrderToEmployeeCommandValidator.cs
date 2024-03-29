﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeOrders.Commands.NewOrderToEmployee
{
    public class NewOrderToEmployeeCommandValidator :AbstractValidator<NewEmployeeOrderCommand>
    {
        public NewOrderToEmployeeCommandValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x => x.employeeOrder.EmployeeId).NotNull().NotEmpty();
            RuleFor(x => x.employeeOrder.OrderId).NotNull().NotEmpty();
            RuleFor(x => x.employeeOrder.OrderFileId).NotNull().NotEmpty();
            RuleFor(x => x.employeeOrder.CreditOrDepit).NotNull().NotEmpty();
            RuleFor(x => x.employeeOrder. Details).MaximumLength(200);
            RuleFor(x => x.employeeOrder.FinancialYearId).NotNull().NotEmpty();

        }
    }
}
