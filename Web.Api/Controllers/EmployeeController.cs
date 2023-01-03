

using Application.Employees.Commands.UploadEmployeesFile;
using Domain.Employees.Commands.DeleteEmployee;
using Domain.Employees.Commands.EmployeeEndPartTime;
using Domain.Employees.Commands.EmployeeStratPartTime;
using Domain.Employees.Commands.RegisterEmployee;
using Domain.Employees.Commands.RestoreEmployee;
using Domain.Employees.Commands.UpdateEmployeeInfo;
using Domain.Employees.Queries.GetDeletedEmployee;
using Domain.Employees.Queries.GetEmployeeById;
using Domain.Employees.Queries.GetEmployeesListQuery;
using Domain.Models;
using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Web.Api.Controllers
{

    public class EmployeeController : BaseController
    {
        public EmployeeController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<Result<IReadOnlyList<Employee>>>> GetAllEmployees([FromQuery ]GetEmployeeListQueryParam param) {


            var result =  await Mediator.Send(new GetEmployeesListQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }

            return result.IsSuccess? Ok(result.Value):NotFound(result.Error);
        }

        [HttpGet("DeletedEmployees")]
        public async Task<ActionResult<Result<IReadOnlyList<Employee>>>> DeletedEmployees([FromQuery] GetDeltetdEmployeeListQueryParam param)
        {
            var result = await Mediator.Send(new GetDeletedEmployeesQuery(param));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult <Result<Employee>>> GetEmployeesbyId(int id)
        {
            var result = await Mediator.Send(new GetEmployeesByIdQuery(id));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> RegisterEmployee([FromBody] RegisterNewEmployeeCommand command) {
           
           var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPost("UploadEmployee")]
        public async Task<ActionResult<Result<Unit>>> UploadEmployee([FromForm] UploadEmployeeFileCommand command)
        {
            var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpPut]
        public async Task<ActionResult<Result<Unit?>>> RegisterEmployee([FromBody] UpdateEmployeeInfoCommand command)
        {
            var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return Ok(result.Value);        
        }

        [HttpPost("EmployeeStartPartTime")]
        public async Task<ActionResult<Result<Guid?>>> EmployeeStartPartTime([FromBody] EmployeeStartPartTimeCommand command)
        {

            var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);


        }
        [HttpPut("EmployeeEndPartTime")]
        public async Task<ActionResult<Result< Guid?>>> EmployeeEndPartTime([FromBody] EmployeeEndPartTimeCommand command)
        {


            var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
          
        }
        [HttpDelete()]
        public async Task<ActionResult<Result<Unit>>> DeleteEmployee([FromBody] DeleteEmployeeCommand command)
        {

            var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPut("RestoreEmployee")]
        public async Task<ActionResult<Result<Unit>>> RestoreEmployee([FromBody] RestorEmployeeCommand command)
        {

            var result = await Mediator.Send(command);
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

    }
}
