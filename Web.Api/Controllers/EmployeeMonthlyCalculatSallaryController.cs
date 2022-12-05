using Application.Common;
using Application.EmployeeOrders;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Web.Api.Controllers
{

    public class EmployeeMonthlyCalculatSallaryController : BaseController
    {

        [HttpPost("NewEmployeeOrderCommand")]
        public async Task<ActionResult<Result<Unit?>>> NewEmployeeOrderCommand([FromBody]NewEmployeeOrderCommand command) {

          
        return HandleResult(await Mediator.Send(command));
        }
    }
}
