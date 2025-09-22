namespace TrueRepApis.Configuration;

public class Settings
{
    public List<DownstreamService> DownstreamServices { get; set; } = new();
}

public class DownstreamService
{
    public string Key { get; set; } = string.Empty;
    public string Host { get; set; } = string.Empty;
    public List<Endpoint> Endpoints { get; set; } = new();
}

public class Endpoint
{
    public string Key { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Verb { get; set; } = string.Empty;
}