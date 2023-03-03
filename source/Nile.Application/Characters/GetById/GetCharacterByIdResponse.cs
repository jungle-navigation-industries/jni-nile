using ESI.NET.Models.Character;

namespace Nile.Application.Characters.GetById
{
    public class GetCharacterByIdResponse
    {
        public GetCharacterByIdResponse(Information information)
        {
            Information = information;
        }

        public Information Information { get; }
    }
}
