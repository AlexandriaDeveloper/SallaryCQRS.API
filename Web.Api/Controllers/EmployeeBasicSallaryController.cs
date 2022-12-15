using Application.Common;
using Application.Employees.Commands;
using Application.EmployeesSallaries.Commands.AssignEmployeeBasicSallary;
using Application.EmployeesSallaries.Commands.EmployeeGetRaise;
using Application.EmployeesSallaries.Commands.UpdateEmployeeBasicSallary;
using Application.EmployeesSallaries.Queries.GetEmployeeBasicSallaryByFinancialYear;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeBasicSallaryController : BaseController
    {


        [HttpGet("GetEmployeeBasicSallaryByFinancialYear")]
        public async Task<ActionResult<Result<EmployeeBasicSallary>>> GetEmployeeBasicSallaryByFinancialYear([FromQuery]  GetEmployeeBasicSallaryByFinancialYearQuery command)
        {
            return HandleResult(  await Mediator.Send(command));
        }

        [HttpPost]
        public async Task<ActionResult<Result<EmployeeBasicSallary>>> RegisterEmployee([FromQuery] EmployeeGetRaisedCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [HttpPost("AssignEmployeeFinaicialData")]
        public async Task<ActionResult<Result<Guid>>> AssignEmployeeFinaicialData ([FromQuery] AssignEmployeeBasicSallaryCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }
        [HttpPut("UpdateEmployeeFinaicialData")]
        public async Task<ActionResult<Result<Unit?>>> AssignEmployeeFinaicialData([FromQuery] UpdateEmployeeBasicSallaryCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }
  
    }
}
