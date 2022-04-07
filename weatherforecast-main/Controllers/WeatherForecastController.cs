using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherForcastAPI _weatherForecast;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForcastAPI weatherForecast)
        {
            _logger = logger;
            _weatherForecast = weatherForecast;
        }

    [HttpGet()]

       public async Task<IActionResult> GetWeather(string CityName)
    {
      var Weather = await _weatherForecast.GetCityWeather(CityName);

      if (Weather   == null)
      {
        return NotFound();
      }
 
      return Ok(Weather);
    }

    }
}
