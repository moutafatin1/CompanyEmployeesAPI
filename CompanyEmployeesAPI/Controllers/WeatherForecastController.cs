using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployeesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ILoggerManager _logger;

        public WeatherForecastController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Here Info message");
            _logger.LogDebug("Here Debug message");
            _logger.LogWarn("Here Warning message");
            _logger.LogError("Here Error message");
            return new string[] { "oussama", "wafaa", "wisaal" };
        }
    }
}