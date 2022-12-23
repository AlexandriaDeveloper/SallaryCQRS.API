using Domain.Shared;
using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.EmployeeOrders.Commands.PayDeductionEmployee;
using Domain.Interfaces;
using Domain.Common;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;

namespace Domain.EmployeeOrders.Queries.EmployeeOrderDeductionBalance
{
    public record EmployeeOrderDeductionBalanceQuery(int employeeId) : IQuery<EmployeeOrderDeductionBalanceDto>;

    public class EmployeeOrderDeductionBalanceQueryHandler : IQueryHandler<EmployeeOrderDeductionBalanceQuery, EmployeeOrderDeductionBalanceDto>
    {
        private readonly IUOW _uow;

        public EmployeeOrderDeductionBalanceQueryHandler(IUOW uow, IAuthService authService)
        {
            _uow = uow;
            AuthService = authService;
        }

        public IAuthService AuthService { get; }

        public  async Task<Result<EmployeeOrderDeductionBalanceDto>> Handle(EmployeeOrderDeductionBalanceQuery request, CancellationToken cancellationToken)
        {
            //GetEmployee Data
            Employee employee = await _uow.EmployeeRepository.GetByIdAsync(request.employeeId);
            if (employee == null)
            {
                return Result<EmployeeOrderDeductionBalanceDto>.Failure(new Error("", Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST));
            }
            //Get Employee Orders Grouped
            EmployeeOrderDeductionBalanceDto employeeBalance = new EmployeeOrderDeductionBalanceDto();
            employeeBalance.EmployeeName = employee.Name;
            employeeBalance.EmployeeId = employee.Id;
            employeeBalance.NationalId = employee.NationalId;
            employeeBalance.TabCode = employee.TabCode;
            employeeBalance.TegaraCode = employee.TegaraCode;
            employeeBalance.EmploueeOrdersDtos = new List<EmployeeTotalOrderDto>();

            var employeeOrdes = _uow.EmployeeOrderRepository.GetEmployeeSumOrders(request.employeeId);
            var employeeOrdesDeduction = _uow.EmployeeOrderDeductionRepository.GetEmployeeDeductionOrders(request.employeeId);
            foreach (EmployeeTotalOrderDeductionDto employeeDeduction in employeeOrdesDeduction)
            {
                var empOrder = employeeOrdes.FirstOrDefault(x => x.OrderId == employeeDeduction.OrderDeductionId);
                if (empOrder != null)
                {
                    empOrder.OrderId = employeeDeduction.OrderDeductionId;
                    empOrder.DeductionTotal = employeeDeduction.Total;
                    empOrder.OrderDeductionName = employeeDeduction.OrderDeductionName;
                    empOrder.OrderId = employeeDeduction.OrderDeductionId;
                }
            }

            employeeBalance.EmploueeOrdersDtos = employeeOrdes;
            return Result<EmployeeOrderDeductionBalanceDto>.Success(employeeBalance);
        }
    }

}
