namespace Nile.Application.Common.Responses
{
    public enum Status
    {
        /// <summary>
        /// Request succeeded.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Entity did not meet validation requirements.
        /// </summary>
        ValidationError = 1,

        /// <summary>
        /// Error along the Identity/Authentication pipeline.
        /// </summary>
        AuthenticationError = 2,
    }
}
