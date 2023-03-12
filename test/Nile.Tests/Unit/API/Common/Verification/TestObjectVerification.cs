using System.ComponentModel.DataAnnotations;

namespace Nile.Tests.Unit.API.Common.Verification
{
    public class TestObjectVerification
    {
        [Required]
        public string Value { get; set; } = string.Empty;
    }
}
