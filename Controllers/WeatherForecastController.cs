using Microsoft.AspNetCore.Mvc;
using TrueRepApis.Application;

namespace TrueRepApis.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWeatherService weatherService) : ControllerBase
{
    private readonly IWeatherService _weatherService = weatherService;

    [HttpGet]
    public IActionResult Get()
    {
        var result = _weatherService.GetWeatherForecast();
        return Ok(result);
    }
}
