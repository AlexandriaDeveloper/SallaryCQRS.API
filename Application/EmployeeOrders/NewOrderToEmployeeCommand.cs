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
namespace Application.EmployeeOrders
{
    public record NewEmployeeOrderCommand (EmployeeOrderDto employeeOrder , Guid financialYearId ):IRequest<Result< Unit?>>;
    public class NewOrderToEmployeeCommand : Handler<NewEmployeeOrderCommand, Result<Unit?>>
    {
        public NewOrderToEmployeeCommand(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<Unit?>> Handle(NewEmployeeOrderCommand request, CancellationToken cancellationToken)
        {
            //GetEmployeeFinancialData
            EmployeeBasicSallary? employeeSallary= await _uow.EmployeeBasicSallaryRepository.GetEmployeeBasicSallaryByFinancialIdAsync(request.employeeOrder.EmployeeId, request.financialYearId);
            if (employeeSallary == null) {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }


            Order order=await _uow.OrderRepository.GetByIdAsync(request.employeeOrder.OrderId);
            if (order == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            decimal sumObject =0;
            if (order.Name == Constant.Model.OrderConstants.ABSENCE || order.Name== Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY) {
                
                sumObject += employeeSallary.Wazifi?? 0;
                sumObject += employeeSallary.Ta3widi ?? 0;
                sumObject += employeeSallary.Mokamel ?? 0;
            }
            if(order.Name == Constant.Model.OrderConstants.PUNISHMENT)
            {

                sumObject += employeeSallary.Wazifi ?? 0;
            }


            decimal total = Math.Round( sumObject * request.employeeOrder.Quantity/30,2);
            var employeeIsInPartTime = await _uow.EmployeePartTimeRepository.IsEmployeeInPartTime(request.employeeOrder.EmployeeId);
            if (employeeIsInPartTime.HasValue)
            {
                if (employeeIsInPartTime.Value == true) { 
                
                    total= Math.Round( total * 65/100);
                }
            }
            
            
           request.employeeOrder.Amount = total;
            request.employeeOrder.CreditOrDepit = 'd';


            EmployeeOrderExecuation oredeExecuationToDb = new EmployeeOrderExecuation() {
            
            Amount= total,
            EmployeeId= request.employeeOrder.EmployeeId,
            CreditOrDepit=request.employeeOrder.CreditOrDepit,
            OrderId= request.employeeOrder.OrderId,
            Quantity = request.employeeOrder.Quantity
            
            };
             await   _uow.EmployeeOrderExecuationRepository.AddItem(oredeExecuationToDb);
            var result=  await _uow.SaveChangesAsync(cancellationToken)>0;

            if (!result) {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit?>.Success(Unit.Value);
            /*


             {
   "employeeOrder": {
     "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
     "orderId": "4020d7e8-db76-4060-aed3-227efff36da3",
     "employeeId": "e1a3c36a-282a-4c82-90e6-ba0823390f2d",
     "quantity": 10,
     "amount":0,
     "creditOrDepit": "d"
   },
   "financialYearId": "6261fa99-a1e5-4da5-8f34-5cf3c4249dc4"
 }


             */

         
        }
    }
}
