using Domain.Shared;
using Domain.EmployeeGrades.Commands.AssignEmployeeToGrade;
using Domain.EmployeeOrders.Commands.EmployeeToSubscription;
using Domain.EmployeeSubscriptions;
using Domain.EmployeeSubscriptions.Commands.AssignEmployeeToSubscription;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Common;

namespace Web.Api.Controllers
{
    public class EmployeeSubscriptionsController :BaseController
    {
        public EmployeeSubscriptionsController(IMediator mediator):base(mediator) { }
      
        [HttpPost("AssignEmployeeToSubscription")]
        public async Task<ActionResult<Result<Unit>>> AssignEmployeeToSubscription(EmployeeSubscriptionDto subscriptionDto)
        {

            var result = (await Mediator.Send(new AssignEmployeeToSubscriptionCommand(subscriptionDto)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }
        [HttpPost("AssignEmployeesSubscriptionToOrderForm")]
        public async Task<ActionResult<Result<Unit>>> AssignEmployeesToSubscriptionOrderForm(int subscriptionId,int formId)
        {

            var result = (await Mediator.Send(new EmployeeToSubscriptionOrderCommand(subscriptionId, formId)));
            if (result.IsFailure)
            {
                return HandleFailureResult(result);

            }
            return result.IsSuccess ? Ok(result.Value) : NotFound(result.Error);
        }

    }
}
