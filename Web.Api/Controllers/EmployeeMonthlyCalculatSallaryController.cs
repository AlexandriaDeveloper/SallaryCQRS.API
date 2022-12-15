using Application.Common;
using Application.EmployeeOrders.Commands.NewOrderToEmployee;
using Application.EmployeeOrders.Commands.PayDeductionEmployee;
using Application.EmployeeOrders.Queries;
using Application.EmployeeOrders.Queries.EmployeeOrderDeductionBalance;
using Application.EmployeeOrders.Queries.GetEmployeeOrderData;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Web.Api.Controllers
{

    public class EmployeeMonthlyCalculatSallaryController : BaseController
    {
        [HttpGet("GetEmployeeOrderBalance")]
        public async Task<ActionResult<Result<Unit?>>> NewEmployeeOrderCommand([FromQuery] int employeeId)
        {


            return HandleResult(await Mediator.Send(new EmployeeOrderDeductionBalanceQuery(employeeId)));
        }
        [HttpGet("GetEmployeeOrders")]
        public async Task<ActionResult<Result<Unit?>>> GetEmployeeOrders([FromQuery] int employeeId,int orderId)
        {


            return HandleResult(await Mediator.Send(new GetEmployeeOrdersDataQuery(orderId, employeeId)));
        }

        [HttpPost("NewEmployeeOrder")]
        public async Task<ActionResult<Result<Unit?>>> NewEmployeeOrderCommand([FromBody]NewEmployeeOrderCommand command) {

          
        return HandleResult(await Mediator.Send(command));
        }

        [HttpPost("EmployeeOrderDeduction")]
        public async Task<ActionResult<Result<Unit?>>> EmployeeOrderDeduction([FromBody] PayDeductionEmployeeCommand command)
        {


            return HandleResult(await Mediator.Send(command));
        }
    }
}
