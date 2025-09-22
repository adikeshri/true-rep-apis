using TrueRepApis.Configuration;
using TrueRepApis.Domain.Entities;
using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Infrastructure.Representatives;
namespace TrueRepApis.Infrastructure.Representatives;

public class RepresentativesInfrastructure(
    HttpClient httpClient,
    Settings settings
    ) : IRepresentativesInfrastructure
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly Settings _settings = settings;

    public async Task<Representative> GetParliamentaryRepresentative(State state, Constituency constituency)
    {
        await Task.Delay(6);
        Console.WriteLine(_settings.DownstreamServices.First().Key);
        throw new NotImplementedException();
    }
}
