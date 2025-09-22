

using TrueRepApis.Configuration;
using TrueRepApis.Infrastructure.Common.Models;

namespace TrueRepApis.Infrastructure.Common;

public record ResolvedEndpoint(HttpVerb Verb, string Url);

public class EndpointResolver(Settings settings)
{
    public readonly Settings _settings = settings;

    public ResolvedEndpoint Resolve(string serviceKey, string endpointKey)
    {
        var service = _settings.DownstreamServices.FirstOrDefault(x => x.Key == serviceKey) ?? throw new Exception("Endpoint resolver: Service not found");
        var endpoint = service.Endpoints.FirstOrDefault(x => x.Key == endpointKey) ?? throw new Exception("Endpoint resolver: Endpoint not found");
        var verb = endpoint.Verb;
        var url = $"{service.Host}{endpoint.Url}";
        return new ResolvedEndpoint(Enum.Parse<HttpVerb>(verb, ignoreCase: true), url);
    }
}