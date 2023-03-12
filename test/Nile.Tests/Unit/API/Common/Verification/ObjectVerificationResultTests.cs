using Nile.API.Common.Verification;

namespace Nile.Tests.Unit.API.Common.Verification
{
    [TestClass]
    public class ObjectVerificationResultTests
    {
        [TestMethod]
        public void Successful_ShouldReturnWithNoErrors()
        {
            var result = ObjectVerificationResult.Successful();

            Assert.IsFalse(result.Failed);
            Assert.AreEqual(0, result.Errors.Count());
        }

        [TestMethod]
        public void Failure_ShouldReturnWithErrors()
        {
            var errors = new[] { "error" };

            var result = ObjectVerificationResult.Failure(errors);

            Assert.IsTrue(result.Failed);
            Assert.AreEqual(errors.Length, result.Errors.Count());
        }
    }
}
