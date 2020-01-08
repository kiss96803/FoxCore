using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FoxCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
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
