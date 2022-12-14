using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common;
using Application.DTOS.EmploueeOrdersDtos;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
namespace Application.EmployeeOrders.Command
{

    public class EmployeeOrderDto
    {
        public int Id { get; set; }
        public string? Details { get; set; }
        public int OrderId { get; set; }
        //  public Guid BudgetItemId { get; set; }
        public int EmployeeId { get; set; }
        // public decimal? Amount { get; set; }
        public int Quantity { get; set; }
        public char CreditOrDepit { get; set; } = 'd';
        public DateTime? StartFrom { get; set; }
        public DateTime? EndAt { get; set; }
    }
    public record NewEmployeeOrderCommand(EmployeeOrderDto employeeOrder, int financialYearId) : IRequest<Result<Unit?>>;
    public class NewOrderToEmployeeCommand : Handler<NewEmployeeOrderCommand, Result<Unit?>>
    {
        private readonly IAuthService _authService;

        public NewOrderToEmployeeCommand(IUOW uow, IAuthService authService) : base(uow)
        {
            _authService = authService;
        }

        public override async Task<Result<Unit?>> Handle(NewEmployeeOrderCommand request, CancellationToken cancellationToken)
        {

            //GetEmployeeFinancialData
            EmployeeBasicSallary? employeeSallary = await _uow.EmployeeBasicSallaryRepository.GetEmployeeBasicSallaryByFinancialIdAsync(request.employeeOrder.EmployeeId, request.financialYearId);

            decimal? wazifi = employeeSallary.Wazifi;
            decimal? ta3widi = employeeSallary.Ta3widi;
            decimal? mokamel = employeeSallary.Mokamel;
            int daysInMonth = 30;
            int numberOfMonths = 1;
            if (employeeSallary == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            //check if Employee Is Part Time And Calculat Data Depend On That
            var employeeIsInPartTime = await _uow.EmployeePartTimeRepository.IsEmployeeInPartTime(request.employeeOrder.EmployeeId);
            if (employeeIsInPartTime.HasValue && employeeIsInPartTime.Value == true)
            {

                wazifi = Math.Round(wazifi.Value * 65 / 100, 2);
                mokamel = Math.Round(mokamel.Value * 65 / 100, 2);
                ta3widi = Math.Round(ta3widi.Value * 65 / 100, 2);
            }
            //Get Order Type
            Order order = await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.OrderId);
            if (order == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            // Assign Order To Employee
            EmployeeOrder employeeOrder = new EmployeeOrder();
            employeeOrder.EmployeeOrderExecuations = new List<EmployeeOrderExecuation>();

            employeeOrder.EmployeeId = request.employeeOrder.EmployeeId;
            employeeOrder.OrderId = request.employeeOrder.OrderId;
            employeeOrder.Quantity = request.employeeOrder.Quantity;
            employeeOrder.Details = request.employeeOrder.Details;
            employeeOrder.CreditOrDebit = request.employeeOrder.CreditOrDepit;

            // If Order Have Limited Duration
            // Clcualt number of days 
            //Calculat Total Months Days in case Order Contain MOre Than 1 Month 
            //

            if (request.employeeOrder.StartFrom.HasValue && request.employeeOrder.EndAt.HasValue)
            {

                employeeOrder.StartFrom = request.employeeOrder.StartFrom;
                employeeOrder.EndAt = request.employeeOrder.EndAt;

                DateTime startDate = request.employeeOrder.StartFrom.Value;
                DateTime endDate = request.employeeOrder.EndAt.Value;

                employeeOrder.Quantity = (endDate - startDate).Days + 1;
                request.employeeOrder.Quantity = employeeOrder.Quantity.Value;


                daysInMonth =
                    (new DateTime(endDate.Year, endDate.Month, DateTime.DaysInMonth(endDate.Year, endDate.Month))
                    - new DateTime(startDate.Year, startDate.Month, 1)).Days;


                numberOfMonths = daysInMonth / 30;

            }

            // Clculat Sallary Logic depend on Order

            if (order.Name == Constant.Model.OrderConstants.ABSENCE || order.Name == Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY)
            {

                BudgetItem? wazifiEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.WAZIFI);
                var WazifiAmount = Math.Round(wazifi.Value * numberOfMonths * request.employeeOrder.Quantity / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(wazifiEntity.Id, WazifiAmount));


                BudgetItem? mokamelEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.MOKAMEL);
                decimal MokamelAmount = Math.Round(mokamel.Value * numberOfMonths * request.employeeOrder.Quantity / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(mokamelEntity.Id, MokamelAmount));


                BudgetItem? TaawidiEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.TA3WIDI);
                decimal TaawidiAmount = Math.Round(ta3widi.Value * numberOfMonths * request.employeeOrder.Quantity / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(TaawidiEntity.Id, TaawidiAmount));

            }
            if (order.Name == Constant.Model.OrderConstants.PUNISHMENT_ABSENCE)
            {

                BudgetItem? wazifiEntity = await _uow.BudgetItemRepository.GetByNameAsync(Constant.Model.BudgetItems.WAZIFI);
                var WazifiAmount = Math.Round(wazifi.Value * numberOfMonths * request.employeeOrder.Quantity / daysInMonth, 2);
                employeeOrder.EmployeeOrderExecuations.Add(CalculateEmployeeOrderExecuation(wazifiEntity.Id, WazifiAmount));

            }




            await _uow.EmployeeOrderRepository.AddItem(employeeOrder);



            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;

            if (!result)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit?>.Success(Unit.Value);
            /*
{
  "employeeOrder": {
    "orderId": "4",
    "employeeId": "1",
    "quantity": 3,
    "creditOrDepit": "d",
  "startFrom": "2022-12-07T21:26:27.384Z",
    "endAt": "2022-12-22T21:26:27.384Z",
    "details":"تجربه"
  },
  "financialYearId": "1"
}
             */


        }




        private EmployeeOrderExecuation CalculateEmployeeOrderExecuation(int budgetItemId, decimal amount)
        {

            EmployeeOrderExecuation ex = new EmployeeOrderExecuation();
            ex.BudgetItemId = budgetItemId;
            ex.Amount = amount;
            ex.CreatedBy = _authService.GetCurrentLoggedInUser();
            ex.CreatedDate = DateTime.Now;

            return ex;

        }
    }


}
