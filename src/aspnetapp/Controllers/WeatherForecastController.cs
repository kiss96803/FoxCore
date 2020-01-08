using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoxCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string  Get()
        {
            return "Hello Wolrd 2020";
        }
    }
}
