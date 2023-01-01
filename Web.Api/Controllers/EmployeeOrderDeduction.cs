using Abp.Domain.Values;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeOrderDeductionController : BaseController
    {
        public EmployeeOrderDeductionController(IMediator mediator) : base(mediator)
        {
        }
        //[HttpGet("ValueObjectTest")]
        //public async Task<IActionResult> ValueObjectTest() {

        
        //}
    }


}
