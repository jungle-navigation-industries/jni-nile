using FluentValidation;
using Nile.Application.Common.Responses;

namespace Nile.Tests.Unit.Application.Common.Responses
{
    [TestClass]
    public class BaseResponseTests
    {
        [TestMethod]
        public void BaseResponse_Default_HasCorrectProperties()
        {
            var response = new TestResponse();

            Assert.AreEqual(Status.Success, response.Status);
            Assert.AreEqual(string.Empty, response.ErrorMessage);
        }

        [TestMethod]
        public void BaseResponse_OnErrors_HasCorrectProperties()
        {
            const Status status = Status.AuthenticationError;
            const string errorMessage = "Wrong Password";

            var response = new TestResponse(status, errorMessage);

            Assert.AreEqual(status, response.Status);
            Assert.AreEqual(errorMessage, response.ErrorMessage);
        }

        [TestMethod]
        public void BaseResponse_WrongStatusOnError_ThrowsException()
        {
            Assert.ThrowsException<ValidationException>(() => new TestResponse(Status.Success, "Wrong Password"));
        }
    }
}
