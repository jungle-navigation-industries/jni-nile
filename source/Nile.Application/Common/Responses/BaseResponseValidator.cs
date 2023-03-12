using FluentValidation;

namespace Nile.Application.Common.Responses
{
    internal class BaseResponseValidator : AbstractValidator<BaseResponse>
    {
        public BaseResponseValidator()
        {
            RuleFor(response => response.Status).NotEqual(Status.Success);
        }
    }
}
