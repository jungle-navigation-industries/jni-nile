namespace Nile.API.Common.Verification
{
    public class ObjectVerificationResult
    {
        private ObjectVerificationResult(bool failed, IEnumerable<string> errors)
        {
            Failed = failed;
            Errors = errors;
        }

        public bool Failed { get; }

        public IEnumerable<string> Errors { get; }

        public static ObjectVerificationResult Successful()
        {
            return new ObjectVerificationResult(false, Enumerable.Empty<string>());
        }

        public static ObjectVerificationResult Failure(IEnumerable<string> errors)
        {
            return new ObjectVerificationResult(true, errors);
        }
    }
}
