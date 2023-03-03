using Microsoft.Extensions.DependencyInjection;
using Nile.Application.Characters.Common;

namespace Nile.Infrastructure.Characters
{
    public static class CharacterModule
    {
        public static void RegisterCharacter(this IServiceCollection services)
        {
            services.AddTransient<ICharacterRepository, CharacterRepository>();
        }
    }
}
