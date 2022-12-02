

using Application.Common;
using Application.Employees.Commands;
using Application.Employees.Queries;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Application.Employees.Commands.RestoreEmployeeCommand;

namespace Web.Api.Controllers
{
  
    public class EmployeeController : BaseController
    {
       
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Employee>>> GetAllEmployees([FromQuery ]GetEmployeeListQueryParam param) {
           
            IReadOnlyList<Employee> emps = await _mediator.Send(new GetEmployeesListQuery(param));
            return Ok(emps);
        }

        [HttpGet("DeletedEmployees")]
        public async Task<ActionResult<IReadOnlyList<Employee>>> DeletedEmployees([FromQuery] GetDeltetdEmployeeListQueryParam param)
        {

            IReadOnlyList<Employee> emps = await _mediator.Send(new GetDeletedEmployeesQuery(param));
            return Ok(emps);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<Employee>>> GetEmployeesbyId(Guid id)
        {

            Employee emp = await _mediator.Send(new GetEmployeesByIdQuery(id));
            return Ok(emp);
        }

        [HttpPost]
        public async Task<ActionResult> RegisterEmployee([FromBody] RegisterNewEmployeeCommand command) {
           await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> RegisterEmployee([FromBody] UpdateEmployeeInfoCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpPost("EmployeeStartPartTime")]
        public async Task<ActionResult<Guid?>> EmployeeStartPartTime([FromBody] EmployeeStartPartTimeCommand command)
        {
         var result =    await _mediator.Send(command);
            if (result.HasErrors) { 
                return BadRequest(result.Errors);
            }
            return Ok(result.Result);
        }
        [HttpPut("EmployeeEndPartTime")]
        public async Task<ActionResult<Guid?>> EmployeeEndPartTime([FromBody] EmployeeEndPartTimeCommand command)
        {
            var result = await _mediator.Send(command);
            if (result.HasErrors)
            {
                return BadRequest(result.Errors);
            }
            return Ok(result.Result);
        }
        [HttpDelete()]
        public async Task<ActionResult> DeleteEmployee([FromBody] DeleteEmployeeCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut("RestoreEmployee")]
        public async Task<ActionResult> RestoreEmployee([FromBody] RestorEmployeeCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

    }
}
