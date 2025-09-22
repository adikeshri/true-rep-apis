namespace TrueRepApis.Application;

public class WeatherService : IWeatherService
{
    public string GetWeatherForecast()
    {
        return "Sunny with a chance of rain";
    }
}
