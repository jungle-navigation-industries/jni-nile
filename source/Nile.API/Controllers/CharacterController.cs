using MediatR;
using Microsoft.AspNetCore.Mvc;
using Nile.Application.Characters.GetById;

namespace Nile.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CharacterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{characterId:int}", Name = "GetCharacterById")]
        [ProducesResponseType(typeof(GetCharacterByIdResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Character(int characterId)
        {
            var response = await _mediator.Send(new GetCharacterById(characterId));

            return Ok(response);
        }
    }
}
