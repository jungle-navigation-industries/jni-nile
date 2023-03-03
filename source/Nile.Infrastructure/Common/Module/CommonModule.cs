using System.Reflection;
using ESI.NET;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Nile.Infrastructure.Common.Module
{
    public static class CommonModule
    {
        public static void AddCommonDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEsi(configuration.GetSection("EsiConfig"));

            services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.Load("Nile.Application")));
        }
    }
}
