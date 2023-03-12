using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nile.API.Common.Controllers;
using Nile.Application.Characters.GetById;

namespace Nile.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : BaseController
    {
        public CharacterController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet("{characterId:int}", Name = "GetCharacterById")]
        [ProducesResponseType(typeof(GetCharacterByIdResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Character(int characterId)
        {
            return await ExecuteRequest(new GetCharacterById(characterId), ResponseOptions.OkResponse);
        }
    }
}
