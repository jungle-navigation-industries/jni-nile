using System.Reflection;
using ESI.NET;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Nile.Infrastructure.Common.Module
{
    public static class CommonModule
    {
        public static void AddCommonDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEsi(configuration.GetSection("EsiConfig"));

            services.AddMediatR(config => config.RegisterServicesFromAssemblies(Assembly.Load("Nile.Application"), Assembly.Load("Nile.Infrastructure")));

            var loggerConfiguration = new LoggerConfiguration()
                                        .WriteTo.Console()
                                        .CreateLogger();

            services.AddSingleton<ILogger>(_ => loggerConfiguration);
        }
    }
}
