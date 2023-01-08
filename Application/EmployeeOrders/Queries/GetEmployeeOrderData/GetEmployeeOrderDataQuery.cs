using Domain.Shared;
using Domain.DTOS.EmploueeOrdersDtos;
using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.EmployeeOrders.Queries.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;

namespace Domain.EmployeeOrders.Queries.GetEmployeeOrderData
{
    public record GetEmployeeOrdersDataQuery(int OrderId, int EmployeeId) : IQuery<GetEmployeeOrdersDataDto>;


    public class GetEmployeeOrdersDataQueryHandler : IQueryHandler<GetEmployeeOrdersDataQuery,GetEmployeeOrdersDataDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeeOrdersDataQueryHandler(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            this._mapper = mapper;
        }

        public async  Task<Result<GetEmployeeOrdersDataDto>> Handle(GetEmployeeOrdersDataQuery request, CancellationToken cancellationToken)
        {

            GetEmployeeOrdersDataDto employeeOrderDto = new();

            var employeeOrderList = await _uow.EmployeeOrderRepository.GetEmployeeOrdersByOrderId(request.OrderId, request.EmployeeId);
            var employeeDeductionList = await _uow.EmployeeOrderDeductionRepository.GetEmployeeOrdersDeductionByDeductionId(request.OrderId, request.EmployeeId);


            foreach (var employeeOrder in employeeOrderList)
            {
              


                employeeOrderDto.EmployeeOrders.Add(new GetEmployeeOrdersDataDto.GetEmployeeOrdersListDto
                {

                    Amount = employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount),
                    CreditOrDebit = employeeOrder.CreditOrDebit,
                    Details = employeeOrder.Details,
                    EndAt = employeeOrder.EndAt,
                    Quantity = employeeOrder.Quantity,
                    StartFrom = employeeOrder.StartFrom,
                    Id = employeeOrder.Id,
                    OrderFileName= employeeOrder.OrderFile.Details
                    
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
