using MediatR;

namespace Nile.Application.Characters.GetById
{
    public class GetCharacterById : IRequest<GetCharacterByIdResponse>
    {
        public GetCharacterById(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
}
