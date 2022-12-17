using Application.Common;

using Application.EmployeeGrades.Commands.AssignEmployeeToGrade;
using Application.EmployeeGrades.Query.GetEmployeeCurrentGrade;
using Application.EmployeeGrades.Query.GetEmployeeInSpecificGradeId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Web.Api.Controllers
{

    public class EmployeeGradeController : BaseController
    {

        [HttpGet("GetEmployeesInSpecificGradeIdQuery")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeesInSpecificGradeIdQuery(int gradeId)
        {

            return HandleResult(await Mediator.Send(new GetEmployeesInSpecificGradeIdQuery(gradeId)));
        }
        [HttpGet("GetEmployeeCurrentGrade")]
        public async Task<ActionResult<Result<Unit>>> GetEmployeeCurrentGrade(int employeeId)
        {

            return HandleResult(await Mediator.Send(new GetEmployeeCurrentGradeQuery(employeeId)));
        }
        [HttpPost("AssignEmployeeToGrade")]
        public async Task<ActionResult<Result<Unit>>> AssignEmployeeToGrade(int employeeId, int gradeId, DateTime assignDate)
        {

            return HandleResult(await Mediator.Send(new AssignEmployeeToGradeCommand(employeeId, gradeId, assignDate)));
        }

    }
}
