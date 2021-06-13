using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weather.Service;

namespace Weather.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/weather")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherCurrentService _weatherCurrentService;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherController(
            ILogger<WeatherController> logger,
            IWeatherCurrentService weatherCurrentService,
            IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherCurrentService = weatherCurrentService;
            _weatherForecastService = weatherForecastService;
        }
        [HttpGet("current")]
        public async Task<IActionResult> GetCurrent(string cityName = "istanbul")
        {
            var result = await _weatherCurrentService.Get(cityName);
            return Ok(result);
        }

        [HttpGet("forecast")]
        public async Task<IActionResult> GetForecast(string cityName = "istanbul", int day = 1)
        {
            var result = await _weatherForecastService.Get(cityName, day);
            return Ok(result);
        }

    }
}
