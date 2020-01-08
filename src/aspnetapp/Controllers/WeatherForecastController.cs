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
            return "Happy New Year 2020 From Fox Team！";
        }
    }
}
