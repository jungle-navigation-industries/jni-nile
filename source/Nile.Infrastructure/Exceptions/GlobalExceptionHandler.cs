using MediatR;
using Serilog;

namespace Nile.Infrastructure.Exceptions
{
    internal class GlobalExceptionHandler : INotificationHandler<GlobalExceptionOccurred>
    {
        private readonly ILogger _logger;

        public GlobalExceptionHandler(ILogger logger)
        {
            _logger = logger;
        }

        public Task Handle(GlobalExceptionOccurred notification, CancellationToken cancellationToken)
        {
            _logger.Error(notification.Exception, notification.Exception.Message);

            return Task.CompletedTask;
        }
    }
}
