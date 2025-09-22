
using MediatR;
using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Infrastructure.Sansad;


namespace Application.Queries.Regions
{
    public class GetLoksabhaConstituencies(string StateId) : IRequest<List<Constituency>>
    {
        public string StateId { get; } = StateId;
    }

    public class GetLoksabhaConstituenciesHandler(ISansadInfrastructure sansadInfrastructure) : IRequestHandler<GetLoksabhaConstituencies, List<Constituency>>
    {
        private readonly ISansadInfrastructure _sansadInfrastructure = sansadInfrastructure;
        public Task<List<Constituency>> Handle(GetLoksabhaConstituencies request, CancellationToken cancellationToken)
        {

            var state = new State(
                name: null,
                code: request.StateId
            );

            throw new NotImplementedException("Not implemented");
        }
    }
}