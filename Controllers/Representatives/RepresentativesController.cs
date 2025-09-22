
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrueRepApis.Application.Commands.Representatives;
using TrueRepApis.Controllers.Representatives.Models;

namespace TrueRepApis.Controllers.Representatives;

[ApiController]
public class RepresentativesController(IMediator mediator) : ControllerBase
{

    private readonly IMediator _mediator = mediator;

    [HttpGet("representatives/{state}/{constituency}")]
    /// <summary>
    /// Get representatives for a given state and constituency
    /// </summary>
    /// <param name="state">The state to get representatives for</param>
    /// <param name="constituency">The constituency to get representatives for</param>
    /// <returns>A list of representatives</returns>
    public async Task<ActionResult<List<Representative>>> GetRepresentatives(
        [FromRoute] string state, 
        [FromRoute] string constituency
    )
    {
        var getRepresentativesCommand = new GetRepresentatives { State = state, Constituency = constituency };
        var result = await _mediator.Send(getRepresentativesCommand);
        return Ok(result);
    }
}