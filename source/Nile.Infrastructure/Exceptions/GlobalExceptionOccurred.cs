using MediatR;

namespace Nile.Infrastructure.Exceptions
{
    public class GlobalExceptionOccurred : INotification
    {
        public GlobalExceptionOccurred(Exception exception)
        {
            Exception = exception;
        }

        public Exception Exception { get; }
    }
}
