using System.Text.Json.Serialization;
using FluentValidation;

namespace Nile.Application.Common.Responses
{
    public abstract class BaseResponse
    {
        protected BaseResponse()
        {
            Status = Status.Success;
            ErrorMessage = string.Empty;
        }

        protected BaseResponse(Status status, string errorMessage)
        {
            Status = status;
            ErrorMessage = errorMessage;

            var validator = new BaseResponseValidator();
            validator.ValidateAndThrow(this);
        }

        [JsonIgnore]
        public Status Status { get; }

        [JsonIgnore]
        public string ErrorMessage { get; }
    }
}
