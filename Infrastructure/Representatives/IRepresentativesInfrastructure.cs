

using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Domain.Entities;

namespace TrueRepApis.Infrastructure.Representatives;


public interface IRepresentativesInfrastructure
{
    Task<Representative> GetParliamentaryRepresentative(State state, Constituency constituency);
}