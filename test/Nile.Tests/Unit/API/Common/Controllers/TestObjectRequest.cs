using System.ComponentModel.DataAnnotations;
using MediatR;

namespace Nile.Tests.Unit.API.Common.Controllers
{
    internal class TestObjectRequest : IRequest<TestObjectResponse>
    {
        [Required(AllowEmptyStrings = false)]
        public string TestField { get; set; } = string.Empty;

        public static TestObjectRequest Valid()
        {
            return new TestObjectRequest { TestField = "valid" };
        }

        public static TestObjectRequest InValid()
        {
            return new TestObjectRequest { TestField = string.Empty };
        }
    }
}
