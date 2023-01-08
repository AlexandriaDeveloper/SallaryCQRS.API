using Domain.Shared;
using Domain.EmployeeOrders.Commands.NewOrderToEmployee;
using Domain.EmployeeOrders.Commands.PayDeductionEmployee;
using Domain.EmployeeOrders.Queries;
using Domain.EmployeeOrders.Queries.EmployeeOrderDeductionBalance;
using Domain.EmployeeOrders.Queries.GetEmployeeOrderData;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySqlX.XDevAPI.Common;
using Microsoft.AspNetCore.Http.HttpResults;
using Domain.EmployeeOrders;

namespace Web.Api.Controllers
{

    public class EmployeeMonthlyCalculatSallaryController : BaseController

       
    {

        public EmployeeMonthlyCalculatSallaryController(IMediator mediator) :base(mediator) { }
     
        [HttpGet("GetEmployeeOrderBalance/{employeeId}")]
        public async Task<ActionResult<Result<Unit?>>> NewEmployeeOrderCommand( int employeeId)
        {


            var result = (await Mediator.Send(new EmployeeOrderDeductionBalanceQuery(employeeId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpGet("GetEmployeeOrders")]
        public async Task<ActionResult<Result<Unit?>>> GetEmployeeOrders([FromQuery] int employeeId,int orderId)
        {


           var result = (await Mediator.Send(new GetEmployeeOrdersDataQuery(orderId, employeeId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("NewEmployeeOrder")]
        public async Task<ActionResult<Result<Unit?>>> NewEmployeeOrderCommand([FromBody]EmployeeOrderDto command) {

          
       var result =await Mediator.Send(new NewEmployeeOrderCommand(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost("EmployeeOrderDeduction")]
        public async Task<ActionResult<Result<Unit?>>> EmployeeOrderDeduction([FromBody] PayDeductionEmployeeCommand command)
        {


            var result =(await Mediator.Send(command));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
