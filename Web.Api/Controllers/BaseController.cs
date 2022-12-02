using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController : ControllerBase
    {
    

        protected IMediator _mediator;

        public IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();


    }
}