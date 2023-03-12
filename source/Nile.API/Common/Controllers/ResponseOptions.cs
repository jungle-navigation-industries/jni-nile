using Microsoft.AspNetCore.Mvc;
using Nile.Application.Common.Responses;

namespace Nile.API.Common.Controllers
{
    public static class ResponseOptions
    {
        public static IActionResult OkResponse(BaseResponse applicationResponse)
        {
            return DetermineResult(applicationResponse, new OkObjectResult(applicationResponse));
        }

        public static IActionResult DetermineResult(BaseResponse applicationResponse, IActionResult successResult)
        {
            return applicationResponse.Status switch
            {
                Status.Success => successResult,
                Status.ValidationError => new BadRequestObjectResult(applicationResponse),
                _ => new BadRequestResult(),
            };
        }
    }
}
