using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nile.API.Common.Controllers;

namespace Nile.Tests.Unit.API.Common.Controllers
{
    internal class TestBaseController : BaseController
    {
        public TestBaseController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Handle(TestObjectRequest request)
        {
            return await ExecuteRequest(request, ResponseOptions.OkResponse);
        }
    }
}
