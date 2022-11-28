using Application.Employees.Commands;
using Application.EmployeesSallaries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeBasicSallaryController : BaseController
    {
        private readonly IMediator _mediator;

        public EmployeeBasicSallaryController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> RegisterEmployee([FromQuery] EmployeeGetRaisedCommand command)
        {
          var result =   await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("AssignEmployeeFinaicialData")]
        public async Task<ActionResult> AssignEmployeeFinaicialData ([FromQuery] AssignEmployeeBasicSallaryCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpPut("UpdateEmployeeFinaicialData")]
        public async Task<ActionResult> AssignEmployeeFinaicialData([FromQuery] UpdateEmployeeBasicSallaryCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
