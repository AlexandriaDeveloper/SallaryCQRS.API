﻿using Domain.Shared;
using Domain.DTOS.EmploueeOrdersDtos;
using Domain.EmployeeOrders.Commands.NewOrderToEmployee;
using Domain.Interfaces;
using Domain.Common;
using Domain.Models;
using MediatR;
using Domain.Shared;
using Application.Common.Messaging;

namespace Domain.EmployeeOrders.Commands.PayDeductionEmployee
{

    public record PayDeductionEmployeeCommand(EmployeeOrderDeductionDto employeeOrder) : ICommand<Unit>;

    public class PayDeductionEmployeeCommandHandler : ICommandHandler<PayDeductionEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IAuthService _authService;

        public PayDeductionEmployeeCommandHandler(IUOW uow, IAuthService authService) 
        {
            _uow = uow;
            _authService = authService;
        }

        public  async Task<Result<Unit>> Handle(PayDeductionEmployeeCommand request, CancellationToken cancellationToken)
        {

            //var validation = new PayDeductionEmployeeCommandValidator();
            //var validate = await validation.ValidateAsync(request, cancellationToken);
            //if (!validate.IsValid)
            //{
            //    return Result<Unit?>.Failure( validate.Errors.First().ErrorMessage);
            //}

            if (request == null || request.employeeOrder == null)
            {
                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }

            Order order = await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.OrderId);
            if (order == null)
            {

                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }

            EmployeeOrderDeduction employeeOrderDeduction = new EmployeeOrderDeduction();
            employeeOrderDeduction.EmployeeOrderDeductionExecuations = new List<EmployeeOrderDeductionExecuation>();
            employeeOrderDeduction.OrderId = request.employeeOrder.OrderId;
            employeeOrderDeduction.CreatedBy = _authService.GetCurrentLoggedInUser();
            employeeOrderDeduction.EmployeeId = request.employeeOrder.EmployeeId;
            employeeOrderDeduction.CreditOrDebit = request.employeeOrder.CreditOrDepit;
            employeeOrderDeduction.FormId= request.employeeOrder.FormId;
            employeeOrderDeduction.Details = request.employeeOrder.Details;

            if (order.Name == Constant.Model.OrderConstants.PUNISHMENT_ABSENCE)
            {
                BudgetItem budgetItem = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.GAZAA);

                employeeOrderDeduction.EmployeeOrderDeductionExecuations.Add(CalculateEmployeeOrderExecuation(budgetItem.Id, request.employeeOrder.Amount));
            }

            if (order.Name == Constant.Model.OrderConstants.ABSENCE)
            {
                BudgetItem budgetItem = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.ABSENCE);

                employeeOrderDeduction.EmployeeOrderDeductionExecuations.Add(CalculateEmployeeOrderExecuation(budgetItem.Id, request.employeeOrder.Amount));
            }
            if (order.Name == Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY)
            {
                BudgetItem budgetItem = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.ABSENCE);

                employeeOrderDeduction.EmployeeOrderDeductionExecuations.Add(CalculateEmployeeOrderExecuation(budgetItem.Id, request.employeeOrder.Amount));
            }

            await _uow.EmployeeOrderDeductionRepository.AddItem(employeeOrderDeduction);
            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!result)
            {

                return Result<Unit>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA));
            }
            return Result<Unit>.Success(Unit.Value);
        }

        private EmployeeOrderDeductionExecuation CalculateEmployeeOrderExecuation(int budgetItemId, decimal amount)
        {

            EmployeeOrderDeductionExecuation ex = new EmployeeOrderDeductionExecuation();
            ex.BudgetItemId = budgetItemId;
            ex.Amount = amount;
            ex.CreatedBy = _authService.GetCurrentLoggedInUser();
            ex.CreatedDate = DateTime.Now;

            return ex;

        }
    }
}
