using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers;

[ApiController]
[Route("api/minha-controller")]
public class WeatherForecastController : ControllerBase
{

    public WeatherForecastController()
    {

    }

    [HttpGet("teste")]
    public IActionResult Get()
    {
        return Ok();
    }
}
