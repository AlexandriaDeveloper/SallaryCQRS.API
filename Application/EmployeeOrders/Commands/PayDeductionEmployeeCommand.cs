using Application.Common;
using Application.DTOS.EmploueeOrdersDtos;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;

namespace Application.EmployeeOrders.Command
{
    public class EmployeeOrderDeductionDto
    {
        public int Id { get; set; }
        public string? Details { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public char CreditOrDepit { get; set; } = 'c';

    }

    public record PayDeductionEmployeeCommand(EmployeeOrderDeductionDto employeeOrder) : IRequest<Result<Unit?>>;

    public class PayDeductionEmployeeCommandHandler : Handler<PayDeductionEmployeeCommand, Result<Unit?>>
    {
        private readonly IAuthService _authService;

        public PayDeductionEmployeeCommandHandler(IUOW uow, IAuthService authService) : base(uow)
        {
            _authService = authService;
        }

        public override async Task<Result<Unit?>> Handle(PayDeductionEmployeeCommand request, CancellationToken cancellationToken)
        {

            if (request == null || request.employeeOrder == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            Order order = await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.OrderId);
            if (order == null)
            {

                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            EmployeeOrderDeduction employeeOrderDeduction = new EmployeeOrderDeduction();
            employeeOrderDeduction.EmployeeOrderDeductionExecuations = new List<EmployeeOrderDeductionExecuation>();
            employeeOrderDeduction.OrderId = request.employeeOrder.OrderId;
            employeeOrderDeduction.CreatedBy = _authService.GetCurrentLoggedInUser();
            employeeOrderDeduction.EmployeeId = request.employeeOrder.EmployeeId;
            employeeOrderDeduction.CreditOrDebit = request.employeeOrder.CreditOrDepit;
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

                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit?>.Success(Unit.Value);
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
