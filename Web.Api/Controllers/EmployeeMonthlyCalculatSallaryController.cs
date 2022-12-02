using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{

    public class EmployeeMonthlyCalculatSallaryController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> CalculateSallary() { 
        
        return await Task.FromResult(Ok());
        }
    }
}
