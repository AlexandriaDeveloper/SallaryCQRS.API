using Domain.EmployeeSubscriptions.Commands.AssignEmployeeToSubscription;
using Domain.EmployeeSubscriptions;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.EmployeeOrders;
using Application.EmployeeOrders.Queries.GetEmployeeOrderByOrderFileId;

namespace Web.Api.Controllers
{
    public class EmployeeOrderDetailsController : BaseController
    {
        public EmployeeOrderDetailsController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet()]
        public async Task<IActionResult> GetEmployeeOrderDetailsBy() {


            return Ok();

        }
        [HttpGet("GetEmployeeOrderDetailsByOrderFileIdDto")]
        public async Task<ActionResult<Result<PagedList< EmployeeOrderDetailsByOrderFileIdDto>>>> GetEmployeeOrderDetailsByOrderFileIdDto( [FromQuery] GetEmployeeOrderByOrderFileIdQueryParams param)
        {

            var result = (await Mediator.Send(new GetEmployeeOrderByOrderFileIdQuery( param)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
    }
}
