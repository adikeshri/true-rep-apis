
using System.Text.Json.Serialization;

namespace TrueRepApis.Infrastructure.Sansad.Models;

public class StateDto
{
    [JsonPropertyName("stateCode")]
    public string StateCode { get; set; } = string.Empty;
    [JsonPropertyName("stateName")]
    public string StateName { get; set; } = string.Empty;
    [JsonPropertyName("stateNameHindi")]
    public string StateNameHindi { get; set; } = string.Empty;
}