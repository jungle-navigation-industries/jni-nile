using MediatR;
using Nile.Application.Characters.Common;

namespace Nile.Application.Characters.GetById
{
    internal class GetCharacterByIdHandler : IRequestHandler<GetCharacterById, GetCharacterByIdResponse>
    {
        private readonly ICharacterRepository _repository;

        public GetCharacterByIdHandler(ICharacterRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCharacterByIdResponse> Handle(GetCharacterById request, CancellationToken cancellationToken)
        {
            var character = await _repository.GetCharacterById(request.Id);

            return new GetCharacterByIdResponse(character);
        }
    }
}
