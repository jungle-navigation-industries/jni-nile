using ESI.NET.Models.Character;

namespace Nile.Application.Characters.Common
{
    public interface ICharacterRepository
    {
        public Task<Information> GetCharacterById(int id);
    }
}
