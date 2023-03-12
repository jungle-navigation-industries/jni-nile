using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nile.API.Common.Verification;
using Nile.Application.Common.Responses;
using Nile.Infrastructure.Exceptions;

namespace Nile.API.Common.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        protected BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> ExecuteRequest<TResponse>(IRequest<TResponse> request, Func<TResponse, IActionResult> responseFunc)
            where TResponse : BaseResponse
        {
            var validationResult = ObjectVerification.Validate(request);
            if (validationResult.Failed)
            {
                return BadRequest(validationResult.Errors);
            }

            try
            {
                var response = await _mediator.Send(request);

                return responseFunc.Invoke(response);
            }
            catch (Exception exception)
            {
                await _mediator.Publish(new GlobalExceptionOccurred(exception));

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
