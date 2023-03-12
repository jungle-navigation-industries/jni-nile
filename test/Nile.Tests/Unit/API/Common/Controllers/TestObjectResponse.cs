using Nile.Application.Common.Responses;

namespace Nile.Tests.Unit.API.Common.Controllers
{
    internal class TestObjectResponse : BaseResponse
    {
        public string Value { get; set; } = string.Empty;
    }
}
