using ESI.NET.Models.Character;
using Nile.Application.Common.Responses;

namespace Nile.Application.Characters.GetById
{
    public class GetCharacterByIdResponse : BaseResponse
    {
        public GetCharacterByIdResponse(Information information)
        {
            Information = information;
        }

        public Information Information { get; }
    }
}
