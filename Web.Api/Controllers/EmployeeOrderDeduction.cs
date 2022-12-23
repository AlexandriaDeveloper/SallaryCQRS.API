using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeOrderDeduction : BaseController
    {
        public EmployeeOrderDeduction(IMediator mediator) : base(mediator)
        {
        }
    }
}
