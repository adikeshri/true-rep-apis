using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TrueRepApis.Infrastructure.Common.Models;

namespace TrueRepApis.Infrastructure.Common;

public class ApiClient(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<TResponse> Invoke<TRequest, TResponse>(
        HttpVerb httpVerb, 
        string url, 
        TRequest data
    )
    {
        HttpResponseMessage response = httpVerb switch
        {
            HttpVerb.POST => await _httpClient.PostAsJsonAsync(url, data!),
            HttpVerb.PUT => await _httpClient.PutAsJsonAsync(url, data!),
            _ => throw new NotSupportedException($"HTTP verb {httpVerb} is not supported."),
        };
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<TResponse>();

    }

    public async Task<TResponse> Invoke<TResponse>(
        HttpVerb httpVerb, 
        string url
    )
    {

        HttpResponseMessage response = httpVerb switch
        {
            HttpVerb.GET => await _httpClient.GetAsync(url),
            HttpVerb.DELETE => await _httpClient.DeleteAsync(url),
            _ => throw new NotSupportedException($"HTTP verb {httpVerb} is not supported."),
        };
        response.EnsureSuccessStatusCode();

        if (httpVerb == HttpVerb.GET)
        {
            return await response.Content.ReadFromJsonAsync<TResponse>();
        }

        return default;
    }
    public async Task<T?> GetAsync<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<T>();
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest data)
    {
        var response = await _httpClient.PostAsJsonAsync(url, data);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task<TResponse?> PutAsync<TRequest, TResponse>(string url, TRequest data)
    {
        var response = await _httpClient.PutAsJsonAsync(url, data);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<TResponse>();
    }

    public async Task DeleteAsync(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        response.EnsureSuccessStatusCode();
    }
}