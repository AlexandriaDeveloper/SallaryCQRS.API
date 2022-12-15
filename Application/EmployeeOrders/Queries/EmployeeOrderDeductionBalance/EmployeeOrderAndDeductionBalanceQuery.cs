using Application.Common;
using Application.DTOS.EmployeeOrderDeductionBalance;
using Application.EmployeeOrders.Commands.PayDeductionEmployee;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeOrders.Queries.EmployeeOrderDeductionBalance
{
    public record EmployeeOrderDeductionBalanceQuery(int employeeId) : IRequest<Result<EmployeeOrderDeductionBalanceDto>>;

    public class EmployeeOrderDeductionBalanceQueryHandler : Handler<EmployeeOrderDeductionBalanceQuery, Result<EmployeeOrderDeductionBalanceDto>>
    {
        public EmployeeOrderDeductionBalanceQueryHandler(IUOW uow, IAuthService authService) : base(uow)
        {
        }

        public override async Task<Result<EmployeeOrderDeductionBalanceDto>> Handle(EmployeeOrderDeductionBalanceQuery request, CancellationToken cancellationToken)
        {

            var validation = new EmployeeOrderDeductionBalanceQueryValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<EmployeeOrderDeductionBalanceDto>.Failure(validate.Errors.First().ErrorMessage);
            }
            //GetEmployee Data
            Employee employee = await _uow.EmployeeRepository.GetByIdAsync(request.employeeId);
            if (employee == null)
            {
                return Result<EmployeeOrderDeductionBalanceDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
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
