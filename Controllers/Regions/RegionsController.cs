using Application.Queries.Regions;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TrueRepApis.Application.Queries.Regions;
using TrueRepApis.Controllers.Regions.Models;

namespace TrueRepApis.Controllers.Regions;

[ApiController]
[Route("api/regions")]
public class RegionsController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet("states")]
    public async Task<ActionResult<List<State>>> GetStates()
    {
        try
        {
            var getStatesQuery = new GetStates();
            var regions = await _mediator.Send(getStatesQuery);
            return Ok(regions);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("states/{state_id}/loksabha/constituencies")]
    public async Task<ActionResult<List<Constituency>>> GetConstituencies(string stateId)
    {
        
        try
        {
            var getLoksabhaConstituenciesQuery = new GetLoksabhaConstituencies(stateId);
            var constituencies = await _mediator.Send(getLoksabhaConstituenciesQuery);
            return Ok(constituencies);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }
}