

using System.Text.Json.Serialization;

namespace TrueRepApis.Controllers.Regions.Models;

public class State
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("code")]
    public string Code { get; set; } = string.Empty;
}