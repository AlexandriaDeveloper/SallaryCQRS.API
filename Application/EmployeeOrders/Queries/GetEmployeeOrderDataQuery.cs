using Application.Common;
using Application.DTOS.EmploueeOrdersDtos;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeOrders.Queries
{
   public record GetEmployeeOrdersDataQuery(int OrderId,int EmployeeId):IRequest<Result<GetEmployeeOrdersDataDto>>;


    public class GetEmployeeOrdersDataQueryHandler : Handler<GetEmployeeOrdersDataQuery, Result<GetEmployeeOrdersDataDto>>
    {
        public GetEmployeeOrdersDataQueryHandler(IUOW uow) : base(uow)
        {
        }

        public async override Task<Result<GetEmployeeOrdersDataDto>> Handle(GetEmployeeOrdersDataQuery request, CancellationToken cancellationToken)
        {

            GetEmployeeOrdersDataDto employeeOrderDto = new();

           var employeeOrderList = await _uow.EmployeeOrderRepository.GetEmployeeOrdersByOrderId(request.OrderId, request.EmployeeId);
            var employeeDeductionList = await _uow.EmployeeOrderDeductionRepository.GetEmployeeOrdersDeductionByDeductionId(request.OrderId, request.EmployeeId);


            foreach (var employeeOrder in employeeOrderList)
            {
                employeeOrderDto.EmployeeOrders.Add(new GetEmployeeOrdersDataDto.GetEmployeeOrdersListDto { 
                
                Amount=employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount),
                CreditOrDebit=employeeOrder.CreditOrDebit,
                Details=employeeOrder.Details,
                EndAt=employeeOrder.EndAt,
                Quantity=employeeOrder.Quantity,
                StartFrom=employeeOrder.StartFrom,
                Id=employeeOrder.Id
                
                });

            }


            foreach (var employeeDeduction in employeeDeductionList)
            {
                employeeOrderDto.EmployeeDeductions.Add(new GetEmployeeOrdersDataDto.GetEmployeeDeductionsListDto
                {

                    Amount = employeeDeduction.EmployeeOrderDeductionExecuations.Sum(x => x.Amount),
                    CreditOrDebit = employeeDeduction.CreditOrDebit,
                    Details = employeeDeduction.Details,
                    
                  

                });

            }

            return Result<GetEmployeeOrdersDataDto>.Success(employeeOrderDto);

        }
    }

    


}
