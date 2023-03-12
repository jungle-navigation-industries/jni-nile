using Nile.API.Common.Verification;

namespace Nile.Tests.Unit.API.Common.Verification
{
    [TestClass]
    public class ObjectVerificationTests
    {
        [TestMethod]
        public void Entity_WithFailedFields_ReturnsFailure()
        {
            var result = ObjectVerification.Validate(new TestObjectVerification());

            Assert.IsTrue(result.Failed);
        }

        [TestMethod]
        public void Entity_WithValidFields_ReturnsSuccess()
        {
            var testObject = new TestObjectVerification
            {
                Value = "value",
            };

            var result = ObjectVerification.Validate(testObject);

            Assert.IsFalse(result.Failed);
        }
    }
}
