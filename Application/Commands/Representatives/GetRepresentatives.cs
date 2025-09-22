using MediatR;
using TrueRepApis.Controllers.Representatives.Models;
using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Infrastructure.Representatives;

namespace TrueRepApis.Application.Commands.Representatives;

public class GetRepresentatives : IRequest<List<Representative>>
{
    public required string State { get; set; }
    public required string Constituency { get; set; }
}

public class GetRepresentativesHandler(IRepresentativesInfrastructure representativesInfrastructure) : IRequestHandler<GetRepresentatives, List<Representative>>
{
    private readonly IRepresentativesInfrastructure _representativeInfrastructure = representativesInfrastructure;

    public async Task<List<Representative>> Handle(GetRepresentatives request, CancellationToken cancellationToken)
    {
        var representatives = new List<Representative>
        {
            new() {
                Id = 1,
                Name = "John Doe"
            },
            new() {
                Id = 2,
                Name = "Jane Smith"
            }
        };

        var data = await _representativeInfrastructure.GetParliamentaryRepresentative(new State(request.State), new Constituency(request.Constituency));

        return representatives;
    }
}
