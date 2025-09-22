

using MediatR;
using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Infrastructure.Sansad;

namespace TrueRepApis.Application.Queries.Regions;

public class GetStates : IRequest<List<State>>
{
}

public class GetStatesHandler(ISansadInfrastructure sansadInfrastructure) : IRequestHandler<GetStates, List<State>>
{
    private readonly ISansadInfrastructure _sansadInfrastructure = sansadInfrastructure;

    public async Task<List<State>> Handle(GetStates request, CancellationToken cancellationToken)
    {
        var response = await _sansadInfrastructure.GetStates();
        return [.. response.Select(x => new State(
            name: x.StateName, 
            code: x.StateCode
            )
        )];
    }
}