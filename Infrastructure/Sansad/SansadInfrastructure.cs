using TrueRepApis.Configuration;
using TrueRepApis.Domain.ValueObjects;
using TrueRepApis.Infrastructure.Common;
using TrueRepApis.Infrastructure.Sansad.Models;

namespace TrueRepApis.Infrastructure.Sansad;

public class SansadInfrastructure(HttpClient httpClient, ApiClient apiClient, EndpointResolver endpointResolver) : ISansadInfrastructure
{
    private readonly ApiClient _apiClient = apiClient;
    private readonly EndpointResolver _endpointResolver = endpointResolver;
    private const string _serviceKey = "sansad";

    public async Task<List<StateDto>> GetStates()
    {
        var endpoint = _endpointResolver.Resolve(_serviceKey, "get-states");
        try
        {
            
            var response = await _apiClient.Invoke<List<StateDto>>(endpoint.Verb, endpoint.Url);
            return response;
        }
        catch (Exception ex)
        {
            throw new Exception("Error getting states", ex);
        }

    }

    public async Task<List<ConstituencyDto>> GetConstituencies(State state)
    {
        // var endpoint = _endpointResolver.Resolve(_serviceKey, "get-constituencies");
        // try
        // {
        //     var response = await _apiClient.Invoke<List<ConstituencyDto>>(endpoint.Verb, endpoint.Url);
        //     return response;
        // }
    
        // catch (Exception ex)
        // {
        //     throw new Exception("Error getting states", ex);
        // }

        throw new NotImplementedException("Not implemented");
    
    }
}