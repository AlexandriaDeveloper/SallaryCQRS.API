using Application.EmployeeBankAccount;
using Application.EmployeeBankAccount.Commands.AddBranchToBank;
using Application.EmployeeBankAccount.Commands.EmployeeAddBankAccount;
using Application.EmployeeBankAccount.Commands.EmployeeRemoveBankAccount;
using Application.EmployeeBankAccount.Commands.RegisterBankWithBranches;

using Domain.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeBankAccountController : BaseController
    {
        public EmployeeBankAccountController(IMediator mediator) : base(mediator)
        {
        }


        [HttpPost("AddBankWithBranches")]
        public async Task<ActionResult<Result<Unit>>> AddBankWithBranches([FromBody] BankDto bank)
        {

            var result = await Mediator.Send(new RegisterBankWithBranchesCommand(bank));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

        [HttpPost("EmployeeAddBankAccount")]
        public async Task<ActionResult<Result<Unit>>> EmployeeAddBankAccount([FromBody] EmployeeBankAccountDto employeeBankAccount)
        {

            var result = await Mediator.Send(new EmployeeAddBankAccountCommand(employeeBankAccount));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpDelete  ("EmployeeRemoveBankAccount")]
        public async Task<ActionResult<Result<Unit>>> EmployeeRemoveBankAccount([FromBody] int employeeId)
        {

            var result = await Mediator.Send(new EmployeeRemoveBankAccountCommand(employeeId));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }
        [HttpPost("AddBranchToBank")]
        public async Task<ActionResult<Result<Unit>>> EmployeeAddBankAccount([FromBody] BrancheDto branch)
        {

            var result = await Mediator.Send(new AddBranchToBankCommand(branch));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);
            }
            return result.IsSuccess ? Ok(result) : NotFound(result.Error);
        }

    }
}
