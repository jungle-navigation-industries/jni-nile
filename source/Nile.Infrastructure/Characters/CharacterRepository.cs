using ESI.NET;
using ESI.NET.Models.Character;
using Nile.Application.Characters.Common;

namespace Nile.Infrastructure.Characters
{
    internal class CharacterRepository : ICharacterRepository
    {
        private readonly IEsiClient _esiClient;

        public CharacterRepository(IEsiClient esiClient)
        {
            _esiClient = esiClient;
        }

        public async Task<Information> GetCharacterById(int id)
        {
            var esiResponse = await _esiClient.Character.Information(id);

            return esiResponse.Data;
        }
    }
}
