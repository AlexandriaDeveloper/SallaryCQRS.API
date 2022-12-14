using Application.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public  class BaseController : ControllerBase
    {

        private IMediator _mediator;

    

        protected IMediator Mediator => _mediator ??=HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if(result.IsSuccess && result.Value != null) {            
                return Ok(result.Value);          
            }

            if (result.IsSuccess && result.Value == null)
            {
                return NotFound();
            }
                return BadRequest(result.Error);

            
        }
    }
}