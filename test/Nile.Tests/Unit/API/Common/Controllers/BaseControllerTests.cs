using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Nile.Tests.Unit.API.Common.Controllers
{
    [TestClass]
    public class BaseControllerTests
    {
        private readonly Mock<IMediator> _mediator;
        private readonly TestBaseController _controller;

        public BaseControllerTests()
        {
            _mediator = new Mock<IMediator>();
            _controller = new TestBaseController(_mediator.Object);
        }

        [TestMethod]
        public async Task ExecuteRequest_OnValidationFailures_ReturnsBadRequest()
        {
            var result = await _controller.Handle(TestObjectRequest.InValid());

            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
        }

        [TestMethod]
        public async Task ExecuteRequest_OnSuccess_ReturnsCorrectResult()
        {
            var response = new TestObjectResponse { Value = "success" };

            _mediator.Setup(x => x.Send(It.IsAny<IRequest<TestObjectResponse>>(), CancellationToken.None))
                .ReturnsAsync(response);

            var result = await _controller.Handle(TestObjectRequest.Valid()) as OkObjectResult;

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            Assert.AreEqual(response, result.Value);
        }

        [TestMethod]
        public async Task ExecuteRequest_OnException_ReturnsBadRequest()
        {
            _mediator.Setup(x => x.Send(It.IsAny<IRequest<TestObjectResponse>>(), CancellationToken.None))
                .ThrowsAsync(new Exception());

            var result = await _controller.Handle(TestObjectRequest.Valid()) as StatusCodeResult;

            Assert.AreEqual(StatusCodes.Status500InternalServerError, result?.StatusCode);
        }
    }
}
