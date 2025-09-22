using System.Text.Json.Serialization;

namespace TrueRepApis.Controllers.Regions.Models;

public class Constituency
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}