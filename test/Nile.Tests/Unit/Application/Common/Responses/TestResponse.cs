using Nile.Application.Common.Responses;

namespace Nile.Tests.Unit.Application.Common.Responses
{
    internal class TestResponse : BaseResponse
    {
        public TestResponse()
        {
        }

        public TestResponse(Status status, string errorMessage)
            : base(status, errorMessage)
        {
        }
    }
}
