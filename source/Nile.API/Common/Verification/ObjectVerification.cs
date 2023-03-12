using System.ComponentModel.DataAnnotations;

namespace Nile.API.Common.Verification
{
    public static class ObjectVerification
    {
        public static ObjectVerificationResult Validate(object entity)
        {
            var context = new ValidationContext(entity, null, null);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(entity, context, results, true))
            {
                return ObjectVerificationResult.Failure(results.Select(validationResult => validationResult.ErrorMessage ?? string.Empty));
            }

            return ObjectVerificationResult.Successful();
        }
    }
}
