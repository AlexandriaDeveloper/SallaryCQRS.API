

using Application.Common;
using Application.Employees.Commands.DeleteEmployee;
using Application.Employees.Commands.EmployeeEndPartTime;
using Application.Employees.Commands.EmployeeStratPartTime;
using Application.Employees.Commands.RegisterEmployee;
using Application.Employees.Commands.RestoreEmployee;
using Application.Employees.Commands.UpdateEmployeeInfo;
using Application.Employees.Queries;
using Application.Employees.Queries.GetDeletedEmployee;
using Application.Employees.Queries.GetEmployeeById;
using Application.Employees.Queries.GetEmployeesListQuery;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;


namespace Web.Api.Controllers
{

    public class EmployeeController : BaseController
    {
       
        [HttpGet]
        public async Task<ActionResult<Result<IReadOnlyList<Employee>>>> GetAllEmployees([FromQuery ]GetEmployeeListQueryParam param) {


            return HandleResult( await Mediator.Send(new GetEmployeesListQuery(param)));
        }

        [HttpGet("DeletedEmployees")]
        public async Task<ActionResult<Result<IReadOnlyList<Employee>>>> DeletedEmployees([FromQuery] GetDeltetdEmployeeListQueryParam param)
        {
            return HandleResult( await Mediator.Send(new GetDeletedEmployeesQuery(param)));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult <Result<Employee>>> GetEmployeesbyId(int id)
        {
            return HandleResult( await Mediator.Send(new GetEmployeesByIdQuery(id)));
        }

        [HttpPost]
        public async Task<ActionResult<Result<Unit>>> RegisterEmployee([FromBody] RegisterNewEmployeeCommand command) {
           
            return HandleResult(await Mediator.Send(command));
        }
        [HttpPut]
        public async Task<ActionResult<Result<Unit?>>> RegisterEmployee([FromBody] UpdateEmployeeInfoCommand command)
        {
           
            return HandleResult(await Mediator.Send(command));
        }

        [HttpPost("EmployeeStartPartTime")]
        public async Task<ActionResult<Result<Guid?>>> EmployeeStartPartTime([FromBody] EmployeeStartPartTimeCommand command)
        {

            return HandleResult( await Mediator.Send(command) );
        }
        [HttpPut("EmployeeEndPartTime")]
        public async Task<ActionResult<Result< Guid?>>> EmployeeEndPartTime([FromBody] EmployeeEndPartTimeCommand command)
        {      
            return HandleResult(await Mediator.Send(command));
        }
        [HttpDelete()]
        public async Task<ActionResult<Result<Unit>>> DeleteEmployee([FromBody] DeleteEmployeeCommand command)
        {
           
            return HandleResult(await Mediator.Send(command));
        }
        [HttpPut("RestoreEmployee")]
        public async Task<ActionResult<Result<Unit>>> RestoreEmployee([FromBody] RestorEmployeeCommand command)
        {
           
            return HandleResult(await Mediator.Send(command));
        }

    }
}
