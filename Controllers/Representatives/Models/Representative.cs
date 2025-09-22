using System.Text.Json.Serialization;

namespace TrueRepApis.Controllers.Representatives.Models;

public class Representative
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("party")]
    public string Party { get; set; } = string.Empty;
    [JsonPropertyName("representation")]
    public RepresentationType Representation{ get; set; }
}

public enum RepresentationType
{
    [JsonPropertyName("member_of_parliament")]
    MemberOfParliament,
    [JsonPropertyName("member_of_legislative_assembly")]
    MemberOfLegislativeAssembly
}



